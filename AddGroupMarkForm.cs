using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Log
{
    public partial class AddGroupMarkForm : Form
    {
        LogEntities log;
        DataGridView dataGridView;
        FillDataGridView fillGrid;
        BindingSource markBindingSource;
        
        public AddGroupMarkForm(ref LogEntities log)
        {
            InitializeComponent();
        }

        public AddGroupMarkForm(ref LogEntities log, ref DataGridView dataGridView, ref FillDataGridView fillGrid, ref BindingSource markBindingSource)
        {
            InitializeComponent();
            this.log = log;
            studentBindingSource.DataSource = log.students.ToList();
            subjectBindingSource.DataSource = log.subjects.ToList();
            typeMarkBindingSource.DataSource = log.typeMarks.ToList();
            this.dataGridView = dataGridView;
            this.fillGrid = fillGrid;
            this.markBindingSource = markBindingSource;
        }

        private void addButton_Click(object sender, System.EventArgs e)
        {
            List<mark> marks = new List<mark>();
            int count = Convert.ToInt32(countBox.SelectedItem.ToString());
            for (int i = 0; i < count; i++)
            {
                marks.Add(new mark());
                marks[i].studetn = (student)studetnComboBox.SelectedItem;
                marks[i].subject = (subject)subjectComboBox.SelectedItem;
                marks[i].typeMark = (typeMark)typeMarkComboBox.SelectedItem;
                marks[i].Month = Convert.ToInt32(monthListBox.SelectedItem.ToString());
                marks[i].Value = valueListBox.SelectedItem.ToString();
            }
            log.marks.AddRange(marks);
            log.SaveChanges();
            dataGridView.DataSource = null;
            dataGridView.Refresh();
            fillGrid(ref log);
            dataGridView.DataSource = markBindingSource;
            dataGridView.Refresh();
        }
    }
}
