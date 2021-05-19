using System;
using System.Linq;
using System.Windows.Forms;

namespace Log
{
    public partial class ViewMarkForm : Form
    {
        public ViewMarkForm()
        {
            InitializeComponent();
        }

        LogEntities Log;

        private void ViewMarkForm_Load(object sender, EventArgs e)
        {
            FillData(ref Log);
            //Задаем размер по заполнению
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        void FillData(ref LogEntities log)
        {
            log?.Dispose();
            log = new LogEntities();
            markBindingSource.DataSource = log.marks.ToList();
            studetnBindingSource.DataSource = log.studetns.ToList();
            subjectBindingSource.DataSource = log.subjects.ToList();
        }

        private void ViewMarkForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Log.SaveChanges();
            Log.Dispose();
        }

        private void deleteButton(object sender, EventArgs e)
        {
            int keySelectedIndex = Convert.ToInt32(dataGridView.SelectedRows[0].Cells[0].Value.ToString());
            mark mark = Log.marks.Find(keySelectedIndex);
            Log.marks.Remove(mark);
            int delIndex = dataGridView.SelectedRows[0].Index;
            dataGridView.Rows.RemoveAt(delIndex);
            Log.SaveChanges();
        }

        private void addButton(object sender, EventArgs e)
        {
            mark mark = new mark();
            Log.marks.Add(mark);
            Log.SaveChanges();
            dataGridView.DataSource = null;
            dataGridView.Refresh();
            FillData(ref Log);
            dataGridView.DataSource = markBindingSource;
            dataGridView.Refresh();
        }
    }
}
