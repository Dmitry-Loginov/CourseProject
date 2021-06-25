using System;
using System.Linq;
using System.Windows.Forms;

namespace Log
{
    public partial class StudentsForm : Form
    {
        LogEntities LogEntities;
        FillStudentsGrid FillStudentsGridDelegate { get; set; }
        public StudentsForm()
        {
            InitializeComponent();
            LogEntities = LogEntities.GetInstance();
            FillStudentsGridDelegate += FillStudents;
        }

        void FillStudents()
        {
            studentBindingSource.DataSource = LogEntities.students.ToList();
            groupBindingSource.DataSource = LogEntities.groups.ToList();
        }

        private void StudentsForm_Load(object sender, EventArgs e)
        {
            FillStudentsGridDelegate();
        }

        private void StudentsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            LogEntities.SaveChanges();
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddStudentForm addStudentForm = new AddStudentForm(FillStudentsGridDelegate);
            addStudentForm.Show();
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Удалить?", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                var student = LogEntities.students.Find(studentDataGridView.CurrentRow.Cells[0].Value);
                LogEntities.students.Remove(student);
                LogEntities.SaveChanges();
                studentBindingSource.DataSource = LogEntities.students.ToList();
            }
        }
    }
}
