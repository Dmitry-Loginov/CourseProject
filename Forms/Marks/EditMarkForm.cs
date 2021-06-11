using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace Log
{
    public partial class EditMarkForm : Form
    {
        public EditMarkForm()
        {
            InitializeComponent();
            fillGrid = FillData;
            log = LogEntities.GetInstance();
        }
        
        public LogEntities log;
        private FillDataGridView fillGrid;
        private bool IsClosed = false;
        bool IsSorted = false;

        private void ViewMarkForm_Load(object sender, EventArgs e)
        {
            fillGrid();
            //Задаем размер по заполнению
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void FillData()
        {
            log = LogEntities.GetInstance();
            if (!IsSorted)
            {
                groupBindingSource.DataSource = log.groups.ToList();
                markBindingSource.DataSource = log.marks.ToList();
                studentBindingSource.DataSource = log.students.ToList();
                subjectBindingSource.DataSource = log.subjects.ToList();
                typeMarkBindingSource.DataSource = log.typeMarks.ToList();
            }
            else
            {
                FillSorted();
            }
        }

        private void ViewMarkForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            IsClosed = true;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            log = LogEntities.GetInstance();
            int keySelectedIndex = Convert.ToInt32(GetSelectedId());
            mark mark = log.marks.Find(keySelectedIndex);
            log.marks.Remove(mark);
            int delIndex = dataGridView.SelectedCells[0].RowIndex;
            dataGridView.Rows.RemoveAt(delIndex);
            log.SaveChanges();
        }

        string GetSelectedId()
        {
            int rowIndex = dataGridView.SelectedCells[0].RowIndex;
            return dataGridView.Rows[rowIndex].Cells[0].Value.ToString();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            log = LogEntities.GetInstance();
            mark mark = new mark();
            if (!groupCheckBox.Checked)
            {
                mark.studetn = log.students.Where(s => s.GroupId == groupComboBox.SelectedValue.ToString()).FirstOrDefault();
            }
            log.marks.Add(mark);
            log.SaveChanges();
            fillGrid();
        }

        private void AddGroupBtn_Click(object sender, EventArgs e)
        {
            AddGroupMarkForm addGroupMarkForm = new AddGroupMarkForm(ref fillGrid, this);
            addGroupMarkForm.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            log.SaveChanges();
            log = LogEntities.GetInstance();
            if (groupCheckBox.Checked)
            {
                IsSorted = false;
                groupComboBox.Enabled = false;
                markBindingSource.DataSource = log.marks.ToList();
            }
            else 
            {
                IsSorted = true;
                groupComboBox.Enabled = true;
                FillSorted();
            }
        }

        private void FillSorted()
        {
            log.SaveChanges();
            if (!LogEntities.IsExistInstance) return;
            if (!IsClosed)
            {
                log = LogEntities.GetInstance();
                List<mark> marksGroup;
                string id = groupComboBox.SelectedValue?.ToString();
                SqlParameter parameter = new SqlParameter("@ID", id);

                string sql = "select * from marks where StudentId in (" +
                    "select PassportId from studetns where GroupId in(" +
                    "select Id from groups where Id = @ID))";

                marksGroup = log.marks.SqlQuery(sql, parameter).ToList();
                markBindingSource.DataSource = marksGroup;
            }
        }

        private void groupComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillSorted();
        }

        private void dataGridView_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            log = LogEntities.GetInstance();
            if(dataGridView.SelectedCells[0].OwningColumn.Index == 1 && !groupCheckBox.Checked)
            {
                EditingStudentComboBox(e);
                log.SaveChanges();
            }
            
            if(dataGridView.SelectedCells[0].OwningColumn.Index == 2)
            {
                EditingSubjectComboBox(e);
            }
        }

        void EditingSubjectComboBox(DataGridViewEditingControlShowingEventArgs e)
        {
            log = LogEntities.GetInstance();
            if (!LogEntities.IsExistInstance) return;
            if (e.Control as ComboBox != null)
            {
                string passportId = GetPassportIdSelectedStudent();
                (e.Control as ComboBox).DataSource = subjectBinding;
                SqlParameter parameter = new SqlParameter("@PASSPORT", passportId);

                string sql = "" +
                    "declare @groupId nchar(10);" +
                    "select @groupId = studetns.GroupId from studetns where PassportId = @PASSPORT;" +
                    "select * from subjects where Id in(" +
                    "select subjects_to_groups.SubjectId from subjects_to_groups where GroupId in (@groupId)); ";
                subjectBinding.DataSource = log.Database.SqlQuery<subject>(sql, parameter).ToList();
            }
        }

        void EditingStudentComboBox(DataGridViewEditingControlShowingEventArgs e)
        {
            if (!LogEntities.IsExistInstance) return;
            if (e.Control as ComboBox != null)
            {
                log = LogEntities.GetInstance();
                string groupId = (groupComboBox.SelectedItem as group).Id;
                (e.Control as ComboBox).DataSource = studentBinding;
                SqlParameter parameter = new SqlParameter("@GROUPID", groupId);

                string sql = "select * from studetns where GroupId = @GROUPID";

                studentBinding.DataSource = log.Database.SqlQuery<student>(sql, parameter).ToList();
            }
        }

        string GetPassportIdSelectedStudent()
        {
            int rowIndex = dataGridView.SelectedCells[0].RowIndex;
            return dataGridView.Rows[rowIndex].Cells[1].Value.ToString();
        }
    }
}
