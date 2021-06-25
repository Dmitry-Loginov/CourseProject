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
            subjectBindingSource.DataSource = LogEntities.subjects.ToList();
            subjects_to_groupsBindingSource.DataSource = LogEntities.subjects_to_groups.ToList();
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
}
