using System;
using System.Drawing;
using System.Windows.Forms;

public class DataGridViewPrinter
{
    private DataGridView dataGridView;
    private int rowIndex = 0;
    private float currentY = 0;

    public DataGridViewPrinter(DataGridView dgv)
    {
        dataGridView = dgv;
    }

    public bool DrawDataGridView(Graphics graphics, Rectangle marginBounds)
    {
        Font headerFont = new Font(dataGridView.Font, FontStyle.Bold);
        Brush headerBrush = Brushes.Black;
        Brush cellBrush = Brushes.Black;

        float rowHeight = dataGridView.RowTemplate.Height;
        float headerHeight = 0;

        // Печать заголовков столбцов и определение максимальной высоты
        foreach (DataGridViewColumn column in dataGridView.Columns)
        {
            // Определяем высоту заголовка, чтобы учитывать перенос
            SizeF headerSize = graphics.MeasureString(column.HeaderText.Replace(" ", "\n"), headerFont);
            headerHeight = Math.Max(headerHeight, headerSize.Height);
        }

        // Печать заголовков
        for (int i = 0; i < dataGridView.Columns.Count; i++)
        {
            RectangleF headerRect = new RectangleF(marginBounds.Left + i * dataGridView.Columns[i].Width, marginBounds.Top + currentY, dataGridView.Columns[i].Width, headerHeight);
            graphics.DrawString(dataGridView.Columns[i].HeaderText.Replace(" ", "\n"), headerFont, headerBrush, headerRect);
        }

        currentY += headerHeight;

        // Рисуем линию под заголовками
        graphics.DrawLine(Pens.Black, marginBounds.Left, marginBounds.Top + currentY, marginBounds.Right, marginBounds.Top + currentY);
        currentY += 5; // небольшое смещение вниз

        // Печать строк
        while (rowIndex < dataGridView.Rows.Count)
        {
            for (int i = 0; i < dataGridView.Columns.Count; i++)
            {
                RectangleF cellRect = new RectangleF(marginBounds.Left + i * dataGridView.Columns[i].Width, marginBounds.Top + currentY, dataGridView.Columns[i].Width, rowHeight);
                string cellValue = dataGridView.Rows[rowIndex].Cells[i].FormattedValue.ToString();
                graphics.DrawString(cellValue, dataGridView.Font, cellBrush, cellRect);
            }

            currentY += rowHeight;

            if (currentY > marginBounds.Bottom) // Проверка, вышли ли за пределы страницы
            {
                return true; // Нужно продолжить на следующей странице
            }

            rowIndex++;
        }

        return false; // Печать завершена
    }
}
