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

        private void Button6_Click(object sender, EventArgs e)
        {
            EditMarkForm view = new EditMarkForm();
            view.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
    public delegate void FillDataGridView();

    class MarkBuilder
    {
        mark mark;
        public MarkBuilder()
        {
            this.mark = new mark();
        }

        public MarkBuilder SetStudent(student student) 
        {
            mark.studetn = student;
            return this;
        }

        public MarkBuilder SetSubject(subject subject)
        {
            mark.subject = subject;
            return this;
        }

        public MarkBuilder SetTypeMark(typeMark typeMark)
        {
            mark.typeMark = typeMark;
            return this;
        }

        public MarkBuilder SetMonth(int month)
        {
            mark.Month = month;
            return this;
        }

        public MarkBuilder SetValue(string value)
        {
            mark.Value = value;
            return this;
        }

        public mark GetMark()
        {
            return mark;
        }

    }

}
