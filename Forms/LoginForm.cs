using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Log.Forms
{
    public partial class LoginForm : Form
    {
        LogEntities LogEntities = LogEntities.GetInstance();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = loginTextBox.Text;
            string password = passwordTextBox.Text;
            string roleName;
            new MainForm(this).CreateBackup(true);
            if (IsValidUser(username, password, out roleName))
            {
                LogEntities.Role = roleName.Trim();
                MainForm mainForm = new MainForm(this);
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Неудача! Неверное имя пользователя или пароль.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private bool IsValidUser(string username, string password, out string roleName)
        {
                // Ищем пользователя и его роль
                var user = LogEntities.users.FirstOrDefault(u => u.UserName == username && u.Password == password);

                if (user != null)
                {
                    roleName = user.Role.RoleName;
                    return true; // Пользователь найден
                }
                else
                {
                    roleName = null; // Если пользователь не найден, устанавливаем roleName в null
                    return false; // Пользователь не найден
                }
        }
    }
}
