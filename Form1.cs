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

        private void button6_Click(object sender, EventArgs e)
        {
            ViewMarkForm view = new ViewMarkForm();
            view.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
    public delegate void FillDataGridView(ref LogEntities log);

}
