using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Log.Forms.Directories
{
    public partial class SubjectToTeacherForm : Form
    {
        LogEntities LogEntities;
        FillSubjectToTeacherGrid FillSubjectToTeacher { get; set; }
        public SubjectToTeacherForm()
        {
            InitializeComponent();
            LogEntities = LogEntities.GetInstance();
            FillSubjectToTeacher += FillGrid;
            FillSubjectToTeacher();
        }

        void FillGrid()
        {
            List<SubjectToTeacherViewModelItem> targetItems = new List<SubjectToTeacherViewModelItem>();
            var subject_teachers = LogEntities.subjects_to_teachers.ToList();
            for (int i = 0; i < subject_teachers.Count; i++)
            {
                SubjectToTeacherViewModelItem modelItem = new SubjectToTeacherViewModelItem(subject_teachers[i].Id, subject_teachers[i].teacher.Fio, subject_teachers[i].subject.SubjectName);
                targetItems.Add(modelItem);
            }
            subjectToTeacherGridView.DataSource = targetItems;
            subjectToTeacherGridView.Columns[0].Visible = false;
            subjectToTeacherGridView.Columns[1].HeaderText = "Преподаватель";
            subjectToTeacherGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            subjectToTeacherGridView.Columns[2].HeaderText = "Предмет";
            subjectToTeacherGridView.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddSubjectToTeacherForm subjectToTeacherForm = new AddSubjectToTeacherForm(FillSubjectToTeacher);
            subjectToTeacherForm.Show();
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var resultQuestion = MessageBox.Show("Удалить?", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resultQuestion == DialogResult.Yes)
            {
                int id = Convert.ToInt32(subjectToTeacherGridView.CurrentRow.Cells[0].Value);
                string sql = "delete from subjects_to_teachers where Id = " + id.ToString() + ";";
                LogEntities.Database.ExecuteSqlCommand(sql);
                LogEntities.SaveChanges();
                FillSubjectToTeacher();
            }
        }
    }

    public class SubjectToTeacherViewModelItem
    {
        public int Id { get; }
        public string Teacher { get; set; }
        public string Subject { get; set; }

        public SubjectToTeacherViewModelItem(int id, string teacher, string subject)
        {
            Id = id;
            Teacher = teacher;
            Subject = subject;
        }
    }
}
