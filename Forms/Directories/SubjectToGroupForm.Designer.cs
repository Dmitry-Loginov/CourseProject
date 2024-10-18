
namespace Log
{
    partial class SubjectToGroupForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SubjectToGroupForm));
            this.logDataSet = new Log.LogDataSet();
            this.subjects_to_groupsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.subjects_to_groupsTableAdapter = new Log.LogDataSetTableAdapters.subjects_to_groupsTableAdapter();
            this.tableAdapterManager = new Log.LogDataSetTableAdapters.TableAdapterManager();
            this.subjects_to_groupsDataGridView = new System.Windows.Forms.DataGridView();
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.subjectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.logDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjects_to_groupsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjects_to_groupsDataGridView)).BeginInit();
            this.contextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource)).BeginInit();
            this.SuspendLayout();
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
            // subjects_to_groupsDataGridView
            // 
            this.subjects_to_groupsDataGridView.AllowUserToAddRows = false;
            this.subjects_to_groupsDataGridView.AllowUserToDeleteRows = false;
            this.subjects_to_groupsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.subjects_to_groupsDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.subjects_to_groupsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.subjects_to_groupsDataGridView.ContextMenuStrip = this.contextMenu;
            this.subjects_to_groupsDataGridView.Location = new System.Drawing.Point(0, -4);
            this.subjects_to_groupsDataGridView.Margin = new System.Windows.Forms.Padding(6);
            this.subjects_to_groupsDataGridView.MultiSelect = false;
            this.subjects_to_groupsDataGridView.Name = "subjects_to_groupsDataGridView";
            this.subjects_to_groupsDataGridView.ReadOnly = true;
            this.subjects_to_groupsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.subjects_to_groupsDataGridView.Size = new System.Drawing.Size(582, 268);
            this.subjects_to_groupsDataGridView.TabIndex = 1;
            // 
            // contextMenu
            // 
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.удалитьToolStripMenuItem});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(127, 48);
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            this.добавитьToolStripMenuItem.Click += new System.EventHandler(this.добавитьToolStripMenuItem_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "SubjectId";
            this.dataGridViewTextBoxColumn3.DataSource = this.subjectBindingSource;
            this.dataGridViewTextBoxColumn3.DisplayMember = "SubjectName";
            this.dataGridViewTextBoxColumn3.HeaderText = "Предмет";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // subjectBindingSource
            // 
            this.subjectBindingSource.DataSource = typeof(Log.subject);
            // 
            // SubjectToGroupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 259);
            this.Controls.Add(this.subjects_to_groupsDataGridView);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "SubjectToGroupForm";
            this.Text = "Соотнешение групп и предметов";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SubjectToGroupForm_FormClosing);
            this.Load += new System.EventHandler(this.SubjectToGroupForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjects_to_groupsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjects_to_groupsDataGridView)).EndInit();
            this.contextMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private LogDataSet logDataSet;
        private System.Windows.Forms.BindingSource subjects_to_groupsBindingSource;
        private LogDataSetTableAdapters.subjects_to_groupsTableAdapter subjects_to_groupsTableAdapter;
        private LogDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView subjects_to_groupsDataGridView;
        private System.Windows.Forms.BindingSource subjectBindingSource;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
    }
}