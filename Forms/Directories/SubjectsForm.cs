using System.Linq;
using System.Windows.Forms;

namespace Log
{
    public partial class SubjectsForm : Form
    {
        private LogEntities LogEntities = LogEntities.GetInstance();
        public SubjectsForm()
        {
            InitializeComponent();
            subjectBindingSource.DataSource = LogEntities.subjects.ToList();
        }

        private void SubjectsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            LogEntities.SaveChanges();
        }

        private void addMenu_Click(object sender, System.EventArgs e)
        {
            LogEntities.subjects.Add(new subject());
            LogEntities.SaveChanges();
            subjectBindingSource.DataSource = LogEntities.subjects.ToList();
        }

        private void delMenu_Click(object sender, System.EventArgs e)
        {
            var response = MessageBox.Show("Удалить?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(response == DialogResult.Yes)
            {
                int RowIndex = subjectDataGridView.SelectedCells[0].RowIndex;
                LogEntities.subjects.Remove(LogEntities.subjects.Find(subjectDataGridView.Rows[RowIndex].Cells[0].Value));
                LogEntities.SaveChanges();
                subjectBindingSource.DataSource = LogEntities.subjects.ToList();
            }
        }
    }
}
