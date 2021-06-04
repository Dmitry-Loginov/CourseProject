using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Log
{
    public partial class ViewMarkForm : Form
    {
        public ViewMarkForm()
        {
            InitializeComponent();
            log = LogEntities.GetInstance();
            markBindingSource.DataSource = log.marks.ToList();
            studentBindingSource.DataSource = log.students.ToList();
            subjectBindingSource.DataSource = log.subjects.ToList();
            typeMarkBindingSource.DataSource = log.typeMarks.ToList();

            //Задаем размер по заполнению
            raw.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            bigList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        LogEntities log;
    }
}
