using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Log.Forms.Marks
{
    public partial class MarkCommentForm : Form
    {
        public MarkCommentForm()
        {
            InitializeComponent();
        }

        public MarkCommentForm(int mark_id)
        {
            InitializeComponent();
            MarkId = mark_id;
            markscommentsBindingSource.DataSource = LogEntities.marks_comments.ToList().Where(mc => mc.MarkId == mark_id).ToList();
        }

        public int MarkId { get; }

        private LogEntities LogEntities = LogEntities.GetInstance();

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if(LogEntities != null) LogEntities.SaveChanges();
        }

        private void MarkCommentForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            LogEntities.SaveChanges();
        }

        private void добавитьКомментарийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            marks_comments marks_Comment = new marks_comments();
            marks_Comment.MarkId = MarkId;
            marks_Comment.CommentText = "";
            LogEntities.marks_comments.Add(marks_Comment);
            LogEntities.SaveChanges();
            markscommentsBindingSource.DataSource = LogEntities.marks_comments.ToList().Where(mc => mc.MarkId == MarkId).ToList();
        }

        private void удалитьКомментарийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var response = MessageBox.Show("Удалить?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (response == DialogResult.Yes)
            {
                int RowIndex = markCommentGridView.SelectedCells[0].RowIndex;
                LogEntities.marks_comments.Remove(LogEntities.marks_comments.Find(markCommentGridView.Rows[RowIndex].Cells[0].Value));
                LogEntities.SaveChanges();
                markscommentsBindingSource.DataSource = LogEntities.marks_comments.ToList().Where(mc => mc.MarkId == MarkId).ToList();
            }
        }
    }
}
