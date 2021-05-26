
namespace Log
{
    partial class AddGroupMarkForm
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
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studetnComboBox = new System.Windows.Forms.ComboBox();
            this.studentLabel = new System.Windows.Forms.Label();
            this.subjectLabel = new System.Windows.Forms.Label();
            this.subjectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.subjectComboBox = new System.Windows.Forms.ComboBox();
            this.typeMarkBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.typeMarkComboBox = new System.Windows.Forms.ComboBox();
            this.typeMarkLabel = new System.Windows.Forms.Label();
            this.monthLabel = new System.Windows.Forms.Label();
            this.valueLabel = new System.Windows.Forms.Label();
            this.valueListBox = new System.Windows.Forms.ListBox();
            this.addButton = new System.Windows.Forms.Button();
            this.monthListBox = new System.Windows.Forms.ListBox();
            this.countBox = new System.Windows.Forms.ListBox();
            this.labelCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeMarkBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataSource = typeof(Log.student);
            // 
            // studetnComboBox
            // 
            this.studetnComboBox.DataSource = this.studentBindingSource;
            this.studetnComboBox.DisplayMember = "Fio";
            this.studetnComboBox.FormattingEnabled = true;
            this.studetnComboBox.Location = new System.Drawing.Point(20, 59);
            this.studetnComboBox.Margin = new System.Windows.Forms.Padding(6);
            this.studetnComboBox.Name = "studetnComboBox";
            this.studetnComboBox.Size = new System.Drawing.Size(484, 32);
            this.studetnComboBox.TabIndex = 1;
            this.studetnComboBox.ValueMember = "PassportId";
            // 
            // studentLabel
            // 
            this.studentLabel.AutoSize = true;
            this.studentLabel.Location = new System.Drawing.Point(16, 29);
            this.studentLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.studentLabel.Name = "studentLabel";
            this.studentLabel.Size = new System.Drawing.Size(188, 24);
            this.studentLabel.TabIndex = 2;
            this.studentLabel.Text = "Выберите студента";
            // 
            // subjectLabel
            // 
            this.subjectLabel.AutoSize = true;
            this.subjectLabel.Location = new System.Drawing.Point(16, 98);
            this.subjectLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.subjectLabel.Name = "subjectLabel";
            this.subjectLabel.Size = new System.Drawing.Size(184, 24);
            this.subjectLabel.TabIndex = 2;
            this.subjectLabel.Text = "Выберите предмет";
            // 
            // subjectBindingSource
            // 
            this.subjectBindingSource.DataSource = typeof(Log.subject);
            // 
            // subjectComboBox
            // 
            this.subjectComboBox.DataSource = this.subjectBindingSource;
            this.subjectComboBox.DisplayMember = "SubjectName";
            this.subjectComboBox.FormattingEnabled = true;
            this.subjectComboBox.Location = new System.Drawing.Point(20, 125);
            this.subjectComboBox.Name = "subjectComboBox";
            this.subjectComboBox.Size = new System.Drawing.Size(484, 32);
            this.subjectComboBox.TabIndex = 3;
            this.subjectComboBox.ValueMember = "Id";
            // 
            // typeMarkBindingSource
            // 
            this.typeMarkBindingSource.DataSource = typeof(Log.typeMark);
            // 
            // typeMarkComboBox
            // 
            this.typeMarkComboBox.DataSource = this.typeMarkBindingSource;
            this.typeMarkComboBox.DisplayMember = "Type";
            this.typeMarkComboBox.FormattingEnabled = true;
            this.typeMarkComboBox.Location = new System.Drawing.Point(20, 195);
            this.typeMarkComboBox.Name = "typeMarkComboBox";
            this.typeMarkComboBox.Size = new System.Drawing.Size(484, 32);
            this.typeMarkComboBox.TabIndex = 4;
            this.typeMarkComboBox.ValueMember = "Id";
            // 
            // typeMarkLabel
            // 
            this.typeMarkLabel.AutoSize = true;
            this.typeMarkLabel.Location = new System.Drawing.Point(20, 168);
            this.typeMarkLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.typeMarkLabel.Name = "typeMarkLabel";
            this.typeMarkLabel.Size = new System.Drawing.Size(217, 24);
            this.typeMarkLabel.TabIndex = 2;
            this.typeMarkLabel.Text = "Выберите тип отметки";
            // 
            // monthLabel
            // 
            this.monthLabel.AutoSize = true;
            this.monthLabel.Location = new System.Drawing.Point(18, 243);
            this.monthLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.monthLabel.Name = "monthLabel";
            this.monthLabel.Size = new System.Drawing.Size(68, 24);
            this.monthLabel.TabIndex = 2;
            this.monthLabel.Text = "Месяц";
            // 
            // valueLabel
            // 
            this.valueLabel.AutoSize = true;
            this.valueLabel.Location = new System.Drawing.Point(202, 243);
            this.valueLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.valueLabel.Name = "valueLabel";
            this.valueLabel.Size = new System.Drawing.Size(53, 24);
            this.valueLabel.TabIndex = 2;
            this.valueLabel.Text = "Балл";
            // 
            // valueListBox
            // 
            this.valueListBox.FormattingEnabled = true;
            this.valueListBox.ItemHeight = 24;
            this.valueListBox.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.valueListBox.Location = new System.Drawing.Point(202, 270);
            this.valueListBox.Name = "valueListBox";
            this.valueListBox.Size = new System.Drawing.Size(120, 148);
            this.valueListBox.TabIndex = 6;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(20, 432);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(480, 45);
            this.addButton.TabIndex = 7;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // monthListBox
            // 
            this.monthListBox.FormattingEnabled = true;
            this.monthListBox.ItemHeight = 24;
            this.monthListBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.monthListBox.Location = new System.Drawing.Point(20, 270);
            this.monthListBox.Name = "monthListBox";
            this.monthListBox.Size = new System.Drawing.Size(120, 148);
            this.monthListBox.TabIndex = 8;
            // 
            // countBox
            // 
            this.countBox.FormattingEnabled = true;
            this.countBox.ItemHeight = 24;
            this.countBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25"});
            this.countBox.Location = new System.Drawing.Point(380, 270);
            this.countBox.Name = "countBox";
            this.countBox.Size = new System.Drawing.Size(120, 148);
            this.countBox.TabIndex = 9;
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Location = new System.Drawing.Point(385, 243);
            this.labelCount.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(117, 24);
            this.labelCount.TabIndex = 2;
            this.labelCount.Text = "Количество";
            // 
            // AddGroupMarkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 504);
            this.Controls.Add(this.countBox);
            this.Controls.Add(this.monthListBox);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.valueListBox);
            this.Controls.Add(this.typeMarkComboBox);
            this.Controls.Add(this.subjectComboBox);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.valueLabel);
            this.Controls.Add(this.monthLabel);
            this.Controls.Add(this.typeMarkLabel);
            this.Controls.Add(this.subjectLabel);
            this.Controls.Add(this.studentLabel);
            this.Controls.Add(this.studetnComboBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "AddGroupMarkForm";
            this.Text = "Добавить группу отметок";
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeMarkBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource studentBindingSource;
        private System.Windows.Forms.ComboBox studetnComboBox;
        private System.Windows.Forms.Label studentLabel;
        private System.Windows.Forms.Label subjectLabel;
        private System.Windows.Forms.BindingSource subjectBindingSource;
        private System.Windows.Forms.ComboBox subjectComboBox;
        private System.Windows.Forms.BindingSource typeMarkBindingSource;
        private System.Windows.Forms.ComboBox typeMarkComboBox;
        private System.Windows.Forms.Label typeMarkLabel;
        private System.Windows.Forms.Label monthLabel;
        private System.Windows.Forms.Label valueLabel;
        private System.Windows.Forms.ListBox valueListBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.ListBox monthListBox;
        private System.Windows.Forms.ListBox countBox;
        private System.Windows.Forms.Label labelCount;
    }
}