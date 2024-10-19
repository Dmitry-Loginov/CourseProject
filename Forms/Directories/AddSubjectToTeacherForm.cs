using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Log.Forms.Directories
{
    public partial class AddSubjectToTeacherForm : Form
    {

        private LogEntities LogEntities = LogEntities.GetInstance();
        public AddSubjectToTeacherForm()
        {
            InitializeComponent();
        }

        public AddSubjectToTeacherForm(FillSubjectToTeacherGrid fillSubjectToTeacher)
        {
            InitializeComponent();
            subjects_to_teachers subjects_To_Teachers = new subjects_to_teachers();
            subjectToTeacherBindingSource.DataSource = subjects_To_Teachers;
            subjectBindingSource.DataSource = LogEntities.subjects.ToList();
            teacherBindingSource.DataSource = LogEntities.teachers.ToList();
            FillSubjectToTeacher = fillSubjectToTeacher;
        }

        public FillSubjectToTeacherGrid FillSubjectToTeacher { get; }

        private void add_Click(object sender, EventArgs e)
        {
            subjects_to_teachers st = new subjects_to_teachers()
            {
                TeacherId = Convert.ToInt32(teacherIdComboBox.SelectedValue),
                SubjectId = Convert.ToInt32(subjectIdListBox.SelectedValue)
            };

            subjects_to_teachers checkSubject = LogEntities.subjects_to_teachers.Where(s => s.TeacherId == st.TeacherId && s.SubjectId == st.SubjectId).FirstOrDefault();
            if (checkSubject != default)
            {
                MessageBox.Show("Такая связь уже существует!");
                return;
            }
            LogEntities.subjects_to_teachers.Add(st);
            LogEntities.SaveChanges();
            FillSubjectToTeacher();
        }
    }
}
