using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        public SubjectToGroupForm()
        {
            InitializeComponent();
            LogEntities = LogEntities.GetInstance();
            subjectBindingSource.DataSource = LogEntities.subjects.ToList();
            subjects_to_groupsBindingSource.DataSource = LogEntities.subjects_to_groups.ToList();
            
        }

        private void subjects_to_groupsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.subjects_to_groupsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.logDataSet);

        }

        private void SubjectToGroupForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "logDataSet.subjects_to_groups". При необходимости она может быть перемещена или удалена.
            this.subjects_to_groupsTableAdapter.Fill(this.logDataSet.subjects_to_groups);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "logDataSet.subjects_to_groups". При необходимости она может быть перемещена или удалена.
            this.subjects_to_groupsTableAdapter.Fill(this.logDataSet.subjects_to_groups);

        }

        private void subjects_to_groupsBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.subjects_to_groupsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.logDataSet);

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
                var subject_to_group = LogEntities.subjects_to_groups.Find(subjects_to_groupsDataGridView.CurrentRow.Cells[0].Value);
                LogEntities.subjects_to_groups.Remove(subject_to_group);
                LogEntities.SaveChanges();
                subjectBindingSource.DataSource = LogEntities.subjects_to_groups.ToList();
            }
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            subjects_to_groups subjects_To_Group = new subjects_to_groups();

            LogEntities.subjects_to_groups.Add(subjects_To_Group);
            LogEntities.SaveChanges();
            subjects_to_groupsBindingSource.DataSource = LogEntities.subjects_to_groups.ToList();
        }
    }
}
