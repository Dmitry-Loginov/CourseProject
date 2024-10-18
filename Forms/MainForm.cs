using Log.Forms.Directories;
using System;
using System.Diagnostics;
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

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("Help.html");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            TeachersForm teachersForm = new TeachersForm();
            teachersForm.Show();
        }
    }
    public delegate void FillDataGridView();
    public delegate void FillStudentsGrid();
    public delegate void FillSubjectToGroupGrid();
}
