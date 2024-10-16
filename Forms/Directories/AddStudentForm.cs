using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace Log
{
    public partial class AddStudentForm : Form
    {
        private LogEntities LogEntities = LogEntities.GetInstance();
        private FillStudentsGrid fillStudents;
        public AddStudentForm(FillStudentsGrid fillStudentsGridDelegate)
        {
            InitializeComponent();
            student student = new student();
            groupBindingSource.DataSource = LogEntities.groups.ToList();
            studentBindingSource.DataSource = student;
            fillStudents = fillStudentsGridDelegate;
        }


        private void button1_Click(object sender, EventArgs e)
        {

            student student = new student()
            {
                PassportId = passportIdTextBox.Text,
                Fio = fioTextBox.Text,
                Birthday = birthdayDateTimePicker.Value,
                GroupId = groupIdComboBox.SelectedValue.ToString(),
                Phone = phoneTextBox.Text
            };

            string sql = "select * from students where PassportId = @PASSPORT";
            SqlParameter sqlParameter = new SqlParameter("@PASSPORT", student.PassportId);

            List<student> students = LogEntities.students.SqlQuery(sql, sqlParameter)?.ToList();
            if(students.Count == 0)
            {
                LogEntities.students.Add(student);
                LogEntities.SaveChanges();
                LogEntities = LogEntities.GetInstance();
                fillStudents();
            }
            else
            {
                MessageBox.Show("Пользователь с таким паспортом уже существует!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
