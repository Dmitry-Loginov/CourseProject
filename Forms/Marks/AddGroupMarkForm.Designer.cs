
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddGroupMarkForm));
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
            this.ballListBox = new System.Windows.Forms.ListBox();
            this.addButton = new System.Windows.Forms.Button();
            this.monthListBox = new System.Windows.Forms.ListBox();
            this.countListBox = new System.Windows.Forms.ListBox();
            this.labelCount = new System.Windows.Forms.Label();
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentCheckBoxVoid = new System.Windows.Forms.CheckBox();
            this.subjectCheckBoxVoid = new System.Windows.Forms.CheckBox();
            this.typeMarkCheckBoxVoid = new System.Windows.Forms.CheckBox();
            this.monthCheckBoxVoid = new System.Windows.Forms.CheckBox();
            this.ballCheckBoxVoid = new System.Windows.Forms.CheckBox();
            this.countCheckBoxVoid = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeMarkBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
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
            this.studetnComboBox.SelectedIndexChanged += new System.EventHandler(this.studetnComboBox_SelectedIndexChanged);
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
            // ballListBox
            // 
            this.ballListBox.FormattingEnabled = true;
            this.ballListBox.ItemHeight = 24;
            this.ballListBox.Items.AddRange(new object[] {
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
            this.ballListBox.Location = new System.Drawing.Point(202, 270);
            this.ballListBox.Name = "ballListBox";
            this.ballListBox.Size = new System.Drawing.Size(120, 148);
            this.ballListBox.TabIndex = 6;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(24, 489);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(480, 45);
            this.addButton.TabIndex = 7;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.AddButton_Click);
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
            // countListBox
            // 
            this.countListBox.FormattingEnabled = true;
            this.countListBox.ItemHeight = 24;
            this.countListBox.Items.AddRange(new object[] {
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
            this.countListBox.Location = new System.Drawing.Point(396, 270);
            this.countListBox.Name = "countListBox";
            this.countListBox.Size = new System.Drawing.Size(120, 148);
            this.countListBox.TabIndex = 9;
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
            // bindingSource
            // 
            this.bindingSource.DataSource = typeof(Log.subject);
            // 
            // studentCheckBoxVoid
            // 
            this.studentCheckBoxVoid.AutoSize = true;
            this.studentCheckBoxVoid.BackColor = System.Drawing.Color.Transparent;
            this.studentCheckBoxVoid.Location = new System.Drawing.Point(246, 29);
            this.studentCheckBoxVoid.Name = "studentCheckBoxVoid";
            this.studentCheckBoxVoid.Size = new System.Drawing.Size(188, 28);
            this.studentCheckBoxVoid.TabIndex = 10;
            this.studentCheckBoxVoid.Text = "Оставить пустым";
            this.studentCheckBoxVoid.UseVisualStyleBackColor = false;
            this.studentCheckBoxVoid.CheckedChanged += new System.EventHandler(this.studentCheckBoxVoid_CheckedChanged);
            // 
            // subjectCheckBoxVoid
            // 
            this.subjectCheckBoxVoid.AutoSize = true;
            this.subjectCheckBoxVoid.BackColor = System.Drawing.Color.Transparent;
            this.subjectCheckBoxVoid.Location = new System.Drawing.Point(246, 96);
            this.subjectCheckBoxVoid.Name = "subjectCheckBoxVoid";
            this.subjectCheckBoxVoid.Size = new System.Drawing.Size(188, 28);
            this.subjectCheckBoxVoid.TabIndex = 10;
            this.subjectCheckBoxVoid.Text = "Оставить пустым";
            this.subjectCheckBoxVoid.UseVisualStyleBackColor = false;
            this.subjectCheckBoxVoid.CheckedChanged += new System.EventHandler(this.subjectCheckBoxVoid_CheckedChanged);
            // 
            // typeMarkCheckBoxVoid
            // 
            this.typeMarkCheckBoxVoid.AutoSize = true;
            this.typeMarkCheckBoxVoid.BackColor = System.Drawing.Color.Transparent;
            this.typeMarkCheckBoxVoid.Location = new System.Drawing.Point(246, 166);
            this.typeMarkCheckBoxVoid.Name = "typeMarkCheckBoxVoid";
            this.typeMarkCheckBoxVoid.Size = new System.Drawing.Size(188, 28);
            this.typeMarkCheckBoxVoid.TabIndex = 10;
            this.typeMarkCheckBoxVoid.Text = "Оставить пустым";
            this.typeMarkCheckBoxVoid.UseVisualStyleBackColor = false;
            this.typeMarkCheckBoxVoid.CheckedChanged += new System.EventHandler(this.typeMarkCheckBoxVoid_CheckedChanged);
            // 
            // monthCheckBoxVoid
            // 
            this.monthCheckBoxVoid.AutoSize = true;
            this.monthCheckBoxVoid.BackColor = System.Drawing.Color.Transparent;
            this.monthCheckBoxVoid.Location = new System.Drawing.Point(19, 424);
            this.monthCheckBoxVoid.Name = "monthCheckBoxVoid";
            this.monthCheckBoxVoid.Size = new System.Drawing.Size(117, 28);
            this.monthCheckBoxVoid.TabIndex = 10;
            this.monthCheckBoxVoid.Text = "Оставить";
            this.monthCheckBoxVoid.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.monthCheckBoxVoid.UseVisualStyleBackColor = false;
            this.monthCheckBoxVoid.CheckedChanged += new System.EventHandler(this.monthCheckBoxVoid_CheckedChanged);
            // 
            // ballCheckBoxVoid
            // 
            this.ballCheckBoxVoid.AutoSize = true;
            this.ballCheckBoxVoid.BackColor = System.Drawing.Color.Transparent;
            this.ballCheckBoxVoid.Location = new System.Drawing.Point(202, 424);
            this.ballCheckBoxVoid.Name = "ballCheckBoxVoid";
            this.ballCheckBoxVoid.Size = new System.Drawing.Size(117, 28);
            this.ballCheckBoxVoid.TabIndex = 10;
            this.ballCheckBoxVoid.Text = "Оставить";
            this.ballCheckBoxVoid.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.ballCheckBoxVoid.UseVisualStyleBackColor = false;
            this.ballCheckBoxVoid.CheckedChanged += new System.EventHandler(this.ballCheckBoxVoid_CheckedChanged);
            // 
            // countCheckBoxVoid
            // 
            this.countCheckBoxVoid.AutoSize = true;
            this.countCheckBoxVoid.BackColor = System.Drawing.Color.Transparent;
            this.countCheckBoxVoid.Location = new System.Drawing.Point(396, 424);
            this.countCheckBoxVoid.Name = "countCheckBoxVoid";
            this.countCheckBoxVoid.Size = new System.Drawing.Size(117, 28);
            this.countCheckBoxVoid.TabIndex = 10;
            this.countCheckBoxVoid.Text = "Оставить";
            this.countCheckBoxVoid.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.countCheckBoxVoid.UseVisualStyleBackColor = false;
            this.countCheckBoxVoid.CheckedChanged += new System.EventHandler(this.countCheckBoxVoid_CheckedChanged);
            // 
            // AddGroupMarkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 546);
            this.Controls.Add(this.countCheckBoxVoid);
            this.Controls.Add(this.ballCheckBoxVoid);
            this.Controls.Add(this.monthCheckBoxVoid);
            this.Controls.Add(this.typeMarkCheckBoxVoid);
            this.Controls.Add(this.subjectCheckBoxVoid);
            this.Controls.Add(this.studentCheckBoxVoid);
            this.Controls.Add(this.countListBox);
            this.Controls.Add(this.monthListBox);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.ballListBox);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "AddGroupMarkForm";
            this.Text = "Добавить группу отметок";
            this.Load += new System.EventHandler(this.AddGroupMarkForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeMarkBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
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
        private System.Windows.Forms.ListBox ballListBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.ListBox monthListBox;
        private System.Windows.Forms.ListBox countListBox;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.BindingSource bindingSource;
        private System.Windows.Forms.CheckBox studentCheckBoxVoid;
        private System.Windows.Forms.CheckBox subjectCheckBoxVoid;
        private System.Windows.Forms.CheckBox typeMarkCheckBoxVoid;
        private System.Windows.Forms.CheckBox monthCheckBoxVoid;
        private System.Windows.Forms.CheckBox ballCheckBoxVoid;
        private System.Windows.Forms.CheckBox countCheckBoxVoid;
    }
}