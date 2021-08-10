namespace вариант_7__5_задание_
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
            this.masX_L = new System.Windows.Forms.Label();
            this.masX_TB = new System.Windows.Forms.TextBox();
            this.masY_L = new System.Windows.Forms.Label();
            this.masY_TB = new System.Windows.Forms.TextBox();
            this.matrZ_L = new System.Windows.Forms.Label();
            this.matrZ_DGV = new System.Windows.Forms.DataGridView();
            this.Res_L = new System.Windows.Forms.Label();
            this.Res_TB = new System.Windows.Forms.TextBox();
            this.Calc_B = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.matrZ_DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // masX_L
            // 
            this.masX_L.AutoSize = true;
            this.masX_L.Location = new System.Drawing.Point(29, 43);
            this.masX_L.Name = "masX_L";
            this.masX_L.Size = new System.Drawing.Size(56, 13);
            this.masX_L.TabIndex = 0;
            this.masX_L.Text = "Массив &X";
            // 
            // masX_TB
            // 
            this.masX_TB.Location = new System.Drawing.Point(91, 36);
            this.masX_TB.Multiline = true;
            this.masX_TB.Name = "masX_TB";
            this.masX_TB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.masX_TB.Size = new System.Drawing.Size(132, 144);
            this.masX_TB.TabIndex = 1;
            // 
            // masY_L
            // 
            this.masY_L.AutoSize = true;
            this.masY_L.Location = new System.Drawing.Point(300, 43);
            this.masY_L.Name = "masY_L";
            this.masY_L.Size = new System.Drawing.Size(56, 13);
            this.masY_L.TabIndex = 2;
            this.masY_L.Text = "Массив &Y";
            // 
            // masY_TB
            // 
            this.masY_TB.Location = new System.Drawing.Point(362, 36);
            this.masY_TB.Multiline = true;
            this.masY_TB.Name = "masY_TB";
            this.masY_TB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.masY_TB.Size = new System.Drawing.Size(132, 144);
            this.masY_TB.TabIndex = 3;
            // 
            // matrZ_L
            // 
            this.matrZ_L.AutoSize = true;
            this.matrZ_L.Location = new System.Drawing.Point(93, 219);
            this.matrZ_L.Name = "matrZ_L";
            this.matrZ_L.Size = new System.Drawing.Size(61, 13);
            this.matrZ_L.TabIndex = 4;
            this.matrZ_L.Text = "Матрица &Z";
            // 
            // matrZ_DGV
            // 
            this.matrZ_DGV.AllowUserToAddRows = false;
            this.matrZ_DGV.AllowUserToDeleteRows = false;
            this.matrZ_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.matrZ_DGV.ColumnHeadersVisible = false;
            this.matrZ_DGV.Location = new System.Drawing.Point(160, 219);
            this.matrZ_DGV.Name = "matrZ_DGV";
            this.matrZ_DGV.ReadOnly = true;
            this.matrZ_DGV.RowHeadersVisible = false;
            this.matrZ_DGV.Size = new System.Drawing.Size(309, 184);
            this.matrZ_DGV.TabIndex = 5;
            // 
            // Res_L
            // 
            this.Res_L.AutoSize = true;
            this.Res_L.Location = new System.Drawing.Point(56, 444);
            this.Res_L.Name = "Res_L";
            this.Res_L.Size = new System.Drawing.Size(59, 13);
            this.Res_L.TabIndex = 6;
            this.Res_L.Text = "Рез&ультат";
            this.Res_L.Click += new System.EventHandler(this.label4_Click);
            // 
            // Res_TB
            // 
            this.Res_TB.Location = new System.Drawing.Point(121, 437);
            this.Res_TB.Name = "Res_TB";
            this.Res_TB.ReadOnly = true;
            this.Res_TB.Size = new System.Drawing.Size(135, 20);
            this.Res_TB.TabIndex = 7;
            // 
            // Calc_B
            // 
            this.Calc_B.Location = new System.Drawing.Point(324, 437);
            this.Calc_B.Name = "Calc_B";
            this.Calc_B.Size = new System.Drawing.Size(125, 60);
            this.Calc_B.TabIndex = 8;
            this.Calc_B.Text = "Рас&чет";
            this.Calc_B.UseVisualStyleBackColor = true;
            this.Calc_B.Click += new System.EventHandler(this.Calc_B_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 512);
            this.Controls.Add(this.Calc_B);
            this.Controls.Add(this.Res_TB);
            this.Controls.Add(this.Res_L);
            this.Controls.Add(this.matrZ_DGV);
            this.Controls.Add(this.matrZ_L);
            this.Controls.Add(this.masY_TB);
            this.Controls.Add(this.masY_L);
            this.Controls.Add(this.masX_TB);
            this.Controls.Add(this.masX_L);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.matrZ_DGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label masX_L;
        private System.Windows.Forms.TextBox masX_TB;
        private System.Windows.Forms.Label masY_L;
        private System.Windows.Forms.TextBox masY_TB;
        private System.Windows.Forms.Label matrZ_L;
        private System.Windows.Forms.DataGridView matrZ_DGV;
        private System.Windows.Forms.Label Res_L;
        private System.Windows.Forms.TextBox Res_TB;
        private System.Windows.Forms.Button Calc_B;
    }
}

