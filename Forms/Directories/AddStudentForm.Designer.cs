
namespace Log
{
    partial class AddStudentForm
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
            System.Windows.Forms.Label birthdayLabel;
            System.Windows.Forms.Label fioLabel;
            System.Windows.Forms.Label groupIdLabel;
            System.Windows.Forms.Label passportIdLabel;
            System.Windows.Forms.Label phoneLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddStudentForm));
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.birthdayDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.fioTextBox = new System.Windows.Forms.TextBox();
            this.groupIdComboBox = new System.Windows.Forms.ComboBox();
            this.groupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.passportIdTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            birthdayLabel = new System.Windows.Forms.Label();
            fioLabel = new System.Windows.Forms.Label();
            groupIdLabel = new System.Windows.Forms.Label();
            passportIdLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // birthdayLabel
            // 
            birthdayLabel.AutoSize = true;
            birthdayLabel.Location = new System.Drawing.Point(15, 20);
            birthdayLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            birthdayLabel.Name = "birthdayLabel";
            birthdayLabel.Size = new System.Drawing.Size(150, 24);
            birthdayLabel.TabIndex = 1;
            birthdayLabel.Text = "Дата рождения\r\n";
            // 
            // fioLabel
            // 
            fioLabel.AutoSize = true;
            fioLabel.Location = new System.Drawing.Point(15, 66);
            fioLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            fioLabel.Name = "fioLabel";
            fioLabel.Size = new System.Drawing.Size(54, 24);
            fioLabel.TabIndex = 3;
            fioLabel.Text = "ФИО";
            // 
            // groupIdLabel
            // 
            groupIdLabel.AutoSize = true;
            groupIdLabel.Location = new System.Drawing.Point(15, 114);
            groupIdLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            groupIdLabel.Name = "groupIdLabel";
            groupIdLabel.Size = new System.Drawing.Size(73, 24);
            groupIdLabel.TabIndex = 5;
            groupIdLabel.Text = "Группа";
            // 
            // passportIdLabel
            // 
            passportIdLabel.AutoSize = true;
            passportIdLabel.Location = new System.Drawing.Point(15, 164);
            passportIdLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            passportIdLabel.Name = "passportIdLabel";
            passportIdLabel.Size = new System.Drawing.Size(86, 24);
            passportIdLabel.TabIndex = 7;
            passportIdLabel.Text = "Паспорт";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new System.Drawing.Point(15, 212);
            phoneLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(90, 24);
            phoneLabel.TabIndex = 9;
            phoneLabel.Text = "Телефон";
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataSource = typeof(Log.student);
            // 
            // birthdayDateTimePicker
            // 
            this.birthdayDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.studentBindingSource, "Birthday", true));
            this.birthdayDateTimePicker.Location = new System.Drawing.Point(200, 15);
            this.birthdayDateTimePicker.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.birthdayDateTimePicker.Name = "birthdayDateTimePicker";
            this.birthdayDateTimePicker.Size = new System.Drawing.Size(363, 29);
            this.birthdayDateTimePicker.TabIndex = 2;
            // 
            // fioTextBox
            // 
            this.fioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "Fio", true));
            this.fioTextBox.Location = new System.Drawing.Point(200, 63);
            this.fioTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.fioTextBox.Name = "fioTextBox";
            this.fioTextBox.Size = new System.Drawing.Size(363, 29);
            this.fioTextBox.TabIndex = 4;
            // 
            // groupIdComboBox
            // 
            this.groupIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "GroupId", true));
            this.groupIdComboBox.DataSource = this.groupBindingSource;
            this.groupIdComboBox.DisplayMember = "Id";
            this.groupIdComboBox.FormattingEnabled = true;
            this.groupIdComboBox.Location = new System.Drawing.Point(200, 111);
            this.groupIdComboBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupIdComboBox.Name = "groupIdComboBox";
            this.groupIdComboBox.Size = new System.Drawing.Size(363, 32);
            this.groupIdComboBox.TabIndex = 6;
            this.groupIdComboBox.ValueMember = "Id";
            // 
            // groupBindingSource
            // 
            this.groupBindingSource.DataSource = typeof(Log.group);
            // 
            // passportIdTextBox
            // 
            this.passportIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "PassportId", true));
            this.passportIdTextBox.Location = new System.Drawing.Point(200, 161);
            this.passportIdTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.passportIdTextBox.Name = "passportIdTextBox";
            this.passportIdTextBox.Size = new System.Drawing.Size(363, 29);
            this.passportIdTextBox.TabIndex = 8;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "Phone", true));
            this.phoneTextBox.Location = new System.Drawing.Point(200, 209);
            this.phoneTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(363, 29);
            this.phoneTextBox.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(19, 254);
            this.button1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 42);
            this.button1.TabIndex = 11;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 379);
            this.Controls.Add(this.button1);
            this.Controls.Add(birthdayLabel);
            this.Controls.Add(this.birthdayDateTimePicker);
            this.Controls.Add(fioLabel);
            this.Controls.Add(this.fioTextBox);
            this.Controls.Add(groupIdLabel);
            this.Controls.Add(this.groupIdComboBox);
            this.Controls.Add(passportIdLabel);
            this.Controls.Add(this.passportIdTextBox);
            this.Controls.Add(phoneLabel);
            this.Controls.Add(this.phoneTextBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "AddStudentForm";
            this.Text = "Добавить учащегося";
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource studentBindingSource;
        private System.Windows.Forms.DateTimePicker birthdayDateTimePicker;
        private System.Windows.Forms.TextBox fioTextBox;
        private System.Windows.Forms.ComboBox groupIdComboBox;
        private System.Windows.Forms.TextBox passportIdTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.BindingSource groupBindingSource;
        private System.Windows.Forms.Button button1;
    }
}