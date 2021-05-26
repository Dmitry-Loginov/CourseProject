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
            fillGrid = FillData;
        }

        LogEntities log;
        FillDataGridView fillGrid;

        private void ViewMarkForm_Load(object sender, EventArgs e)
        {
            fillGrid(ref log);
            //Задаем размер по заполнению
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        void FillData(ref LogEntities log)
        {
            log?.Dispose();
            log = new LogEntities();
            markBindingSource.DataSource = log.marks.ToList();
            studentBindingSource.DataSource = log.students.ToList();
            subjectBindingSource.DataSource = log.subjects.ToList();
            typeMarkBindingSource.DataSource = log.typeMarks.ToList();
        }

        private void ViewMarkForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            log.SaveChanges();
            log.Dispose();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            int keySelectedIndex = Convert.ToInt32(dataGridView.SelectedRows[0].Cells[0].Value.ToString());
            mark mark = log.marks.Find(keySelectedIndex);
            log.marks.Remove(mark);
            int delIndex = dataGridView.SelectedRows[0].Index;
            dataGridView.Rows.RemoveAt(delIndex);
            log.SaveChanges();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            mark mark = new mark();
            log.marks.Add(mark);
            log.SaveChanges();
            dataGridView.DataSource = null;
            dataGridView.Refresh();
            fillGrid(ref log);
            dataGridView.DataSource = markBindingSource;
            dataGridView.Refresh();
        }

        private void addGroupBtn_Click(object sender, EventArgs e)
        {
            AddGroupMarkForm addGroupMarkForm = new AddGroupMarkForm(ref log, ref dataGridView, ref fillGrid, ref markBindingSource);
            addGroupMarkForm.Show();
        }
    }
}
