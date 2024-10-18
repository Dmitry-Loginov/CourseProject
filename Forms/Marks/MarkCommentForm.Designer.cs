
namespace Log.Forms.Marks
{
    partial class MarkCommentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MarkCommentForm));
            this.markCommentGridView = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.добавитьКомментарийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьКомментарийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.markIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentTextDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.markscommentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.markCommentGridView)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.markscommentsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // markCommentGridView
            // 
            this.markCommentGridView.AllowUserToAddRows = false;
            this.markCommentGridView.AllowUserToDeleteRows = false;
            this.markCommentGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.markCommentGridView.AutoGenerateColumns = false;
            this.markCommentGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.markCommentGridView.BackgroundColor = System.Drawing.Color.White;
            this.markCommentGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.markCommentGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.markIdDataGridViewTextBoxColumn,
            this.commentTextDataGridViewTextBoxColumn});
            this.markCommentGridView.DataSource = this.markscommentsBindingSource;
            this.markCommentGridView.Location = new System.Drawing.Point(0, 0);
            this.markCommentGridView.Name = "markCommentGridView";
            this.markCommentGridView.Size = new System.Drawing.Size(449, 450);
            this.markCommentGridView.TabIndex = 0;
            this.markCommentGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьКомментарийToolStripMenuItem,
            this.удалитьКомментарийToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(206, 48);
            // 
            // добавитьКомментарийToolStripMenuItem
            // 
            this.добавитьКомментарийToolStripMenuItem.Name = "добавитьКомментарийToolStripMenuItem";
            this.добавитьКомментарийToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.добавитьКомментарийToolStripMenuItem.Text = "Добавить комментарий";
            this.добавитьКомментарийToolStripMenuItem.Click += new System.EventHandler(this.добавитьКомментарийToolStripMenuItem_Click);
            // 
            // удалитьКомментарийToolStripMenuItem
            // 
            this.удалитьКомментарийToolStripMenuItem.Name = "удалитьКомментарийToolStripMenuItem";
            this.удалитьКомментарийToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.удалитьКомментарийToolStripMenuItem.Text = "Удалить комментарий";
            this.удалитьКомментарийToolStripMenuItem.Click += new System.EventHandler(this.удалитьКомментарийToolStripMenuItem_Click);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // markIdDataGridViewTextBoxColumn
            // 
            this.markIdDataGridViewTextBoxColumn.DataPropertyName = "MarkId";
            this.markIdDataGridViewTextBoxColumn.HeaderText = "MarkId";
            this.markIdDataGridViewTextBoxColumn.Name = "markIdDataGridViewTextBoxColumn";
            this.markIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // commentTextDataGridViewTextBoxColumn
            // 
            this.commentTextDataGridViewTextBoxColumn.DataPropertyName = "CommentText";
            this.commentTextDataGridViewTextBoxColumn.HeaderText = "Текст комментария";
            this.commentTextDataGridViewTextBoxColumn.Name = "commentTextDataGridViewTextBoxColumn";
            // 
            // markscommentsBindingSource
            // 
            this.markscommentsBindingSource.DataSource = typeof(Log.marks_comments);
            // 
            // MarkCommentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 450);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.markCommentGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MarkCommentForm";
            this.Text = "Комментарии к оценке";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MarkCommentForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.markCommentGridView)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.markscommentsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView markCommentGridView;
        private System.Windows.Forms.BindingSource markscommentsBindingSource;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem добавитьКомментарийToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьКомментарийToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn markIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentTextDataGridViewTextBoxColumn;
    }
}