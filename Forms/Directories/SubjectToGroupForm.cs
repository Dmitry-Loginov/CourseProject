using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Log
{
    public partial class SubjectToGroupForm : Form
    {
        LogEntities LogEntities;
        FillSubjectToGroupGrid FillSubjectToGroup { get; set; }

        void FillGrid()
        {
            List<SubjectToGroupViewModelItem> targetItems = new List<SubjectToGroupViewModelItem>();
            var subject_groups = LogEntities.subjects_to_groups.ToList();
            for (int i = 0; i < subject_groups.Count; i++)
            {
                SubjectToGroupViewModelItem modelItem = new SubjectToGroupViewModelItem(subject_groups[i].Id, subject_groups[i].GroupId, subject_groups[i].subject.SubjectName);
                targetItems.Add(modelItem);
            }
            subjects_to_groupsDataGridView.DataSource = targetItems;
            subjects_to_groupsDataGridView.Columns[0].Visible = false;
            subjects_to_groupsDataGridView.Columns[1].HeaderText = "Группа";
            subjects_to_groupsDataGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            subjects_to_groupsDataGridView.Columns[2].HeaderText = "Предмет";
            subjects_to_groupsDataGridView.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        public SubjectToGroupForm()
        {
            InitializeComponent();
            LogEntities = LogEntities.GetInstance();
            FillSubjectToGroup += FillGrid;
            FillSubjectToGroup();
        }

        private void SubjectToGroupForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "logDataSet.subjects_to_groups". При необходимости она может быть перемещена или удалена.
            this.subjects_to_groupsTableAdapter.Fill(this.logDataSet.subjects_to_groups);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "logDataSet.subjects_to_groups". При необходимости она может быть перемещена или удалена.
            this.subjects_to_groupsTableAdapter.Fill(this.logDataSet.subjects_to_groups);

        }

        private void SubjectToGroupForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            LogEntities.SaveChanges();
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var resultQuestion = MessageBox.Show("Удалить?", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(resultQuestion == DialogResult.Yes)
            {
                int id = Convert.ToInt32(subjects_to_groupsDataGridView.CurrentRow.Cells[0].Value);
                string sql = "delete from subjects_to_groups where Id = " + id.ToString() + ";";
                LogEntities.Database.ExecuteSqlCommand(sql);
                LogEntities.SaveChanges();
                FillSubjectToGroup();
            }
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddSubjectToGroup addSubjectToGroup = new AddSubjectToGroup(FillSubjectToGroup);
            addSubjectToGroup.Show();
        }
    }

    public class SubjectToGroupViewModelItem
    {
        public int Id { get; }
        public string Group { get; set; }
        public string Subject { get; set; }

        public SubjectToGroupViewModelItem(int id, string group, string subject)
        {
            Id = id;
            Group = group;
            Subject = subject;
        }
    }
}
