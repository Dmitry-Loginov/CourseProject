
namespace Log
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createBackupMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restoreDbItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sqlQueryBtn = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button7);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(15, 30);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.Size = new System.Drawing.Size(327, 407);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Справочники";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(45, 321);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(200, 58);
            this.button7.TabIndex = 5;
            this.button7.Text = "Предметы преподавателей";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(45, 187);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(200, 46);
            this.button5.TabIndex = 4;
            this.button5.Text = "Преподаватели";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(45, 239);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(200, 76);
            this.button4.TabIndex = 3;
            this.button4.Text = "Предметы в группах";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(45, 83);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(200, 46);
            this.button3.TabIndex = 2;
            this.button3.Text = "Группы";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(45, 135);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 46);
            this.button2.TabIndex = 1;
            this.button2.Text = "Учащиеся";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(45, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 46);
            this.button1.TabIndex = 0;
            this.button1.Text = "Предметы";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(397, 47);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(172, 75);
            this.button6.TabIndex = 1;
            this.button6.Text = "Работа с отметками";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Button6_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справкаToolStripMenuItem,
            this.createBackupMenuItem,
            this.restoreDbItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(637, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.справкаToolStripMenuItem.Text = "Справка    F1";
            this.справкаToolStripMenuItem.Visible = false;
            this.справкаToolStripMenuItem.Click += new System.EventHandler(this.справкаToolStripMenuItem_Click);
            // 
            // createBackupMenuItem
            // 
            this.createBackupMenuItem.Name = "createBackupMenuItem";
            this.createBackupMenuItem.Size = new System.Drawing.Size(183, 20);
            this.createBackupMenuItem.Text = "Создать резервную копию БД";
            this.createBackupMenuItem.Visible = false;
            this.createBackupMenuItem.Click += new System.EventHandler(this.создатьРезервнуюКопиюБДToolStripMenuItem_Click);
            // 
            // restoreDbItem
            // 
            this.restoreDbItem.Name = "restoreDbItem";
            this.restoreDbItem.Size = new System.Drawing.Size(162, 20);
            this.restoreDbItem.Text = "Восстановить бд из копии";
            this.restoreDbItem.Visible = false;
            this.restoreDbItem.Click += new System.EventHandler(this.восстановитьБдИзКопииToolStripMenuItem_Click);
            // 
            // sqlQueryBtn
            // 
            this.sqlQueryBtn.Location = new System.Drawing.Point(397, 351);
            this.sqlQueryBtn.Name = "sqlQueryBtn";
            this.sqlQueryBtn.Size = new System.Drawing.Size(172, 75);
            this.sqlQueryBtn.TabIndex = 3;
            this.sqlQueryBtn.Text = "Запрос через SQL";
            this.sqlQueryBtn.UseVisualStyleBackColor = true;
            this.sqlQueryBtn.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(397, 128);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(172, 67);
            this.button9.TabIndex = 4;
            this.button9.Text = "Учителя и ср. балл";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(397, 201);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(172, 74);
            this.button11.TabIndex = 6;
            this.button11.Text = "Студенты с группой";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(397, 281);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(172, 64);
            this.button13.TabIndex = 8;
            this.button13.Text = "Лучшие студенты";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 665);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.sqlQueryBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Электронный журнал";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button sqlQueryBtn;
        private System.Windows.Forms.ToolStripMenuItem createBackupMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restoreDbItem;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button13;
    }
}

