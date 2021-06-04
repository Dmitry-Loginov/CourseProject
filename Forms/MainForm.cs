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
            ViewMarkForm viewMarkForm = new ViewMarkForm();
            viewMarkForm.Show();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            LogEntities.DeleteInstance();
        }
    }
    public delegate void FillDataGridView();

}
