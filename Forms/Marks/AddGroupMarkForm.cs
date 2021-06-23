using System;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace Log
{
    public partial class AddGroupMarkForm : Form
    {
        LogEntities log;
        FillDataGridView FillDataGridView;

        public AddGroupMarkForm(ref FillDataGridView fillGrid)
        {
            InitializeComponent();
            log = LogEntities.GetInstance();
            FillDataGridView = fillGrid;
            groupBindingSource.DataSource = log.groups.ToList();
            FillStudents();
            typeMarkBindingSource.DataSource = log.typeMarks.ToList();
            countListBox.SelectedIndex = 0;
        }

        private void AddButton_Click(object sender, System.EventArgs e)
        {
            mark mark;
            int count = Convert.ToInt32(countListBox.SelectedItem.ToString());
            for (int i = 0; i < count; i++)
            {
                mark = new mark();
                if(!studentCheckBoxVoid.Checked) mark.StudentId = ((student)studetnComboBox.SelectedItem).PassportId;
                if(!subjectCheckBoxVoid.Checked) mark.SubjectId = ((subject)subjectComboBox.SelectedItem).Id;
                if(!typeMarkCheckBoxVoid.Checked) mark.TypeId = ((typeMark)typeMarkComboBox.SelectedItem).Id;
                if(monthListBox.SelectedIndex >= 0) mark.Month = Convert.ToInt32(monthListBox.SelectedItem.ToString());
                if(ballListBox.SelectedIndex >= 0) mark.Value = ballListBox.SelectedItem.ToString();
                log.marks.Add(mark);
                log.SaveChanges();
                log = LogEntities.GetInstance();
                FillDataGridView();
            }
        }


        private void studetnComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillSubjects();
        }


        private void studentCheckBoxVoid_CheckedChanged(object sender, EventArgs e)
        {
            studetnComboBox.Enabled = !studentCheckBoxVoid.Checked;
            FillSubjects();
        }

        private void subjectCheckBoxVoid_CheckedChanged(object sender, EventArgs e)
        {
            subjectComboBox.Enabled = !subjectCheckBoxVoid.Checked;
        }

        private void typeMarkCheckBoxVoid_CheckedChanged(object sender, EventArgs e)
        {
            typeMarkComboBox.Enabled = !typeMarkCheckBoxVoid.Checked;
        }

        private void groupCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            groupComboBox.Enabled = !groupCheckBox.Checked;
            if (!groupCheckBox.Checked)
            {
                studentCheckBoxVoid.Checked = false;
                studentCheckBoxVoid.Enabled = false;
            }
            else
            {
                studentCheckBoxVoid.Enabled = true;
            }
            FillStudents();

        }

        private void groupComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillStudents();
        }

        void FillSubjects()
        {
            if (!LogEntities.IsExistInstance) return;
            if (studentCheckBoxVoid.Checked)
            {
                if (groupCheckBox.Checked)
                {
                    subjectBindingSource.DataSource = log.subjects.ToList();
                    subjectComboBox.DataSource = subjectBindingSource;
                }
                else
                {
                    FillSortedSubject();
                }
            }
            else
            {
                FillSortedSubject();
            }
        }

        void FillStudents()
        {
            if (!LogEntities.IsExistInstance) return;
            if (groupCheckBox.Checked)
            {
                studentBindingSource.DataSource = log.students.ToList();
                studetnComboBox.DataSource = studentBindingSource;
            }
            else
            {
                if (studetnComboBox.SelectedItem as student != null && groupComboBox.SelectedItem as group != null)
                {
                    string groupId = (groupComboBox.SelectedItem as group).Id;

                    SqlParameter sqlParameter = new SqlParameter("@GROUPID", groupId);
                    string sql = "select * from studetns where GroupId = @GROUPID";

                    studentBinding.DataSource = log.Database.SqlQuery<student>(sql, sqlParameter).ToList();
                    studetnComboBox.DataSource = studentBinding;
                }
            }
            FillSubjects();
        }

        void FillSortedSubject()
        {
            if (studetnComboBox.SelectedItem as student != null)
            {
                string passportId = (studetnComboBox.SelectedItem as student).PassportId;
                SqlParameter parameter = new SqlParameter("@PASSPORT", passportId);
                string sql = "" +
                            "declare @groupId nchar(10);" +
                            "select @groupId = studetns.GroupId from studetns where PassportId = @PASSPORT;" +
                            "select * from subjects where Id in(" +
                            "select subjects_to_groups.SubjectId from subjects_to_groups where GroupId in (@groupId)); ";
                subjectBinding.DataSource = log.Database.SqlQuery<subject>(sql, parameter).ToList();

                subjectComboBox.DataSource = subjectBinding;
            }
        }
    }
}
