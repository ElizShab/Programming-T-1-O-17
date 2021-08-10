namespace WindowsFormsApplication4
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
            this.MASS1_TB = new System.Windows.Forms.TextBox();
            this.MASS2_TB = new System.Windows.Forms.TextBox();
            this.MASS3_TB = new System.Windows.Forms.TextBox();
            this.MASS1_L = new System.Windows.Forms.Label();
            this.MASS2_L = new System.Windows.Forms.Label();
            this.MASS3_L = new System.Windows.Forms.Label();
            this.Result_L = new System.Windows.Forms.Label();
            this.Result_TB = new System.Windows.Forms.TextBox();
            this.Calc_B = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MASS1_TB
            // 
            this.MASS1_TB.Location = new System.Drawing.Point(79, 31);
            this.MASS1_TB.Multiline = true;
            this.MASS1_TB.Name = "MASS1_TB";
            this.MASS1_TB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.MASS1_TB.Size = new System.Drawing.Size(89, 113);
            this.MASS1_TB.TabIndex = 0;
            // 
            // MASS2_TB
            // 
            this.MASS2_TB.Location = new System.Drawing.Point(278, 31);
            this.MASS2_TB.Multiline = true;
            this.MASS2_TB.Name = "MASS2_TB";
            this.MASS2_TB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.MASS2_TB.Size = new System.Drawing.Size(93, 113);
            this.MASS2_TB.TabIndex = 1;
            // 
            // MASS3_TB
            // 
            this.MASS3_TB.Location = new System.Drawing.Point(487, 28);
            this.MASS3_TB.Multiline = true;
            this.MASS3_TB.Name = "MASS3_TB";
            this.MASS3_TB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.MASS3_TB.Size = new System.Drawing.Size(93, 113);
            this.MASS3_TB.TabIndex = 2;
            // 
            // MASS1_L
            // 
            this.MASS1_L.AutoSize = true;
            this.MASS1_L.Location = new System.Drawing.Point(21, 34);
            this.MASS1_L.Name = "MASS1_L";
            this.MASS1_L.Size = new System.Drawing.Size(52, 13);
            this.MASS1_L.TabIndex = 3;
            this.MASS1_L.Text = "Массив&1";
            // 
            // MASS2_L
            // 
            this.MASS2_L.AutoSize = true;
            this.MASS2_L.Location = new System.Drawing.Point(220, 31);
            this.MASS2_L.Name = "MASS2_L";
            this.MASS2_L.Size = new System.Drawing.Size(52, 13);
            this.MASS2_L.TabIndex = 4;
            this.MASS2_L.Text = "Массив&2";
            // 
            // MASS3_L
            // 
            this.MASS3_L.AutoSize = true;
            this.MASS3_L.Location = new System.Drawing.Point(429, 31);
            this.MASS3_L.Name = "MASS3_L";
            this.MASS3_L.Size = new System.Drawing.Size(52, 13);
            this.MASS3_L.TabIndex = 5;
            this.MASS3_L.Text = "Массив&3";
            // 
            // Result_L
            // 
            this.Result_L.AutoSize = true;
            this.Result_L.Location = new System.Drawing.Point(194, 194);
            this.Result_L.Name = "Result_L";
            this.Result_L.Size = new System.Drawing.Size(27, 13);
            this.Result_L.TabIndex = 6;
            this.Result_L.Text = "Ma&x";
            // 
            // Result_TB
            // 
            this.Result_TB.Location = new System.Drawing.Point(227, 191);
            this.Result_TB.Name = "Result_TB";
            this.Result_TB.ReadOnly = true;
            this.Result_TB.Size = new System.Drawing.Size(100, 20);
            this.Result_TB.TabIndex = 7;
            // 
            // Calc_B
            // 
            this.Calc_B.Location = new System.Drawing.Point(211, 228);
            this.Calc_B.Name = "Calc_B";
            this.Calc_B.Size = new System.Drawing.Size(133, 48);
            this.Calc_B.TabIndex = 8;
            this.Calc_B.Text = "Рас&чет";
            this.Calc_B.UseVisualStyleBackColor = true;
            this.Calc_B.Click += new System.EventHandler(this.Calc_B_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 296);
            this.Controls.Add(this.Calc_B);
            this.Controls.Add(this.Result_TB);
            this.Controls.Add(this.Result_L);
            this.Controls.Add(this.MASS3_L);
            this.Controls.Add(this.MASS2_L);
            this.Controls.Add(this.MASS1_L);
            this.Controls.Add(this.MASS3_TB);
            this.Controls.Add(this.MASS2_TB);
            this.Controls.Add(this.MASS1_TB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox MASS1_TB;
        private System.Windows.Forms.TextBox MASS2_TB;
        private System.Windows.Forms.TextBox MASS3_TB;
        private System.Windows.Forms.Label MASS1_L;
        private System.Windows.Forms.Label MASS2_L;
        private System.Windows.Forms.Label MASS3_L;
        private System.Windows.Forms.Label Result_L;
        private System.Windows.Forms.TextBox Result_TB;
        private System.Windows.Forms.Button Calc_B;
    }
}

