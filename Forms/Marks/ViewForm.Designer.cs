
namespace Log
{
    partial class ViewForm
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
            this.serialize = new System.Windows.Forms.Button();
            this.groupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.groupBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // serialize
            // 
            this.serialize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.serialize.Location = new System.Drawing.Point(12, 12);
            this.serialize.Name = "serialize";
            this.serialize.Size = new System.Drawing.Size(146, 44);
            this.serialize.TabIndex = 0;
            this.serialize.Text = "Сериализовать";
            this.serialize.UseVisualStyleBackColor = true;
            this.serialize.Click += new System.EventHandler(this.serialize_Click);
            // 
            // groupBindingSource
            // 
            this.groupBindingSource.DataSource = typeof(Log.group);
            // 
            // groupComboBox
            // 
            this.groupComboBox.DataSource = this.groupBindingSource;
            this.groupComboBox.DisplayMember = "Id";
            this.groupComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupComboBox.FormattingEnabled = true;
            this.groupComboBox.Location = new System.Drawing.Point(16, 86);
            this.groupComboBox.Name = "groupComboBox";
            this.groupComboBox.Size = new System.Drawing.Size(142, 32);
            this.groupComboBox.TabIndex = 2;
            this.groupComboBox.ValueMember = "Id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Группы";
            // 
            // ViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 575);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupComboBox);
            this.Controls.Add(this.serialize);
            this.Name = "ViewForm";
            this.Text = "Просмотр";
            ((System.ComponentModel.ISupportInitialize)(this.groupBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button serialize;
        private System.Windows.Forms.BindingSource groupBindingSource;
        private System.Windows.Forms.ComboBox groupComboBox;
        private System.Windows.Forms.Label label1;
    }
}