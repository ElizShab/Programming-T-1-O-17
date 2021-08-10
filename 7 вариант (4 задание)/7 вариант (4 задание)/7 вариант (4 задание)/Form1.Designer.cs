namespace _7_вариант__4_задание_
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
            this.MAS_L = new System.Windows.Forms.Label();
            this.MAS_TB = new System.Windows.Forms.TextBox();
            this.SUM1_L = new System.Windows.Forms.Label();
            this.SUM1_TB = new System.Windows.Forms.TextBox();
            this.SUM2_L = new System.Windows.Forms.Label();
            this.SUM2_TB = new System.Windows.Forms.TextBox();
            this.Calc_B = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MAS_L
            // 
            this.MAS_L.AutoSize = true;
            this.MAS_L.Location = new System.Drawing.Point(233, 69);
            this.MAS_L.Name = "MAS_L";
            this.MAS_L.Size = new System.Drawing.Size(99, 13);
            this.MAS_L.TabIndex = 0;
            this.MAS_L.Text = "Ис&ходный массив";
            // 
            // MAS_TB
            // 
            this.MAS_TB.Location = new System.Drawing.Point(338, 12);
            this.MAS_TB.Multiline = true;
            this.MAS_TB.Name = "MAS_TB";
            this.MAS_TB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.MAS_TB.Size = new System.Drawing.Size(227, 155);
            this.MAS_TB.TabIndex = 1;
            // 
            // SUM1_L
            // 
            this.SUM1_L.AutoSize = true;
            this.SUM1_L.Location = new System.Drawing.Point(35, 191);
            this.SUM1_L.Name = "SUM1_L";
            this.SUM1_L.Size = new System.Drawing.Size(190, 13);
            this.SUM1_L.TabIndex = 2;
            this.SUM1_L.Text = "Суммма &положительных элементов";
            // 
            // SUM1_TB
            // 
            this.SUM1_TB.Location = new System.Drawing.Point(231, 188);
            this.SUM1_TB.Name = "SUM1_TB";
            this.SUM1_TB.ReadOnly = true;
            this.SUM1_TB.Size = new System.Drawing.Size(145, 20);
            this.SUM1_TB.TabIndex = 3;
            // 
            // SUM2_L
            // 
            this.SUM2_L.AutoSize = true;
            this.SUM2_L.Location = new System.Drawing.Point(404, 195);
            this.SUM2_L.Name = "SUM2_L";
            this.SUM2_L.Size = new System.Drawing.Size(179, 13);
            this.SUM2_L.TabIndex = 4;
            this.SUM2_L.Text = "Сумма &отрицательных элементов";
            // 
            // SUM2_TB
            // 
            this.SUM2_TB.Location = new System.Drawing.Point(589, 191);
            this.SUM2_TB.Name = "SUM2_TB";
            this.SUM2_TB.ReadOnly = true;
            this.SUM2_TB.Size = new System.Drawing.Size(147, 20);
            this.SUM2_TB.TabIndex = 5;
            // 
            // Calc_B
            // 
            this.Calc_B.Location = new System.Drawing.Point(289, 242);
            this.Calc_B.Name = "Calc_B";
            this.Calc_B.Size = new System.Drawing.Size(168, 58);
            this.Calc_B.TabIndex = 6;
            this.Calc_B.Text = "Рас&чет";
            this.Calc_B.UseVisualStyleBackColor = true;
            this.Calc_B.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 339);
            this.Controls.Add(this.Calc_B);
            this.Controls.Add(this.SUM2_TB);
            this.Controls.Add(this.SUM2_L);
            this.Controls.Add(this.SUM1_TB);
            this.Controls.Add(this.SUM1_L);
            this.Controls.Add(this.MAS_TB);
            this.Controls.Add(this.MAS_L);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MAS_L;
        private System.Windows.Forms.TextBox MAS_TB;
        private System.Windows.Forms.Label SUM1_L;
        private System.Windows.Forms.TextBox SUM1_TB;
        private System.Windows.Forms.Label SUM2_L;
        private System.Windows.Forms.TextBox SUM2_TB;
        private System.Windows.Forms.Button Calc_B;
    }
}

