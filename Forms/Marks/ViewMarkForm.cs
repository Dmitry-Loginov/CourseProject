using System.Linq;
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

        private readonly LogEntities log;
    }
}
