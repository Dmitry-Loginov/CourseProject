
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
            this.subjectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.subjectComboBox = new System.Windows.Forms.ComboBox();
            this.typeMarkBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.typeMarkComboBox = new System.Windows.Forms.ComboBox();
            this.monthLabel = new System.Windows.Forms.Label();
            this.valueLabel = new System.Windows.Forms.Label();
            this.ballListBox = new System.Windows.Forms.ListBox();
            this.addButton = new System.Windows.Forms.Button();
            this.monthListBox = new System.Windows.Forms.ListBox();
            this.countListBox = new System.Windows.Forms.ListBox();
            this.labelCount = new System.Windows.Forms.Label();
            this.subjectBinding = new System.Windows.Forms.BindingSource(this.components);
            this.studentCheckBoxVoid = new System.Windows.Forms.CheckBox();
            this.subjectCheckBoxVoid = new System.Windows.Forms.CheckBox();
            this.typeMarkCheckBoxVoid = new System.Windows.Forms.CheckBox();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.groupComboBox = new System.Windows.Forms.ComboBox();
            this.groupCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.studentBinding = new System.Windows.Forms.BindingSource(this.components);
            this.groupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeMarkBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBinding)).BeginInit();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentBinding)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBindingSource)).BeginInit();
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
            this.studetnComboBox.Location = new System.Drawing.Point(19, 161);
            this.studetnComboBox.Margin = new System.Windows.Forms.Padding(6);
            this.studetnComboBox.Name = "studetnComboBox";
            this.studetnComboBox.Size = new System.Drawing.Size(484, 32);
            this.studetnComboBox.TabIndex = 1;
            this.studetnComboBox.ValueMember = "PassportId";
            this.studetnComboBox.SelectedIndexChanged += new System.EventHandler(this.studetnComboBox_SelectedIndexChanged);
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
            this.subjectComboBox.Location = new System.Drawing.Point(16, 231);
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
            this.typeMarkComboBox.Location = new System.Drawing.Point(16, 301);
            this.typeMarkComboBox.Name = "typeMarkComboBox";
            this.typeMarkComboBox.Size = new System.Drawing.Size(484, 32);
            this.typeMarkComboBox.TabIndex = 4;
            this.typeMarkComboBox.ValueMember = "Id";
            // 
            // monthLabel
            // 
            this.monthLabel.AutoSize = true;
            this.monthLabel.Location = new System.Drawing.Point(17, 350);
            this.monthLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.monthLabel.Name = "monthLabel";
            this.monthLabel.Size = new System.Drawing.Size(68, 24);
            this.monthLabel.TabIndex = 2;
            this.monthLabel.Text = "Месяц";
            // 
            // valueLabel
            // 
            this.valueLabel.AutoSize = true;
            this.valueLabel.Location = new System.Drawing.Point(200, 350);
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
            this.ballListBox.Location = new System.Drawing.Point(201, 377);
            this.ballListBox.Name = "ballListBox";
            this.ballListBox.Size = new System.Drawing.Size(120, 148);
            this.ballListBox.TabIndex = 6;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(21, 531);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(483, 45);
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
            this.monthListBox.Location = new System.Drawing.Point(21, 377);
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
            this.countListBox.Location = new System.Drawing.Point(384, 377);
            this.countListBox.Name = "countListBox";
            this.countListBox.Size = new System.Drawing.Size(120, 148);
            this.countListBox.TabIndex = 9;
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Location = new System.Drawing.Point(382, 350);
            this.labelCount.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(117, 24);
            this.labelCount.TabIndex = 2;
            this.labelCount.Text = "Количество";
            // 
            // subjectBinding
            // 
            this.subjectBinding.DataSource = typeof(Log.subject);
            // 
            // studentCheckBoxVoid
            // 
            this.studentCheckBoxVoid.AutoSize = true;
            this.studentCheckBoxVoid.BackColor = System.Drawing.Color.Transparent;
            this.studentCheckBoxVoid.Location = new System.Drawing.Point(249, 124);
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
            this.subjectCheckBoxVoid.Location = new System.Drawing.Point(249, 202);
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
            this.typeMarkCheckBoxVoid.Location = new System.Drawing.Point(248, 272);
            this.typeMarkCheckBoxVoid.Name = "typeMarkCheckBoxVoid";
            this.typeMarkCheckBoxVoid.Size = new System.Drawing.Size(188, 28);
            this.typeMarkCheckBoxVoid.TabIndex = 10;
            this.typeMarkCheckBoxVoid.Text = "Оставить пустым";
            this.typeMarkCheckBoxVoid.UseVisualStyleBackColor = false;
            this.typeMarkCheckBoxVoid.CheckedChanged += new System.EventHandler(this.typeMarkCheckBoxVoid_CheckedChanged);
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.groupComboBox);
            this.groupBox.Controls.Add(this.groupCheckBox);
            this.groupBox.Location = new System.Drawing.Point(3, 12);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(230, 106);
            this.groupBox.TabIndex = 11;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Группы";
            // 
            // groupComboBox
            // 
            this.groupComboBox.DataSource = this.groupBindingSource;
            this.groupComboBox.DisplayMember = "Id";
            this.groupComboBox.Enabled = false;
            this.groupComboBox.FormattingEnabled = true;
            this.groupComboBox.Location = new System.Drawing.Point(17, 61);
            this.groupComboBox.Name = "groupComboBox";
            this.groupComboBox.Size = new System.Drawing.Size(207, 32);
            this.groupComboBox.TabIndex = 4;
            this.groupComboBox.ValueMember = "Id";
            this.groupComboBox.SelectedIndexChanged += new System.EventHandler(this.groupComboBox_SelectedIndexChanged);
            // 
            // groupCheckBox
            // 
            this.groupCheckBox.AutoSize = true;
            this.groupCheckBox.Checked = true;
            this.groupCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.groupCheckBox.Location = new System.Drawing.Point(17, 26);
            this.groupCheckBox.Name = "groupCheckBox";
            this.groupCheckBox.Size = new System.Drawing.Size(131, 28);
            this.groupCheckBox.TabIndex = 5;
            this.groupCheckBox.Text = "Все группы";
            this.groupCheckBox.UseVisualStyleBackColor = true;
            this.groupCheckBox.CheckedChanged += new System.EventHandler(this.groupCheckBox_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 131);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Выберите студента";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 204);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Выберите предмет";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 274);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(217, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Выберите тип отметки";
            // 
            // studentBinding
            // 
            this.studentBinding.DataSource = typeof(Log.student);
            // 
            // groupBindingSource
            // 
            this.groupBindingSource.DataSource = typeof(Log.group);
            // 
            // AddGroupMarkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 588);
            this.Controls.Add(this.groupBox);
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
            this.Controls.Add(this.label3);
            this.Controls.Add(this.monthLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.studetnComboBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "AddGroupMarkForm";
            this.Text = "Добавить группу отметок";
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeMarkBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBinding)).EndInit();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentBinding)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource studentBindingSource;
        private System.Windows.Forms.ComboBox studetnComboBox;
        private System.Windows.Forms.BindingSource subjectBindingSource;
        private System.Windows.Forms.ComboBox subjectComboBox;
        private System.Windows.Forms.BindingSource typeMarkBindingSource;
        private System.Windows.Forms.ComboBox typeMarkComboBox;
        private System.Windows.Forms.Label monthLabel;
        private System.Windows.Forms.Label valueLabel;
        private System.Windows.Forms.ListBox ballListBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.ListBox monthListBox;
        private System.Windows.Forms.ListBox countListBox;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.BindingSource subjectBinding;
        private System.Windows.Forms.CheckBox studentCheckBoxVoid;
        private System.Windows.Forms.CheckBox subjectCheckBoxVoid;
        private System.Windows.Forms.CheckBox typeMarkCheckBoxVoid;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.ComboBox groupComboBox;
        private System.Windows.Forms.CheckBox groupCheckBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource studentBinding;
        private System.Windows.Forms.BindingSource groupBindingSource;
    }
}