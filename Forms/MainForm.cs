using System;
using System.Windows.Forms;

namespace Log
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        EditMarkForm EditMarkForm { get; set; }
        private void Button6_Click(object sender, EventArgs e)
        {
            if (EditMarkForm == null || EditMarkForm.IsDisposed)
                EditMarkForm = new EditMarkForm();
            EditMarkForm.Show();
            EditMarkForm.Select();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ViewForm viewForm = new ViewForm();
            viewForm.Show();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            LogEntities.DeleteInstance();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SubjectsForm subjectsForm = new SubjectsForm();
            subjectsForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StudentsForm studentsForm = new StudentsForm();
            studentsForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GroupsForm groupsForm = new GroupsForm();
            groupsForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SubjectToGroupForm subjectToGroupForm = new SubjectToGroupForm();
            subjectToGroupForm.Show();
        }
    }
    public delegate void FillDataGridView();
    public delegate void FillStudentsGrid();
    public delegate void FillSubjectToGroupGrid();

}
