using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Log.Forms.Directories
{
    public partial class TeachersForm : Form
    {
        private LogEntities LogEntities = LogEntities.GetInstance();
        public TeachersForm()
        {
            InitializeComponent();
            teacherBindingSource.DataSource = LogEntities.teachers.ToList();
        }

        private void TeachersForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            LogEntities.SaveChanges();
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            teacher teacher = new teacher();
            teacher.Fio = "";
            LogEntities.teachers.Add(teacher);
            LogEntities.SaveChanges();
            teacherBindingSource.DataSource = LogEntities.teachers.ToList();
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var response = MessageBox.Show("Удалить?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (response == DialogResult.Yes)
            {
                int RowIndex = teacherGridView.SelectedCells[0].RowIndex;
                LogEntities.subjects.Remove(LogEntities.subjects.Find(teacherGridView.Rows[RowIndex].Cells[0].Value));
                LogEntities.SaveChanges();
                teacherBindingSource.DataSource = LogEntities.teachers.ToList();
            }
        }
    }
}
