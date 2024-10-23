using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using OfficeOpenXml;
using SaveFileDialog = System.Windows.Forms.SaveFileDialog;

namespace Log.Forms.Marks
{
    public partial class TopStudentByGroupForm : Form
    {
        public LogEntities LogEntities = LogEntities.GetInstance();
        private PrintDocument printDocument = new PrintDocument(); // Добавляем объявление printDocument
        private DataGridViewPrinter dataGridViewPrinter;
        public TopStudentByGroupForm()
        {
            InitializeComponent();
            bindingSource1.DataSource = LogEntities.vw_TopStudentsByGroup.ToList();

            using (var connection = new SqlConnection(LogEntities.Database.Connection.ConnectionString))
            {
                connection.Open();
                using (var command = new SqlCommand("select * from vw_TopStudentsByGroup;", connection))
                {
                        using (var adapter = new SqlDataAdapter(command))
                        {
                            DataTable resultTable = new DataTable();
                            adapter.Fill(resultTable);
                            dataGridView1.DataSource = resultTable;  // Отображаем результат в DataGridView
                        dataGridView1.Columns[0].HeaderText = "Группа";
                        dataGridView1.Columns[1].HeaderText = "Студент";
                        dataGridView1.Columns[2].HeaderText = "Средний балл";
                        }
                }
            }

                   // dataGridView1.DataSource = bindingSource1;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            printDocument.PrintPage += new PrintPageEventHandler(PrintDocument_PrintPage);
        }

        private void репортToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Открываем диалог для выбора действия
            var result = MessageBox.Show("Вы хотите экспортировать отчет в PDF или Excel? Да - PDF", "Экспорт отчета", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (result == DialogResult.Yes) // Если выбрано PDF
            {
                GeneratePdfReport();
            }
            else if (result == DialogResult.No) // Если выбрано Excel
            {
                ExportToExcel();
            }
        }

        private void GeneratePdfReport()
        {
            try
            {
                // Настройка диалогового окна для выбора места сохранения файла
                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Filter = "PDF files (*.pdf)|*.pdf",
                    Title = "Сохранить отчет как PDF"
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Используем iTextSharp для создания PDF
                    using (FileStream stream = new FileStream(saveFileDialog.FileName, FileMode.Create))
                    {
                        Document pdfDoc = new Document(PageSize.A4, 25, 25, 30, 30);
                        PdfWriter.GetInstance(pdfDoc, stream);
                        pdfDoc.Open();

                        // Загрузка шрифта, который поддерживает кириллицу
                        string fontPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "arial.ttf");
                        BaseFont baseFont = BaseFont.CreateFont(fontPath, BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
                        iTextSharp.text.Font font = new iTextSharp.text.Font(baseFont, 12);

                        // Создание таблицы с количеством колонок, равным количеству колонок в DataGridView
                        PdfPTable table = new PdfPTable(dataGridView1.Columns.Count);
                        table.WidthPercentage = 100;

                        // Добавление заголовков столбцов
                        foreach (DataGridViewColumn column in dataGridView1.Columns)
                        {
                            PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, font));
                            table.AddCell(cell);
                        }

                        // Добавление данных из DataGridView
                        foreach (DataGridViewRow row in dataGridView1.Rows)
                        {
                            if (row.IsNewRow) continue;

                            foreach (DataGridViewCell cell in row.Cells)
                            {
                                string cellText = cell.Value?.ToString() ?? string.Empty;
                                table.AddCell(new Phrase(cellText, font));
                            }
                        }

                        // Добавление таблицы в документ PDF
                        pdfDoc.Add(table);
                        pdfDoc.Close();
                    }

                    MessageBox.Show("Отчет успешно сохранен как PDF.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при создании PDF: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ExportToExcel()
        {
            try
            {
                // Настройка диалогового окна для выбора места сохранения файла
                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Filter = "Excel files (*.xlsx)|*.xlsx",
                    Title = "Сохранить отчет как Excel"
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
                    // Используем библиотеку EPPlus для работы с Excel
                    using (ExcelPackage excel = new ExcelPackage())
                    {
                        var workSheet = excel.Workbook.Worksheets.Add("Отчет");

                        // Заголовки столбцов
                        for (int i = 0; i < dataGridView1.Columns.Count; i++)
                        {
                            workSheet.Cells[1, i + 1].Value = dataGridView1.Columns[i].HeaderText;
                        }

                        // Данные из DataGridView
                        for (int i = 0; i < dataGridView1.Rows.Count; i++)
                        {
                            if (dataGridView1.Rows[i].IsNewRow) continue;

                            for (int j = 0; j < dataGridView1.Columns.Count; j++)
                            {
                                workSheet.Cells[i + 2, j + 1].Value = dataGridView1.Rows[i].Cells[j].Value?.ToString() ?? string.Empty;
                            }
                        }

                        // Сохранение Excel файла
                        FileInfo excelFile = new FileInfo(saveFileDialog.FileName);
                        excel.SaveAs(excelFile);
                    }

                    MessageBox.Show("Отчет успешно сохранен как Excel.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при создании Excel: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void печатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Создаём диалог для печати
            PrintDialog printDialog = new PrintDialog();

            printDialog.Document = printDocument;

            // Если пользователь нажал "ОК"
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                // Печать содержимого DataGridView
                PreparePrint();
                printDocument.Print();
            }
        }

        private void PreparePrint()
        {
            dataGridViewPrinter = new DataGridViewPrinter(dataGridView1);
        }

        // Событие печати
        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            bool more = dataGridViewPrinter.DrawDataGridView(e.Graphics, e.MarginBounds);
            if (more)
                e.HasMorePages = true;
        }
    }
}
