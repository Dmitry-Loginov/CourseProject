using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Sql;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data.SqlTypes;
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

        LogEntities log;
        FillDataGridView fillGrid;

        private void ViewMarkForm_Load(object sender, EventArgs e)
        {
            fillGrid();
            //Задаем размер по заполнению
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        void FillData()
        {
            log?.Dispose();
            log = new LogEntities();
            markBindingSource.DataSource = log.marks.ToList();
            studentBindingSource.DataSource = log.students.ToList();
            subjectBindingSource.DataSource = log.subjects.ToList();
            typeMarkBindingSource.DataSource = log.typeMarks.ToList();
            groupBindingSource.DataSource = log.groups.ToList();
        }

        private void ViewMarkForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            log.SaveChanges();
            log.Dispose();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            int keySelectedIndex = Convert.ToInt32(dataGridView.SelectedRows[0].Cells[0].Value.ToString());
            mark mark = log.marks.Find(keySelectedIndex);
            log.marks.Remove(mark);
            int delIndex = dataGridView.SelectedRows[0].Index;
            dataGridView.Rows.RemoveAt(delIndex);
            log.SaveChanges();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
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
                groupComboBox.Enabled = false;
                markBindingSource.DataSource = log.marks.ToList();
            }
            else 
            {
                groupComboBox.Enabled = true;
                FillSorted();
            }
        }

        void FillSorted()
        {
            List<mark> marksGroup;
            string id = groupComboBox.SelectedValue?.ToString();
            SqlParameter parameter = new SqlParameter("@ID", id);

            string sql = "select * from marks where StudentId in (" +
                "select PassportId from studetns where GroupId in(" +
                "select Id from groups where Id = @ID))";

            if(log != null)
            {
                marksGroup = log.Database.SqlQuery<mark>(sql, parameter).ToList();
                markBindingSource.DataSource = marksGroup;
            }
        }

        private void groupComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillSorted();
        }
    }
}