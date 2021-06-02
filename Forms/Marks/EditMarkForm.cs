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
        }

        public LogEntities log;
        private FillDataGridView fillGrid;
        private bool IsLogDisposed = false;
        bool IsSorted = false;

        private void ViewMarkForm_Load(object sender, EventArgs e)
        {
            fillGrid();
            //Задаем размер по заполнению
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void FillData()
        {
            if (!IsSorted)
            {
                log?.Dispose();
                log = new LogEntities();
                markBindingSource.DataSource = log.marks.ToList();
                studentBindingSource.DataSource = log.students.ToList();
                subjectBindingSource.DataSource = log.subjects.ToList();
                typeMarkBindingSource.DataSource = log.typeMarks.ToList();
                groupBindingSource.DataSource = log.groups.ToList();
            }
            else
            {
                FillSorted();
            }
        }

        private void ViewMarkForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            log.SaveChanges();
            log.Dispose();
            IsLogDisposed = true;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
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
            groupCheckBox.Checked = true;
            mark mark = new mark();
            log.marks.Add(mark);
            log.SaveChanges();
            fillGrid();
        }

        private void AddGroupBtn_Click(object sender, EventArgs e)
        {
            AddGroupMarkForm addGroupMarkForm = new AddGroupMarkForm(ref fillGrid);
            addGroupMarkForm.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (groupCheckBox.Checked)
            {
                IsSorted =false;
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
            if(!IsLogDisposed)
            {
                List<mark> marksGroup;
                string id = groupComboBox.SelectedValue?.ToString();
                SqlParameter parameter = new SqlParameter("@ID", id);

                string sql = "select * from marks where StudentId in (" +
                    "select PassportId from studetns where GroupId in(" +
                    "select Id from groups where Id = @ID))";

                marksGroup = log.Database.SqlQuery<mark>(sql, parameter).ToList();
                markBindingSource.DataSource = marksGroup;
            }
        }

        private void groupComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillSorted();
        }

        private void dataGridView_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if(dataGridView.SelectedCells[0].OwningColumn.Index == 2)
            {
                if (e.Control as ComboBox != null)
                {
                    int rowIndex = dataGridView.SelectedCells[0].RowIndex;
                    string passportId = dataGridView.Rows[rowIndex].Cells[1].Value.ToString();
                    (e.Control as ComboBox).DataSource = bindingSource;
                    SqlParameter parameter = new SqlParameter("@PASSPORT", passportId);

                    string sql = "" +
                        "declare @groupId nchar(10);" +
                        "select @groupId = studetns.GroupId from studetns where PassportId = @PASSPORT;" +
                        "select * from subjects where Id in(" +
                        "select subjects_to_groups.SubjectId from subjects_to_groups where GroupId in (@groupId)); ";
                    bindingSource.DataSource = log.Database.SqlQuery<subject>(sql, parameter).ToList();
                }
            }
        }
    }
}
