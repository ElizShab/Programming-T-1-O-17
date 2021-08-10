namespace Задание_3_Вариант_18
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Spisok_L = new System.Windows.Forms.Label();
            this.Spisok_LB = new System.Windows.Forms.ListBox();
            this.Add_B = new System.Windows.Forms.Button();
            this.Change_B = new System.Windows.Forms.Button();
            this.Del_B = new System.Windows.Forms.Button();
            this.Main_MS = new System.Windows.Forms.MenuStrip();
            this.действиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Add_TSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.Change_TSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.Del_TSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.Load_TSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.Save_TSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.Calc_TSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.Main_TS = new System.Windows.Forms.ToolStrip();
            this.Add_TSB = new System.Windows.Forms.ToolStripButton();
            this.Change_TSB = new System.Windows.Forms.ToolStripButton();
            this.Del_TSB = new System.Windows.Forms.ToolStripButton();
            this.Load_TSB = new System.Windows.Forms.ToolStripButton();
            this.Save_TSB = new System.Windows.Forms.ToolStripButton();
            this.Calc_TSB = new System.Windows.Forms.ToolStripButton();
            this.Main_SS = new System.Windows.Forms.StatusStrip();
            this.Name_TSSL = new System.Windows.Forms.ToolStripStatusLabel();
            this.Mas_TSSL = new System.Windows.Forms.ToolStripStatusLabel();
            this.Self_TSSL = new System.Windows.Forms.ToolStripStatusLabel();
            this.Load_B = new System.Windows.Forms.Button();
            this.Save_B = new System.Windows.Forms.Button();
            this.Calc_B = new System.Windows.Forms.Button();
            this.FormatSpisok_L = new System.Windows.Forms.Label();
            this.FormatSpisok_LB = new System.Windows.Forms.ListBox();
            this.Open_D = new System.Windows.Forms.OpenFileDialog();
            this.Save_D = new System.Windows.Forms.SaveFileDialog();
            this.Zadan_TB = new System.Windows.Forms.TextBox();
            this.Zadan_L = new System.Windows.Forms.Label();
            this.Main_MS.SuspendLayout();
            this.Main_TS.SuspendLayout();
            this.Main_SS.SuspendLayout();
            this.SuspendLayout();
            // 
            // Spisok_L
            // 
            this.Spisok_L.AutoSize = true;
            this.Spisok_L.Location = new System.Drawing.Point(33, 64);
            this.Spisok_L.Name = "Spisok_L";
            this.Spisok_L.Size = new System.Drawing.Size(79, 13);
            this.Spisok_L.TabIndex = 0;
            this.Spisok_L.Text = "Список мар&ок";
            // 
            // Spisok_LB
            // 
            this.Spisok_LB.FormattingEnabled = true;
            this.Spisok_LB.Location = new System.Drawing.Point(12, 80);
            this.Spisok_LB.Name = "Spisok_LB";
            this.Spisok_LB.Size = new System.Drawing.Size(139, 147);
            this.Spisok_LB.TabIndex = 1;
            this.Spisok_LB.SelectedIndexChanged += new System.EventHandler(this.Spisok_LB_SelectedIndexChanged);
            // 
            // Add_B
            // 
            this.Add_B.Location = new System.Drawing.Point(185, 80);
            this.Add_B.Name = "Add_B";
            this.Add_B.Size = new System.Drawing.Size(101, 31);
            this.Add_B.TabIndex = 2;
            this.Add_B.Text = "Добави&ть марку";
            this.Add_B.UseVisualStyleBackColor = true;
            this.Add_B.Click += new System.EventHandler(this.Add_B_Click);
            // 
            // Change_B
            // 
            this.Change_B.Enabled = false;
            this.Change_B.Location = new System.Drawing.Point(185, 119);
            this.Change_B.Name = "Change_B";
            this.Change_B.Size = new System.Drawing.Size(101, 56);
            this.Change_B.TabIndex = 3;
            this.Change_B.Text = "Изменит&ь информацию о марке";
            this.Change_B.UseVisualStyleBackColor = true;
            this.Change_B.Click += new System.EventHandler(this.button2_Click);
            // 
            // Del_B
            // 
            this.Del_B.Enabled = false;
            this.Del_B.Location = new System.Drawing.Point(185, 184);
            this.Del_B.Name = "Del_B";
            this.Del_B.Size = new System.Drawing.Size(101, 51);
            this.Del_B.TabIndex = 4;
            this.Del_B.Text = "Удалить &информацию о марке";
            this.Del_B.UseVisualStyleBackColor = true;
            this.Del_B.Click += new System.EventHandler(this.button3_Click);
            // 
            // Main_MS
            // 
            this.Main_MS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.действиеToolStripMenuItem});
            this.Main_MS.Location = new System.Drawing.Point(0, 0);
            this.Main_MS.Name = "Main_MS";
            this.Main_MS.Size = new System.Drawing.Size(522, 24);
            this.Main_MS.TabIndex = 5;
            this.Main_MS.Text = "menuStrip1";
            // 
            // действиеToolStripMenuItem
            // 
            this.действиеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Add_TSMI,
            this.Change_TSMI,
            this.Del_TSMI,
            this.Load_TSMI,
            this.Save_TSMI,
            this.Calc_TSMI});
            this.действиеToolStripMenuItem.Name = "действиеToolStripMenuItem";
            this.действиеToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.действиеToolStripMenuItem.Text = "Дей&ствие";
            // 
            // Add_TSMI
            // 
            this.Add_TSMI.Image = global::Задание_3_Вариант_18.Properties.Resources.K_MNDSQKxP0;
            this.Add_TSMI.Name = "Add_TSMI";
            this.Add_TSMI.Size = new System.Drawing.Size(152, 22);
            this.Add_TSMI.Text = "Добавить";
            this.Add_TSMI.Click += new System.EventHandler(this.Add_B_Click);
            // 
            // Change_TSMI
            // 
            this.Change_TSMI.Enabled = false;
            this.Change_TSMI.Image = global::Задание_3_Вариант_18.Properties.Resources._1K_MNDSQKxP0;
            this.Change_TSMI.Name = "Change_TSMI";
            this.Change_TSMI.Size = new System.Drawing.Size(152, 22);
            this.Change_TSMI.Text = "Изменить";
            this.Change_TSMI.Click += new System.EventHandler(this.button2_Click);
            // 
            // Del_TSMI
            // 
            this.Del_TSMI.Enabled = false;
            this.Del_TSMI.Image = global::Задание_3_Вариант_18.Properties.Resources._2K_MNDSQKxP0;
            this.Del_TSMI.Name = "Del_TSMI";
            this.Del_TSMI.Size = new System.Drawing.Size(152, 22);
            this.Del_TSMI.Text = "Удалить";
            this.Del_TSMI.Click += new System.EventHandler(this.button3_Click);
            // 
            // Load_TSMI
            // 
            this.Load_TSMI.Image = global::Задание_3_Вариант_18.Properties.Resources._3K_MNDSQKxP0;
            this.Load_TSMI.Name = "Load_TSMI";
            this.Load_TSMI.Size = new System.Drawing.Size(152, 22);
            this.Load_TSMI.Text = "Загрузить";
            this.Load_TSMI.Click += new System.EventHandler(this.Load_B_Click);
            // 
            // Save_TSMI
            // 
            this.Save_TSMI.Enabled = false;
            this.Save_TSMI.Image = global::Задание_3_Вариант_18.Properties.Resources._4K_MNDSQKxP0;
            this.Save_TSMI.Name = "Save_TSMI";
            this.Save_TSMI.Size = new System.Drawing.Size(152, 22);
            this.Save_TSMI.Text = "Сохранить";
            this.Save_TSMI.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Save_TSMI.Click += new System.EventHandler(this.Save_B_Click);
            // 
            // Calc_TSMI
            // 
            this.Calc_TSMI.Enabled = false;
            this.Calc_TSMI.Image = global::Задание_3_Вариант_18.Properties.Resources._5K_MNDSQKxP0;
            this.Calc_TSMI.Name = "Calc_TSMI";
            this.Calc_TSMI.Size = new System.Drawing.Size(152, 22);
            this.Calc_TSMI.Text = "Расчет";
            this.Calc_TSMI.Click += new System.EventHandler(this.Calc_B_Click);
            // 
            // Main_TS
            // 
            this.Main_TS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Add_TSB,
            this.Change_TSB,
            this.Del_TSB,
            this.Load_TSB,
            this.Save_TSB,
            this.Calc_TSB});
            this.Main_TS.Location = new System.Drawing.Point(0, 24);
            this.Main_TS.Name = "Main_TS";
            this.Main_TS.Size = new System.Drawing.Size(522, 25);
            this.Main_TS.TabIndex = 6;
            this.Main_TS.Text = "toolStrip1";
            // 
            // Add_TSB
            // 
            this.Add_TSB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Add_TSB.Image = ((System.Drawing.Image)(resources.GetObject("Add_TSB.Image")));
            this.Add_TSB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Add_TSB.Name = "Add_TSB";
            this.Add_TSB.Size = new System.Drawing.Size(23, 22);
            this.Add_TSB.Text = "Добавить";
            this.Add_TSB.Click += new System.EventHandler(this.Add_B_Click);
            // 
            // Change_TSB
            // 
            this.Change_TSB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Change_TSB.Enabled = false;
            this.Change_TSB.Image = ((System.Drawing.Image)(resources.GetObject("Change_TSB.Image")));
            this.Change_TSB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Change_TSB.Name = "Change_TSB";
            this.Change_TSB.Size = new System.Drawing.Size(23, 22);
            this.Change_TSB.Text = "Изменить";
            this.Change_TSB.Click += new System.EventHandler(this.button2_Click);
            // 
            // Del_TSB
            // 
            this.Del_TSB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Del_TSB.Enabled = false;
            this.Del_TSB.Image = ((System.Drawing.Image)(resources.GetObject("Del_TSB.Image")));
            this.Del_TSB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Del_TSB.Name = "Del_TSB";
            this.Del_TSB.Size = new System.Drawing.Size(23, 22);
            this.Del_TSB.Text = "Удалить";
            this.Del_TSB.Click += new System.EventHandler(this.button3_Click);
            // 
            // Load_TSB
            // 
            this.Load_TSB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Load_TSB.Image = ((System.Drawing.Image)(resources.GetObject("Load_TSB.Image")));
            this.Load_TSB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Load_TSB.Name = "Load_TSB";
            this.Load_TSB.Size = new System.Drawing.Size(23, 22);
            this.Load_TSB.Text = "Загрузить";
            this.Load_TSB.Click += new System.EventHandler(this.Load_B_Click);
            // 
            // Save_TSB
            // 
            this.Save_TSB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Save_TSB.Enabled = false;
            this.Save_TSB.Image = ((System.Drawing.Image)(resources.GetObject("Save_TSB.Image")));
            this.Save_TSB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Save_TSB.Name = "Save_TSB";
            this.Save_TSB.Size = new System.Drawing.Size(23, 22);
            this.Save_TSB.Text = "Сохранить";
            this.Save_TSB.Click += new System.EventHandler(this.Save_B_Click);
            // 
            // Calc_TSB
            // 
            this.Calc_TSB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Calc_TSB.Enabled = false;
            this.Calc_TSB.Image = ((System.Drawing.Image)(resources.GetObject("Calc_TSB.Image")));
            this.Calc_TSB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Calc_TSB.Name = "Calc_TSB";
            this.Calc_TSB.Size = new System.Drawing.Size(23, 22);
            this.Calc_TSB.Text = "Расчет";
            this.Calc_TSB.Click += new System.EventHandler(this.Calc_B_Click);
            // 
            // Main_SS
            // 
            this.Main_SS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Name_TSSL,
            this.Mas_TSSL,
            this.Self_TSSL});
            this.Main_SS.Location = new System.Drawing.Point(0, 359);
            this.Main_SS.Name = "Main_SS";
            this.Main_SS.Size = new System.Drawing.Size(522, 22);
            this.Main_SS.TabIndex = 7;
            this.Main_SS.Text = "statusStrip1";
            // 
            // Name_TSSL
            // 
            this.Name_TSSL.Name = "Name_TSSL";
            this.Name_TSSL.Size = new System.Drawing.Size(118, 17);
            this.Name_TSSL.Text = "toolStripStatusLabel1";
            // 
            // Mas_TSSL
            // 
            this.Mas_TSSL.Name = "Mas_TSSL";
            this.Mas_TSSL.Size = new System.Drawing.Size(118, 17);
            this.Mas_TSSL.Text = "toolStripStatusLabel1";
            // 
            // Self_TSSL
            // 
            this.Self_TSSL.Name = "Self_TSSL";
            this.Self_TSSL.Size = new System.Drawing.Size(118, 17);
            this.Self_TSSL.Text = "toolStripStatusLabel1";
            // 
            // Load_B
            // 
            this.Load_B.Location = new System.Drawing.Point(362, 251);
            this.Load_B.Name = "Load_B";
            this.Load_B.Size = new System.Drawing.Size(75, 23);
            this.Load_B.TabIndex = 8;
            this.Load_B.Text = "З&агрузить";
            this.Load_B.UseVisualStyleBackColor = true;
            this.Load_B.Click += new System.EventHandler(this.Load_B_Click);
            // 
            // Save_B
            // 
            this.Save_B.Enabled = false;
            this.Save_B.Location = new System.Drawing.Point(36, 251);
            this.Save_B.Name = "Save_B";
            this.Save_B.Size = new System.Drawing.Size(75, 23);
            this.Save_B.TabIndex = 9;
            this.Save_B.Text = "С&охранить";
            this.Save_B.UseVisualStyleBackColor = true;
            this.Save_B.Click += new System.EventHandler(this.Save_B_Click);
            // 
            // Calc_B
            // 
            this.Calc_B.Enabled = false;
            this.Calc_B.Location = new System.Drawing.Point(182, 320);
            this.Calc_B.Name = "Calc_B";
            this.Calc_B.Size = new System.Drawing.Size(104, 23);
            this.Calc_B.TabIndex = 10;
            this.Calc_B.Text = "Расч&ёт";
            this.Calc_B.UseVisualStyleBackColor = true;
            this.Calc_B.Click += new System.EventHandler(this.Calc_B_Click);
            // 
            // FormatSpisok_L
            // 
            this.FormatSpisok_L.AutoSize = true;
            this.FormatSpisok_L.Location = new System.Drawing.Point(292, 64);
            this.FormatSpisok_L.Name = "FormatSpisok_L";
            this.FormatSpisok_L.Size = new System.Drawing.Size(212, 13);
            this.FormatSpisok_L.TabIndex = 11;
            this.FormatSpisok_L.Text = "Список самолётов в заданно&м формате";
            // 
            // FormatSpisok_LB
            // 
            this.FormatSpisok_LB.FormattingEnabled = true;
            this.FormatSpisok_LB.Location = new System.Drawing.Point(331, 80);
            this.FormatSpisok_LB.Name = "FormatSpisok_LB";
            this.FormatSpisok_LB.Size = new System.Drawing.Size(139, 147);
            this.FormatSpisok_LB.TabIndex = 12;
            // 
            // Open_D
            // 
            this.Open_D.DefaultExt = "txt";
            this.Open_D.FileName = "openFileDialog1";
            this.Open_D.Filter = "(*.txt)|.txt | (*.*)| *.*";
            this.Open_D.InitialDirectory = ".";
            this.Open_D.ShowReadOnly = true;
            this.Open_D.Title = "Загрузка списка марок самолётов";
            // 
            // Save_D
            // 
            this.Save_D.DefaultExt = "txt";
            this.Save_D.Filter = "(*.txt)|*.txt|(*.*)|*.*";
            this.Save_D.InitialDirectory = ".";
            this.Save_D.Title = "Сохранение списка марок самолётов";
            // 
            // Zadan_TB
            // 
            this.Zadan_TB.Location = new System.Drawing.Point(185, 282);
            this.Zadan_TB.Name = "Zadan_TB";
            this.Zadan_TB.Size = new System.Drawing.Size(104, 20);
            this.Zadan_TB.TabIndex = 13;
            // 
            // Zadan_L
            // 
            this.Zadan_L.AutoSize = true;
            this.Zadan_L.Location = new System.Drawing.Point(88, 289);
            this.Zadan_L.Name = "Zadan_L";
            this.Zadan_L.Size = new System.Drawing.Size(91, 13);
            this.Zadan_L.TabIndex = 14;
            this.Zadan_L.Text = "Заданное чис&ло ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 381);
            this.Controls.Add(this.Zadan_L);
            this.Controls.Add(this.Zadan_TB);
            this.Controls.Add(this.FormatSpisok_LB);
            this.Controls.Add(this.FormatSpisok_L);
            this.Controls.Add(this.Calc_B);
            this.Controls.Add(this.Save_B);
            this.Controls.Add(this.Load_B);
            this.Controls.Add(this.Main_SS);
            this.Controls.Add(this.Main_TS);
            this.Controls.Add(this.Del_B);
            this.Controls.Add(this.Change_B);
            this.Controls.Add(this.Add_B);
            this.Controls.Add(this.Spisok_LB);
            this.Controls.Add(this.Spisok_L);
            this.Controls.Add(this.Main_MS);
            this.MainMenuStrip = this.Main_MS;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Main_MS.ResumeLayout(false);
            this.Main_MS.PerformLayout();
            this.Main_TS.ResumeLayout(false);
            this.Main_TS.PerformLayout();
            this.Main_SS.ResumeLayout(false);
            this.Main_SS.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Spisok_L;
        private System.Windows.Forms.ListBox Spisok_LB;
        private System.Windows.Forms.Button Add_B;
        private System.Windows.Forms.Button Change_B;
        private System.Windows.Forms.Button Del_B;
        private System.Windows.Forms.MenuStrip Main_MS;
        private System.Windows.Forms.ToolStrip Main_TS;
        private System.Windows.Forms.ToolStripButton Add_TSB;
        private System.Windows.Forms.ToolStripButton Change_TSB;
        private System.Windows.Forms.ToolStripButton Del_TSB;
        private System.Windows.Forms.ToolStripButton Load_TSB;
        private System.Windows.Forms.ToolStripButton Save_TSB;
        private System.Windows.Forms.ToolStripButton Calc_TSB;
        private System.Windows.Forms.StatusStrip Main_SS;
        private System.Windows.Forms.Button Load_B;
        private System.Windows.Forms.Button Save_B;
        private System.Windows.Forms.Button Calc_B;
        private System.Windows.Forms.Label FormatSpisok_L;
        private System.Windows.Forms.ListBox FormatSpisok_LB;
        private System.Windows.Forms.OpenFileDialog Open_D;
        private System.Windows.Forms.SaveFileDialog Save_D;
        private System.Windows.Forms.ToolStripMenuItem действиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Add_TSMI;
        private System.Windows.Forms.ToolStripMenuItem Change_TSMI;
        private System.Windows.Forms.ToolStripMenuItem Del_TSMI;
        private System.Windows.Forms.ToolStripMenuItem Load_TSMI;
        private System.Windows.Forms.ToolStripMenuItem Save_TSMI;
        private System.Windows.Forms.ToolStripMenuItem Calc_TSMI;
        private System.Windows.Forms.ToolStripStatusLabel Name_TSSL;
        private System.Windows.Forms.ToolStripStatusLabel Mas_TSSL;
        private System.Windows.Forms.ToolStripStatusLabel Self_TSSL;
        private System.Windows.Forms.TextBox Zadan_TB;
        private System.Windows.Forms.Label Zadan_L;
    }
}

