
namespace Log.Forms.Directories
{
    partial class AddSubjectToTeacherForm
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
            System.Windows.Forms.Label teacherIdLabel;
            System.Windows.Forms.Label subjectIdLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddSubjectToTeacherForm));
            this.teacherIdComboBox = new System.Windows.Forms.ComboBox();
            this.add = new System.Windows.Forms.Button();
            this.subjectIdListBox = new System.Windows.Forms.ListBox();
            this.teacherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.subjectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.subjectToTeacherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            teacherIdLabel = new System.Windows.Forms.Label();
            subjectIdLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectToTeacherBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // teacherIdLabel
            // 
            teacherIdLabel.AutoSize = true;
            teacherIdLabel.Location = new System.Drawing.Point(11, 9);
            teacherIdLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            teacherIdLabel.Name = "teacherIdLabel";
            teacherIdLabel.Size = new System.Drawing.Size(152, 24);
            teacherIdLabel.TabIndex = 3;
            teacherIdLabel.Text = "Преподаватель";
            // 
            // subjectIdLabel
            // 
            subjectIdLabel.AutoSize = true;
            subjectIdLabel.Location = new System.Drawing.Point(11, 90);
            subjectIdLabel.Name = "subjectIdLabel";
            subjectIdLabel.Size = new System.Drawing.Size(91, 24);
            subjectIdLabel.TabIndex = 6;
            subjectIdLabel.Text = "Предмет";
            // 
            // teacherIdComboBox
            // 
            this.teacherIdComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.teacherIdComboBox.DataSource = this.teacherBindingSource;
            this.teacherIdComboBox.DisplayMember = "Fio";
            this.teacherIdComboBox.FormattingEnabled = true;
            this.teacherIdComboBox.Location = new System.Drawing.Point(15, 39);
            this.teacherIdComboBox.Margin = new System.Windows.Forms.Padding(6);
            this.teacherIdComboBox.Name = "teacherIdComboBox";
            this.teacherIdComboBox.Size = new System.Drawing.Size(343, 32);
            this.teacherIdComboBox.TabIndex = 4;
            this.teacherIdComboBox.ValueMember = "Id";
            // 
            // add
            // 
            this.add.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.add.Location = new System.Drawing.Point(15, 372);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(343, 37);
            this.add.TabIndex = 8;
            this.add.Text = "Добавить";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // subjectIdListBox
            // 
            this.subjectIdListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.subjectIdListBox.DataSource = this.subjectBindingSource;
            this.subjectIdListBox.DisplayMember = "SubjectName";
            this.subjectIdListBox.FormattingEnabled = true;
            this.subjectIdListBox.ItemHeight = 24;
            this.subjectIdListBox.Location = new System.Drawing.Point(15, 117);
            this.subjectIdListBox.Name = "subjectIdListBox";
            this.subjectIdListBox.Size = new System.Drawing.Size(343, 244);
            this.subjectIdListBox.TabIndex = 7;
            this.subjectIdListBox.ValueMember = "Id";
            // 
            // teacherBindingSource
            // 
            this.teacherBindingSource.DataSource = typeof(Log.teacher);
            // 
            // subjectBindingSource
            // 
            this.subjectBindingSource.DataSource = typeof(Log.subject);
            // 
            // AddSubjectToTeacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 439);
            this.Controls.Add(this.add);
            this.Controls.Add(subjectIdLabel);
            this.Controls.Add(this.subjectIdListBox);
            this.Controls.Add(teacherIdLabel);
            this.Controls.Add(this.teacherIdComboBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "AddSubjectToTeacherForm";
            this.Text = "Добавить предмет преподавателю";
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectToTeacherBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox teacherIdComboBox;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.ListBox subjectIdListBox;
        private System.Windows.Forms.BindingSource teacherBindingSource;
        private System.Windows.Forms.BindingSource subjectBindingSource;
        private System.Windows.Forms.BindingSource subjectToTeacherBindingSource;
    }
}