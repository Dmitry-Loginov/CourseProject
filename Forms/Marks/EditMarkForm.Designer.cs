
namespace Log
{
    partial class EditMarkForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditMarkForm));
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.subjectIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.subjectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teacherIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.teacherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TypeId = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.typeMarkBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.monthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CommentCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marks_comments = new System.Windows.Forms.DataGridViewButtonColumn();
            this.markBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.addGroupBtn = new System.Windows.Forms.Button();
            this.groupComboBox = new System.Windows.Forms.ComboBox();
            this.groupBindingSourceMenu = new System.Windows.Forms.BindingSource(this.components);
            this.groupCheckBox = new System.Windows.Forms.CheckBox();
            this.sortedBox = new System.Windows.Forms.GroupBox();
            this.update = new System.Windows.Forms.Button();
            this.averageLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.subjectCheckBox = new System.Windows.Forms.CheckBox();
            this.subjectComboBox1 = new System.Windows.Forms.ComboBox();
            this.subjectBindingSourceMenu = new System.Windows.Forms.BindingSource(this.components);
            this.groupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.subjectBindingGridView = new System.Windows.Forms.BindingSource(this.components);
            this.studentBindingGridView = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeMarkBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.markBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBindingSourceMenu)).BeginInit();
            this.sortedBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSourceMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Info;
            this.dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.studentIdDataGridViewTextBoxColumn,
            this.subjectIdDataGridViewTextBoxColumn,
            this.teacherIdDataGridViewTextBoxColumn,
            this.TypeId,
            this.monthDataGridViewTextBoxColumn,
            this.valueDataGridViewTextBoxColumn,
            this.CommentCount,
            this.marks_comments});
            this.dataGridView.DataSource = this.markBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Chocolate;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView.Location = new System.Drawing.Point(304, 15);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 35;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView.Size = new System.Drawing.Size(984, 560);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            this.dataGridView.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dataGridView_CellValidating);
            this.dataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellValueChanged);
            this.dataGridView.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridView_EditingControlShowing);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Id";
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            // 
            // studentIdDataGridViewTextBoxColumn
            // 
            this.studentIdDataGridViewTextBoxColumn.DataPropertyName = "StudentId";
            this.studentIdDataGridViewTextBoxColumn.DataSource = this.studentBindingSource;
            this.studentIdDataGridViewTextBoxColumn.DisplayMember = "Fio";
            this.studentIdDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.studentIdDataGridViewTextBoxColumn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.studentIdDataGridViewTextBoxColumn.HeaderText = "Учащийся";
            this.studentIdDataGridViewTextBoxColumn.Name = "studentIdDataGridViewTextBoxColumn";
            this.studentIdDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.studentIdDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.studentIdDataGridViewTextBoxColumn.ValueMember = "PassportId";
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataSource = typeof(Log.student);
            // 
            // subjectIdDataGridViewTextBoxColumn
            // 
            this.subjectIdDataGridViewTextBoxColumn.DataPropertyName = "SubjectId";
            this.subjectIdDataGridViewTextBoxColumn.DataSource = this.subjectBindingSource;
            this.subjectIdDataGridViewTextBoxColumn.DisplayMember = "SubjectName";
            this.subjectIdDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.subjectIdDataGridViewTextBoxColumn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.subjectIdDataGridViewTextBoxColumn.HeaderText = "Предмет";
            this.subjectIdDataGridViewTextBoxColumn.Name = "subjectIdDataGridViewTextBoxColumn";
            this.subjectIdDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.subjectIdDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.subjectIdDataGridViewTextBoxColumn.ValueMember = "Id";
            // 
            // subjectBindingSource
            // 
            this.subjectBindingSource.DataSource = typeof(Log.subject);
            // 
            // teacherIdDataGridViewTextBoxColumn
            // 
            this.teacherIdDataGridViewTextBoxColumn.DataPropertyName = "TeacherId";
            this.teacherIdDataGridViewTextBoxColumn.DataSource = this.teacherBindingSource;
            this.teacherIdDataGridViewTextBoxColumn.DisplayMember = "Fio";
            this.teacherIdDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.teacherIdDataGridViewTextBoxColumn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.teacherIdDataGridViewTextBoxColumn.HeaderText = "Учитель";
            this.teacherIdDataGridViewTextBoxColumn.Name = "teacherIdDataGridViewTextBoxColumn";
            this.teacherIdDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.teacherIdDataGridViewTextBoxColumn.ValueMember = "Id";
            // 
            // teacherBindingSource
            // 
            this.teacherBindingSource.DataSource = typeof(Log.teacher);
            // 
            // TypeId
            // 
            this.TypeId.DataPropertyName = "TypeId";
            this.TypeId.DataSource = this.typeMarkBindingSource;
            this.TypeId.DisplayMember = "Type";
            this.TypeId.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.TypeId.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.TypeId.HeaderText = "Тип";
            this.TypeId.Name = "TypeId";
            this.TypeId.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TypeId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.TypeId.ValueMember = "Id";
            // 
            // typeMarkBindingSource
            // 
            this.typeMarkBindingSource.DataSource = typeof(Log.typeMark);
            // 
            // monthDataGridViewTextBoxColumn
            // 
            this.monthDataGridViewTextBoxColumn.DataPropertyName = "Month";
            this.monthDataGridViewTextBoxColumn.HeaderText = "Месяц";
            this.monthDataGridViewTextBoxColumn.MaxInputLength = 2;
            this.monthDataGridViewTextBoxColumn.Name = "monthDataGridViewTextBoxColumn";
            // 
            // valueDataGridViewTextBoxColumn
            // 
            this.valueDataGridViewTextBoxColumn.DataPropertyName = "Value";
            this.valueDataGridViewTextBoxColumn.HeaderText = "Значение";
            this.valueDataGridViewTextBoxColumn.MaxInputLength = 2;
            this.valueDataGridViewTextBoxColumn.Name = "valueDataGridViewTextBoxColumn";
            // 
            // CommentCount
            // 
            this.CommentCount.DataPropertyName = "CommentCount";
            this.CommentCount.HeaderText = "Количество комментариев";
            this.CommentCount.Name = "CommentCount";
            this.CommentCount.ReadOnly = true;
            // 
            // marks_comments
            // 
            this.marks_comments.DataPropertyName = "marks_comments";
            this.marks_comments.HeaderText = "Комментарии";
            this.marks_comments.Name = "marks_comments";
            // 
            // markBindingSource
            // 
            this.markBindingSource.DataSource = typeof(Log.mark);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(11, 214);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(277, 43);
            this.addBtn.TabIndex = 2;
            this.addBtn.Text = "Добавить";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(11, 263);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(277, 43);
            this.deleteBtn.TabIndex = 3;
            this.deleteBtn.Text = "Удалить";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // addGroupBtn
            // 
            this.addGroupBtn.Location = new System.Drawing.Point(11, 312);
            this.addGroupBtn.Name = "addGroupBtn";
            this.addGroupBtn.Size = new System.Drawing.Size(277, 43);
            this.addGroupBtn.TabIndex = 4;
            this.addGroupBtn.Text = "Добавить группу отметок";
            this.addGroupBtn.UseVisualStyleBackColor = true;
            this.addGroupBtn.Click += new System.EventHandler(this.AddGroupBtn_Click);
            // 
            // groupComboBox
            // 
            this.groupComboBox.DataSource = this.groupBindingSourceMenu;
            this.groupComboBox.DisplayMember = "Id";
            this.groupComboBox.Enabled = false;
            this.groupComboBox.FormattingEnabled = true;
            this.groupComboBox.Location = new System.Drawing.Point(7, 53);
            this.groupComboBox.Name = "groupComboBox";
            this.groupComboBox.Size = new System.Drawing.Size(277, 32);
            this.groupComboBox.TabIndex = 4;
            this.groupComboBox.ValueMember = "Id";
            this.groupComboBox.SelectedIndexChanged += new System.EventHandler(this.groupComboBox_SelectedIndexChanged);
            // 
            // groupBindingSourceMenu
            // 
            this.groupBindingSourceMenu.DataSource = typeof(Log.group);
            // 
            // groupCheckBox
            // 
            this.groupCheckBox.AutoCheck = false;
            this.groupCheckBox.AutoSize = true;
            this.groupCheckBox.Checked = true;
            this.groupCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.groupCheckBox.Location = new System.Drawing.Point(9, 25);
            this.groupCheckBox.Name = "groupCheckBox";
            this.groupCheckBox.Size = new System.Drawing.Size(131, 28);
            this.groupCheckBox.TabIndex = 5;
            this.groupCheckBox.Text = "Все группы";
            this.groupCheckBox.UseVisualStyleBackColor = true;
            this.groupCheckBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            this.groupCheckBox.Click += new System.EventHandler(this.subjectCheckBox_Click);
            // 
            // sortedBox
            // 
            this.sortedBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.sortedBox.Controls.Add(this.update);
            this.sortedBox.Controls.Add(this.averageLabel);
            this.sortedBox.Controls.Add(this.label5);
            this.sortedBox.Controls.Add(this.addGroupBtn);
            this.sortedBox.Controls.Add(this.deleteBtn);
            this.sortedBox.Controls.Add(this.addBtn);
            this.sortedBox.Controls.Add(this.subjectCheckBox);
            this.sortedBox.Controls.Add(this.subjectComboBox1);
            this.sortedBox.Controls.Add(this.groupComboBox);
            this.sortedBox.Controls.Add(this.groupCheckBox);
            this.sortedBox.Location = new System.Drawing.Point(4, 3);
            this.sortedBox.Name = "sortedBox";
            this.sortedBox.Size = new System.Drawing.Size(294, 579);
            this.sortedBox.TabIndex = 6;
            this.sortedBox.TabStop = false;
            this.sortedBox.Text = "Сортировка";
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(11, 361);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(277, 40);
            this.update.TabIndex = 20;
            this.update.Text = "Обновить";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // averageLabel
            // 
            this.averageLabel.AutoSize = true;
            this.averageLabel.Location = new System.Drawing.Point(111, 178);
            this.averageLabel.Name = "averageLabel";
            this.averageLabel.Size = new System.Drawing.Size(60, 24);
            this.averageLabel.TabIndex = 19;
            this.averageLabel.Text = "label6";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 24);
            this.label5.TabIndex = 18;
            this.label5.Text = "Ср. балл";
            // 
            // subjectCheckBox
            // 
            this.subjectCheckBox.AutoCheck = false;
            this.subjectCheckBox.AutoSize = true;
            this.subjectCheckBox.Checked = true;
            this.subjectCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.subjectCheckBox.Location = new System.Drawing.Point(9, 97);
            this.subjectCheckBox.Name = "subjectCheckBox";
            this.subjectCheckBox.Size = new System.Drawing.Size(159, 28);
            this.subjectCheckBox.TabIndex = 7;
            this.subjectCheckBox.Text = "Все предметы";
            this.subjectCheckBox.UseVisualStyleBackColor = true;
            this.subjectCheckBox.CheckedChanged += new System.EventHandler(this.subjectCheckBox_CheckedChanged);
            this.subjectCheckBox.Click += new System.EventHandler(this.subjectCheckBox_Click);
            // 
            // subjectComboBox1
            // 
            this.subjectComboBox1.DataSource = this.subjectBindingSourceMenu;
            this.subjectComboBox1.DisplayMember = "SubjectName";
            this.subjectComboBox1.Enabled = false;
            this.subjectComboBox1.FormattingEnabled = true;
            this.subjectComboBox1.Location = new System.Drawing.Point(7, 131);
            this.subjectComboBox1.Name = "subjectComboBox1";
            this.subjectComboBox1.Size = new System.Drawing.Size(277, 32);
            this.subjectComboBox1.TabIndex = 6;
            this.subjectComboBox1.ValueMember = "Id";
            this.subjectComboBox1.SelectedIndexChanged += new System.EventHandler(this.subjectComboBox1_SelectedIndexChanged);
            // 
            // subjectBindingSourceMenu
            // 
            this.subjectBindingSourceMenu.DataSource = typeof(Log.subject);
            // 
            // groupBindingSource
            // 
            this.groupBindingSource.DataSource = typeof(Log.group);
            // 
            // EditMarkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1300, 585);
            this.Controls.Add(this.sortedBox);
            this.Controls.Add(this.dataGridView);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "EditMarkForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Изменение отметок";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditMarkForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ViewMarkForm_FormClosed);
            this.Load += new System.EventHandler(this.ViewMarkForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeMarkBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.markBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBindingSourceMenu)).EndInit();
            this.sortedBox.ResumeLayout(false);
            this.sortedBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSourceMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.BindingSource markBindingSource;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private System.Windows.Forms.BindingSource subjectBindingSource;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button addGroupBtn;
        private System.Windows.Forms.BindingSource typeMarkBindingSource;
        private System.Windows.Forms.ComboBox groupComboBox;
        private System.Windows.Forms.CheckBox groupCheckBox;
        private System.Windows.Forms.GroupBox sortedBox;
        private System.Windows.Forms.CheckBox subjectCheckBox;
        private System.Windows.Forms.ComboBox subjectComboBox1;
        private System.Windows.Forms.Label averageLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource subjectBindingSourceMenu;
        private System.Windows.Forms.BindingSource groupBindingSourceMenu;
        private System.Windows.Forms.BindingSource groupBindingSource;
        private System.Windows.Forms.BindingSource subjectBindingGridView;
        private System.Windows.Forms.BindingSource studentBindingGridView;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.BindingSource teacherBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewComboBoxColumn studentIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn subjectIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn teacherIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn TypeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn monthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CommentCount;
        private System.Windows.Forms.DataGridViewButtonColumn marks_comments;
    }
}