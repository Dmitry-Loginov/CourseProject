
namespace Log
{
    partial class AddSubjectToGroup
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
            System.Windows.Forms.Label groupIdLabel;
            System.Windows.Forms.Label subjectIdLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddSubjectToGroup));
            this.logDataSet = new Log.LogDataSet();
            this.subjects_to_groupsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.subjects_to_groupsTableAdapter = new Log.LogDataSetTableAdapters.subjects_to_groupsTableAdapter();
            this.tableAdapterManager = new Log.LogDataSetTableAdapters.TableAdapterManager();
            this.groupIdComboBox = new System.Windows.Forms.ComboBox();
            this.groupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.subjectIdListBox = new System.Windows.Forms.ListBox();
            this.subjectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.add = new System.Windows.Forms.Button();
            groupIdLabel = new System.Windows.Forms.Label();
            subjectIdLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.logDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjects_to_groupsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupIdLabel
            // 
            groupIdLabel.AutoSize = true;
            groupIdLabel.Location = new System.Drawing.Point(11, 10);
            groupIdLabel.Name = "groupIdLabel";
            groupIdLabel.Size = new System.Drawing.Size(73, 24);
            groupIdLabel.TabIndex = 1;
            groupIdLabel.Text = "Группа";
            // 
            // subjectIdLabel
            // 
            subjectIdLabel.AutoSize = true;
            subjectIdLabel.Location = new System.Drawing.Point(8, 77);
            subjectIdLabel.Name = "subjectIdLabel";
            subjectIdLabel.Size = new System.Drawing.Size(91, 24);
            subjectIdLabel.TabIndex = 3;
            subjectIdLabel.Text = "Предмет";
            // 
            // logDataSet
            // 
            this.logDataSet.DataSetName = "LogDataSet";
            this.logDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // subjects_to_groupsBindingSource
            // 
            this.subjects_to_groupsBindingSource.DataMember = "subjects_to_groups";
            this.subjects_to_groupsBindingSource.DataSource = this.logDataSet;
            // 
            // subjects_to_groupsTableAdapter
            // 
            this.subjects_to_groupsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.subjects_to_groupsTableAdapter = this.subjects_to_groupsTableAdapter;
            this.tableAdapterManager.UpdateOrder = Log.LogDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // groupIdComboBox
            // 
            this.groupIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.subjects_to_groupsBindingSource, "GroupId", true));
            this.groupIdComboBox.DataSource = this.groupBindingSource;
            this.groupIdComboBox.DisplayMember = "Id";
            this.groupIdComboBox.FormattingEnabled = true;
            this.groupIdComboBox.Location = new System.Drawing.Point(12, 36);
            this.groupIdComboBox.Name = "groupIdComboBox";
            this.groupIdComboBox.Size = new System.Drawing.Size(343, 32);
            this.groupIdComboBox.TabIndex = 2;
            this.groupIdComboBox.ValueMember = "Id";
            // 
            // groupBindingSource
            // 
            this.groupBindingSource.DataSource = typeof(Log.group);
            // 
            // subjectIdListBox
            // 
            this.subjectIdListBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.subjects_to_groupsBindingSource, "SubjectId", true));
            this.subjectIdListBox.DataSource = this.subjectBindingSource;
            this.subjectIdListBox.DisplayMember = "SubjectName";
            this.subjectIdListBox.FormattingEnabled = true;
            this.subjectIdListBox.ItemHeight = 24;
            this.subjectIdListBox.Location = new System.Drawing.Point(12, 105);
            this.subjectIdListBox.Name = "subjectIdListBox";
            this.subjectIdListBox.Size = new System.Drawing.Size(343, 244);
            this.subjectIdListBox.TabIndex = 4;
            this.subjectIdListBox.ValueMember = "Id";
            // 
            // subjectBindingSource
            // 
            this.subjectBindingSource.DataSource = typeof(Log.subject);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(12, 355);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(343, 37);
            this.add.TabIndex = 5;
            this.add.Text = "Добавить";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // AddSubjectToGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(372, 417);
            this.Controls.Add(this.add);
            this.Controls.Add(groupIdLabel);
            this.Controls.Add(this.groupIdComboBox);
            this.Controls.Add(subjectIdLabel);
            this.Controls.Add(this.subjectIdListBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "AddSubjectToGroup";
            this.Text = "Добавить связь группа-предмет";
            this.Load += new System.EventHandler(this.AddSubjectToGroup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjects_to_groupsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LogDataSet logDataSet;
        private System.Windows.Forms.BindingSource subjects_to_groupsBindingSource;
        private LogDataSetTableAdapters.subjects_to_groupsTableAdapter subjects_to_groupsTableAdapter;
        private LogDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox groupIdComboBox;
        private System.Windows.Forms.BindingSource groupBindingSource;
        private System.Windows.Forms.ListBox subjectIdListBox;
        private System.Windows.Forms.BindingSource subjectBindingSource;
        private System.Windows.Forms.Button add;
    }
}