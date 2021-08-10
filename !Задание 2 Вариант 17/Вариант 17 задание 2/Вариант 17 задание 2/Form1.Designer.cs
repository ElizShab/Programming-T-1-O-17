namespace Вариант_17_задание_2
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
            this.F_TB = new System.Windows.Forms.TextBox();
            this.S_TB = new System.Windows.Forms.TextBox();
            this.F_L = new System.Windows.Forms.Label();
            this.S_L = new System.Windows.Forms.Label();
            this.A_B = new System.Windows.Forms.Button();
            this.Spisok_LB = new System.Windows.Forms.ListBox();
            this.D_B = new System.Windows.Forms.Button();
            this.R_TB = new System.Windows.Forms.TextBox();
            this.R_L = new System.Windows.Forms.Label();
            this.R_B = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // F_TB
            // 
            this.F_TB.Location = new System.Drawing.Point(117, 31);
            this.F_TB.Name = "F_TB";
            this.F_TB.Size = new System.Drawing.Size(96, 20);
            this.F_TB.TabIndex = 0;
            // 
            // S_TB
            // 
            this.S_TB.Location = new System.Drawing.Point(359, 31);
            this.S_TB.Name = "S_TB";
            this.S_TB.Size = new System.Drawing.Size(123, 20);
            this.S_TB.TabIndex = 1;
            // 
            // F_L
            // 
            this.F_L.AutoSize = true;
            this.F_L.Location = new System.Drawing.Point(65, 38);
            this.F_L.Name = "F_L";
            this.F_L.Size = new System.Drawing.Size(45, 13);
            this.F_L.TabIndex = 2;
            this.F_L.Text = "Число&1";
            // 
            // S_L
            // 
            this.S_L.AutoSize = true;
            this.S_L.Location = new System.Drawing.Point(308, 38);
            this.S_L.Name = "S_L";
            this.S_L.Size = new System.Drawing.Size(45, 13);
            this.S_L.TabIndex = 3;
            this.S_L.Text = "Число&2";
            // 
            // A_B
            // 
            this.A_B.Location = new System.Drawing.Point(231, 80);
            this.A_B.Name = "A_B";
            this.A_B.Size = new System.Drawing.Size(75, 23);
            this.A_B.TabIndex = 4;
            this.A_B.Text = "Доба&вить";
            this.A_B.UseVisualStyleBackColor = true;
            this.A_B.Click += new System.EventHandler(this.A_B_Click);
            // 
            // Spisok_LB
            // 
            this.Spisok_LB.FormattingEnabled = true;
            this.Spisok_LB.Location = new System.Drawing.Point(214, 151);
            this.Spisok_LB.Name = "Spisok_LB";
            this.Spisok_LB.Size = new System.Drawing.Size(120, 95);
            this.Spisok_LB.TabIndex = 5;
            // 
            // D_B
            // 
            this.D_B.Location = new System.Drawing.Point(393, 183);
            this.D_B.Name = "D_B";
            this.D_B.Size = new System.Drawing.Size(75, 23);
            this.D_B.TabIndex = 6;
            this.D_B.Text = "У&далить";
            this.D_B.UseVisualStyleBackColor = true;
            this.D_B.Click += new System.EventHandler(this.D_B_Click);
            // 
            // R_TB
            // 
            this.R_TB.Location = new System.Drawing.Point(219, 306);
            this.R_TB.Name = "R_TB";
            this.R_TB.ReadOnly = true;
            this.R_TB.Size = new System.Drawing.Size(114, 20);
            this.R_TB.TabIndex = 7;
            // 
            // R_L
            // 
            this.R_L.AutoSize = true;
            this.R_L.Location = new System.Drawing.Point(94, 314);
            this.R_L.Name = "R_L";
            this.R_L.Size = new System.Drawing.Size(119, 13);
            this.R_L.TabIndex = 8;
            this.R_L.Text = "Найденный резул&ьтат";
            // 
            // R_B
            // 
            this.R_B.Location = new System.Drawing.Point(416, 304);
            this.R_B.Name = "R_B";
            this.R_B.Size = new System.Drawing.Size(75, 23);
            this.R_B.TabIndex = 9;
            this.R_B.Text = "По&иск";
            this.R_B.UseVisualStyleBackColor = true;
            this.R_B.Click += new System.EventHandler(this.R_B_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 410);
            this.Controls.Add(this.R_B);
            this.Controls.Add(this.R_L);
            this.Controls.Add(this.R_TB);
            this.Controls.Add(this.D_B);
            this.Controls.Add(this.Spisok_LB);
            this.Controls.Add(this.A_B);
            this.Controls.Add(this.S_L);
            this.Controls.Add(this.F_L);
            this.Controls.Add(this.S_TB);
            this.Controls.Add(this.F_TB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox F_TB;
        private System.Windows.Forms.TextBox S_TB;
        private System.Windows.Forms.Label F_L;
        private System.Windows.Forms.Label S_L;
        private System.Windows.Forms.Button A_B;
        private System.Windows.Forms.ListBox Spisok_LB;
        private System.Windows.Forms.Button D_B;
        private System.Windows.Forms.TextBox R_TB;
        private System.Windows.Forms.Label R_L;
        private System.Windows.Forms.Button R_B;
    }
}

