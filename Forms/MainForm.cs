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

        EditMarkForm editMarkForm;
        private void Button6_Click(object sender, EventArgs e)
        {
            if (editMarkForm == null || editMarkForm.IsDisposed)
                editMarkForm = new EditMarkForm();
            editMarkForm.Show();
            editMarkForm.Select();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            LogEntities.DeleteInstance();
        }

        SubjectsForm subjectsForm;

        private void button1_Click(object sender, EventArgs e)
        {
            if (subjectsForm == null || subjectsForm.IsDisposed)
                subjectsForm = new SubjectsForm();
            subjectsForm.Show();
            subjectsForm.Select();
        }

        StudentsForm studentsForm;

        private void button2_Click(object sender, EventArgs e)
        {
           if (studentsForm == null || studentsForm.IsDisposed)
                studentsForm = new StudentsForm();
            studentsForm.Show();
            studentsForm.Select();
        }

        GroupsForm groupsForm;

        private void button3_Click(object sender, EventArgs e)
        {
            if (groupsForm == null || groupsForm.IsDisposed)
                groupsForm = new GroupsForm();
            groupsForm.Show();
            groupsForm.Select();
        }

        SubjectToGroupForm subjectToGroupForm;

        private void button4_Click(object sender, EventArgs e)
        {
            if (subjectToGroupForm == null || subjectToGroupForm.IsDisposed)
                subjectToGroupForm = new SubjectToGroupForm();
            subjectToGroupForm.Show();
            subjectToGroupForm.Select();
        }
    }
    public delegate void FillDataGridView();
    public delegate void FillStudentsGrid();
    public delegate void FillSubjectToGroupGrid();
}
