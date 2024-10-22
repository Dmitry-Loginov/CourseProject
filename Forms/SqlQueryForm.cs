using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Log.Forms
{
    public partial class SqlQueryForm : Form
    {
        public SqlQueryForm()
        {
            InitializeComponent();
            Log = LogEntities.GetInstance();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        public LogEntities Log { get; set; }

        private void button1_Click(object sender, EventArgs e)
        {
            string userQuery = richTextBox1.Text;  // Получаем SQL-запрос от пользователя

            try
            {
                using (var connection = new SqlConnection(Log.Database.Connection.ConnectionString))
                {
                    connection.Open();
                    using (var command = new SqlCommand(userQuery, connection))
                    {
                        // Определяем тип запроса
                        if (userQuery.TrimStart().StartsWith("SELECT", StringComparison.OrdinalIgnoreCase))
                        {
                            // Если это SELECT запрос
                            using (var adapter = new SqlDataAdapter(command))
                            {
                                DataTable resultTable = new DataTable();
                                adapter.Fill(resultTable);
                                dataGridView1.DataSource = resultTable;  // Отображаем результат в DataGridView
                            }
                        }
                        else
                        {
                            dataGridView1.DataSource = null;
                            // Выполняем запрос для всех остальных типов (INSERT, UPDATE, DELETE и т.д.)
                            int rowsAffected = command.ExecuteNonQuery();

                            // Определяем тип команды
                            if (userQuery.TrimStart().StartsWith("INSERT", StringComparison.OrdinalIgnoreCase))
                            {
                                MessageBox.Show($"Обработано строк: {rowsAffected}");
                            }
                            else if (userQuery.TrimStart().StartsWith("UPDATE", StringComparison.OrdinalIgnoreCase))
                            {
                                MessageBox.Show($"Обновлено строк: {rowsAffected}");
                            }
                            else if (userQuery.TrimStart().StartsWith("DELETE", StringComparison.OrdinalIgnoreCase))
                            {
                                MessageBox.Show($"Удалено строк: {rowsAffected}");
                            }
                            else
                            {
                                // Для DDL запросов
                                MessageBox.Show("Команда завершена успешно!");
                            }
                        }
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show($"Ошибка выполнения SQL-запроса: {sqlEx.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Общая ошибка выполнения запроса: {ex.Message}");
            }
        }
    }
}
