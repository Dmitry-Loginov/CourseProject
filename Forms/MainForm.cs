using Log.Forms;
using Log.Forms.Directories;
using Log.Forms.Marks;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Log
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            CheckAndCreatePlannedBackup();
        }

        EditMarkForm EditMarkForm { get; set; }
        private void Button6_Click(object sender, EventArgs e)
        {
            if (EditMarkForm == null || EditMarkForm.IsDisposed)
                EditMarkForm = new EditMarkForm();
            EditMarkForm.Show();
            EditMarkForm.Select();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            LogEntities.DeleteInstance();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SubjectsForm subjectsForm = new SubjectsForm();
            subjectsForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StudentsForm studentsForm = new StudentsForm();
            studentsForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GroupsForm groupsForm = new GroupsForm();
            groupsForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SubjectToGroupForm subjectToGroupForm = new SubjectToGroupForm();
            subjectToGroupForm.Show();
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("Help.html");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            TeachersForm teachersForm = new TeachersForm();
            teachersForm.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SubjectToTeacherForm subjectToTeacherForm = new SubjectToTeacherForm();
            subjectToTeacherForm.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            SqlQueryForm sqlQueryForm = new SqlQueryForm();
            sqlQueryForm.Show();
        }

        private void создатьРезервнуюКопиюБДToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateBackup();
        }

        public void CreateBackup(bool is_planning = false)
        {
            string backupDirectory = null;
            try
            {

                // Получение пути к текущему исполняемому файлу
                string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;

                // Путь к файлам базы данных (относительно корневого пути приложения)
                string mdfFilePath = Path.Combine(baseDirectory, @"DataBase\Log.mdf");
                string ldfFilePath = Path.Combine(baseDirectory, @"DataBase\Log_log.ldf");

                // Путь к папке для бэкапов (относительно корневого пути приложения)
                string backupFolder = Path.Combine(baseDirectory, @"DBBackup");

                // Создание папки с датой и временем
                string timestamp = DateTime.Now.ToString("yyyyMMdd_HHmmss");

                backupDirectory = Path.Combine(backupFolder, timestamp);
                
                if (is_planning)
                    backupDirectory = backupDirectory + "_planning";

                // Проверка, существует ли директория, и её создание
                if (!Directory.Exists(backupDirectory))
                {
                    Directory.CreateDirectory(backupDirectory);
                }

                // Полные пути для копирования файлов
                string mdfBackupPath = Path.Combine(backupDirectory, "Log.mdf");
                string ldfBackupPath = Path.Combine(backupDirectory, "Log_log.ldf");

                // Копирование файлов
                File.Copy(mdfFilePath, mdfBackupPath, true);  // Копируем файл .mdf
                File.Copy(ldfFilePath, ldfBackupPath, true);  // Копируем файл .ldf

                if(!is_planning)
                    MessageBox.Show($"Резервная копия создана в папке: {backupDirectory}", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LogEntities.GetInstance();
            }
            catch (Exception ex)
            {

                if (backupDirectory != null && Directory.Exists(backupDirectory))
                {
                    Directory.Delete(backupDirectory, true);  // Удаляет папку и её содержимое
                }


                MessageBox.Show($"Ошибка при создании резервной копии: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void CheckAndCreatePlannedBackup()
        {
            try
            {
                // Получение пути к папке для бэкапов (относительно корневого пути приложения)
                string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
                string backupFolder = Path.Combine(baseDirectory, @"DBBackup");

                // Проверка существования папки для бэкапов
                if (!Directory.Exists(backupFolder))
                {
                    Directory.CreateDirectory(backupFolder);
                }

                // Получение всех папок бэкапов с пометкой "_planning"
                var planningBackups = Directory.GetDirectories(backupFolder, "*_planning");

                DateTime? lastPlanningBackupDate = null;

                // Проверка каждой папки и извлечение даты из имени
                foreach (var folder in planningBackups)
                {
                    // Имя папки содержит дату и пометку "_planning"
                    string folderName = Path.GetFileName(folder);
                    string dateString = folderName.Substring(0, 15); // yyyyMMdd_HHmmss

                    if (DateTime.TryParseExact(dateString, "yyyyMMdd_HHmmss", null, System.Globalization.DateTimeStyles.None, out DateTime backupDate))
                    {
                        // Определение самой новой даты бэкапа
                        if (!lastPlanningBackupDate.HasValue || backupDate > lastPlanningBackupDate.Value)
                        {
                            lastPlanningBackupDate = backupDate;
                        }
                    }
                }

                // Если бэкап не найден или прошла неделя с последнего бэкапа
                if (!lastPlanningBackupDate.HasValue || (DateTime.Now - lastPlanningBackupDate.Value).TotalDays > 7)
                {
                    // Вызов метода создания бэкапа с параметром true (плановый бэкап)
                    CreateBackup(true);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при проверке плановых бэкапов: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void восстановитьБдИзКопииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RestoreDatabase();
        }

        public void RestoreDatabase()
        {
            try
            {
                LogEntities.DeleteInstance();
                // Вопрос о восстановлении БД
                var restoreResult = MessageBox.Show("Хотите восстановить базу данных из резервной копии?",
                                                    "Восстановление базы данных",
                                                    MessageBoxButtons.YesNo,
                                                    MessageBoxIcon.Question);
                if (restoreResult == DialogResult.No)
                    return;  // Если пользователь отказался, выход

                // Вопрос о выборе: последняя копия или выбрать самому
                var chooseMethodResult = MessageBox.Show("Восстановить последнюю копию?",
                                                         "Восстановление базы данных",
                                                         MessageBoxButtons.YesNoCancel,
                                                         MessageBoxIcon.Question);

                // Получение пути к текущему исполняемому файлу
                string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;

                // Путь к файлам базы данных (основные файлы, которые будут заменяться)
                string mdfFilePath = Path.Combine(baseDirectory, @"DataBase\Log.mdf");
                string ldfFilePath = Path.Combine(baseDirectory, @"DataBase\Log_log.ldf");

                // Путь к папке для бэкапов
                string backupFolder = Path.Combine(baseDirectory, @"DBBackup");

                if (chooseMethodResult == DialogResult.Yes)
                {
                    // Восстановить из самой последней копии
                    var backupDirectories = Directory.GetDirectories(backupFolder);

                    if (backupDirectories.Length == 0)
                    {
                        MessageBox.Show("Нет доступных резервных копий для восстановления.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Найти самую последнюю по дате копию
                    string latestBackup = backupDirectories.OrderByDescending(d => Directory.GetCreationTime(d)).First();

                    // Полные пути к резервным файлам
                    string mdfBackupPath = Path.Combine(latestBackup, "Log.mdf");
                    string ldfBackupPath = Path.Combine(latestBackup, "Log_log.ldf");

                    // Восстановление
                    File.Copy(mdfBackupPath, mdfFilePath, true);
                    File.Copy(ldfBackupPath, ldfFilePath, true);

                    MessageBox.Show("База данных успешно восстановлена. Приложение будет перезапущено.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Application.Restart();
                }
                else if (chooseMethodResult == DialogResult.No)
                {
                    // Позволить пользователю самому выбрать файлы
                    using (OpenFileDialog openFileDialog = new OpenFileDialog())
                    {
                        openFileDialog.Title = "Выберите файлы резервной копии (Log.mdf и Log_log.ldf)";
                        openFileDialog.Filter = "Database files (*.mdf, *.ldf)|*.mdf;*.ldf";
                        openFileDialog.Multiselect = true;

                        if (openFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            // Проверка, что выбраны оба файла
                            var selectedFiles = openFileDialog.FileNames;

                            if (selectedFiles.Length != 2)
                            {
                                MessageBox.Show("Пожалуйста, выберите оба файла: Log.mdf и Log_log.ldf.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }

                            // Проверка правильности выбранных файлов
                            string mdfBackupPath = selectedFiles.FirstOrDefault(f => Path.GetExtension(f).Equals(".mdf", StringComparison.OrdinalIgnoreCase));
                            string ldfBackupPath = selectedFiles.FirstOrDefault(f => Path.GetExtension(f).Equals(".ldf", StringComparison.OrdinalIgnoreCase));

                            if (mdfBackupPath == null || ldfBackupPath == null)
                            {
                                MessageBox.Show("Пожалуйста, выберите корректные файлы с расширениями .mdf и .ldf.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }

                            // Восстановление
                            File.Copy(mdfBackupPath, mdfFilePath, true);
                            File.Copy(ldfBackupPath, ldfFilePath, true);

                            MessageBox.Show("База данных успешно восстановлена. Приложение будет перезапущено.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Application.Restart();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при восстановлении базы данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            TeacherWithSubAvgForm teacherWithSubAvgForm = new TeacherWithSubAvgForm();
            teacherWithSubAvgForm.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            StudentsByGroupForm studentsByGroupForm = new StudentsByGroupForm();
            studentsByGroupForm.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            TopStudentByGroupForm topStudentByGroupForm = new TopStudentByGroupForm();
            topStudentByGroupForm.Show();
        }
    }
    public delegate void FillDataGridView();
    public delegate void FillStudentsGrid();
    public delegate void FillSubjectToGroupGrid();
    public delegate void FillSubjectToTeacherGrid();
}
