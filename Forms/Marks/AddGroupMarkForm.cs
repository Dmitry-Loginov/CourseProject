using System;
using System.Collections.Generic;
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
            log = new LogEntities();
            FillDataGridView = fillGrid;
            studentBindingSource.DataSource = log.students.ToList();
            FillSubjectsOfStudent();
            typeMarkBindingSource.DataSource = log.typeMarks.ToList();
        }

        private void AddButton_Click(object sender, System.EventArgs e)
        {
            List<mark> marks = new List<mark>();
            int count = Convert.ToInt32(countListBox.SelectedItem.ToString());
            for (int i = 0; i < count; i++)
            {
                marks.Add(new mark());
                marks[i].studetn = (student)studetnComboBox.SelectedItem;
                marks[i].subject = (subject)subjectComboBox.SelectedItem;
                marks[i].typeMark = (typeMark)typeMarkComboBox.SelectedItem;
                marks[i].Month = Convert.ToInt32(monthListBox.SelectedItem.ToString());
                marks[i].Value = ballListBox.SelectedItem.ToString();
            }
            log.marks.AddRange(marks);
            log.SaveChanges();
            FillDataGridView();
        }


        private void studetnComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillSubjectsOfStudent();
        }

        void FillSubjectsOfStudent()
        {
            if(studetnComboBox.SelectedItem as student != null)
            {
                string passportId = (studetnComboBox.SelectedItem as student).PassportId;
                SqlParameter parameter = new SqlParameter("@PASSPORT", passportId);
                string sql = "" +
                            "declare @groupId nchar(10);" +
                            "select @groupId = studetns.GroupId from studetns where PassportId = @PASSPORT;" +
                            "select * from subjects where Id in(" +
                            "select subjects_to_groups.SubjectId from subjects_to_groups where GroupId in (@groupId)); ";
                bindingSource.DataSource = log.Database.SqlQuery<subject>(sql, parameter).ToList();

                subjectComboBox.DataSource = bindingSource;
            }
        }

        private void AddGroupMarkForm_Load(object sender, EventArgs e)
        {
            monthCheckBoxVoid.Text = ballCheckBoxVoid.Text = countCheckBoxVoid.Text = "Оставить\nпустым";
        }

        private void monthCheckBoxVoid_CheckedChanged(object sender, EventArgs e)
        {
            monthListBox.Enabled = !monthCheckBoxVoid.Checked;
        }

        private void studentCheckBoxVoid_CheckedChanged(object sender, EventArgs e)
        {
            studetnComboBox.Enabled = !studentCheckBoxVoid.Checked;
        }

        private void subjectCheckBoxVoid_CheckedChanged(object sender, EventArgs e)
        {
            subjectComboBox.Enabled = !subjectCheckBoxVoid.Checked;
        }

        private void typeMarkCheckBoxVoid_CheckedChanged(object sender, EventArgs e)
        {
            typeMarkComboBox.Enabled = !typeMarkCheckBoxVoid.Checked;
        }

        private void ballCheckBoxVoid_CheckedChanged(object sender, EventArgs e)
        {
            ballListBox.Enabled = !ballCheckBoxVoid.Checked;
        }

        private void countCheckBoxVoid_CheckedChanged(object sender, EventArgs e)
        {
            countListBox.Enabled = !countCheckBoxVoid.Checked;
        }
    }
}
