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

}
