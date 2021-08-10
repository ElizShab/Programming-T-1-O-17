namespace Вариант_21__задание_9__
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
            this.CountCol_L = new System.Windows.Forms.Label();
            this.CountCol_NUD = new System.Windows.Forms.NumericUpDown();
            this.MatrA_L = new System.Windows.Forms.Label();
            this.MatrA_DGV = new System.Windows.Forms.DataGridView();
            this.Result_L = new System.Windows.Forms.Label();
            this.Save_B = new System.Windows.Forms.Button();
            this.Load_B = new System.Windows.Forms.Button();
            this.Random_B = new System.Windows.Forms.Button();
            this.Calc_B = new System.Windows.Forms.Button();
            this.SaveR_B = new System.Windows.Forms.Button();
            this.Result_TB = new System.Windows.Forms.TextBox();
            this.MatrLoad_L = new System.Windows.Forms.Label();
            this.MatrLoad_DGV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.CountCol_NUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MatrA_DGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MatrLoad_DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // CountCol_L
            // 
            this.CountCol_L.AutoSize = true;
            this.CountCol_L.Location = new System.Drawing.Point(33, 25);
            this.CountCol_L.Name = "CountCol_L";
            this.CountCol_L.Size = new System.Drawing.Size(97, 13);
            this.CountCol_L.TabIndex = 0;
            this.CountCol_L.Text = "Количество то&чек";
            // 
            // CountCol_NUD
            // 
            this.CountCol_NUD.Location = new System.Drawing.Point(136, 18);
            this.CountCol_NUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.CountCol_NUD.Name = "CountCol_NUD";
            this.CountCol_NUD.Size = new System.Drawing.Size(120, 20);
            this.CountCol_NUD.TabIndex = 1;
            this.CountCol_NUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.CountCol_NUD.ValueChanged += new System.EventHandler(this.CountCol_NUD_ValueChanged);
            // 
            // MatrA_L
            // 
            this.MatrA_L.AutoSize = true;
            this.MatrA_L.Location = new System.Drawing.Point(9, 53);
            this.MatrA_L.Name = "MatrA_L";
            this.MatrA_L.Size = new System.Drawing.Size(133, 13);
            this.MatrA_L.TabIndex = 2;
            this.MatrA_L.Text = "Ис&ходная матрица точек";
            // 
            // MatrA_DGV
            // 
            this.MatrA_DGV.AllowUserToAddRows = false;
            this.MatrA_DGV.AllowUserToDeleteRows = false;
            this.MatrA_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MatrA_DGV.ColumnHeadersVisible = false;
            this.MatrA_DGV.Location = new System.Drawing.Point(12, 69);
            this.MatrA_DGV.Name = "MatrA_DGV";
            this.MatrA_DGV.RowHeadersVisible = false;
            this.MatrA_DGV.Size = new System.Drawing.Size(264, 139);
            this.MatrA_DGV.TabIndex = 3;
            // 
            // Result_L
            // 
            this.Result_L.AutoSize = true;
            this.Result_L.Location = new System.Drawing.Point(314, 217);
            this.Result_L.Name = "Result_L";
            this.Result_L.Size = new System.Drawing.Size(59, 13);
            this.Result_L.TabIndex = 4;
            this.Result_L.Text = "Резул&ьтат";
            // 
            // Save_B
            // 
            this.Save_B.Location = new System.Drawing.Point(12, 252);
            this.Save_B.Name = "Save_B";
            this.Save_B.Size = new System.Drawing.Size(75, 23);
            this.Save_B.TabIndex = 6;
            this.Save_B.Text = "&Записать";
            this.Save_B.UseVisualStyleBackColor = true;
            this.Save_B.Click += new System.EventHandler(this.Save_B_Click);
            // 
            // Load_B
            // 
            this.Load_B.Location = new System.Drawing.Point(93, 252);
            this.Load_B.Name = "Load_B";
            this.Load_B.Size = new System.Drawing.Size(75, 23);
            this.Load_B.TabIndex = 7;
            this.Load_B.Text = "&Прочитать";
            this.Load_B.UseVisualStyleBackColor = true;
            this.Load_B.Click += new System.EventHandler(this.Load_B_Click);
            // 
            // Random_B
            // 
            this.Random_B.Location = new System.Drawing.Point(174, 252);
            this.Random_B.Name = "Random_B";
            this.Random_B.Size = new System.Drawing.Size(102, 23);
            this.Random_B.TabIndex = 8;
            this.Random_B.Text = "&Сгенерировать";
            this.Random_B.UseVisualStyleBackColor = true;
            this.Random_B.Click += new System.EventHandler(this.Random_B_Click);
            // 
            // Calc_B
            // 
            this.Calc_B.Location = new System.Drawing.Point(310, 252);
            this.Calc_B.Name = "Calc_B";
            this.Calc_B.Size = new System.Drawing.Size(75, 23);
            this.Calc_B.TabIndex = 9;
            this.Calc_B.Text = "Расч&ёт";
            this.Calc_B.UseVisualStyleBackColor = true;
            this.Calc_B.Click += new System.EventHandler(this.Calc_B_Click);
            // 
            // SaveR_B
            // 
            this.SaveR_B.Location = new System.Drawing.Point(437, 252);
            this.SaveR_B.Name = "SaveR_B";
            this.SaveR_B.Size = new System.Drawing.Size(138, 23);
            this.SaveR_B.TabIndex = 10;
            this.SaveR_B.Text = "Сохранить р&езультат";
            this.SaveR_B.UseVisualStyleBackColor = true;
            this.SaveR_B.Click += new System.EventHandler(this.SaveR_B_Click);
            // 
            // Result_TB
            // 
            this.Result_TB.Location = new System.Drawing.Point(379, 214);
            this.Result_TB.Name = "Result_TB";
            this.Result_TB.Size = new System.Drawing.Size(184, 20);
            this.Result_TB.TabIndex = 11;
            // 
            // MatrLoad_L
            // 
            this.MatrLoad_L.AutoSize = true;
            this.MatrLoad_L.Location = new System.Drawing.Point(322, 53);
            this.MatrLoad_L.Name = "MatrLoad_L";
            this.MatrLoad_L.Size = new System.Drawing.Size(106, 13);
            this.MatrLoad_L.TabIndex = 12;
            this.MatrLoad_L.Text = "Считанная матриц&а";
            // 
            // MatrLoad_DGV
            // 
            this.MatrLoad_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MatrLoad_DGV.Location = new System.Drawing.Point(325, 69);
            this.MatrLoad_DGV.Name = "MatrLoad_DGV";
            this.MatrLoad_DGV.Size = new System.Drawing.Size(264, 139);
            this.MatrLoad_DGV.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 298);
            this.Controls.Add(this.MatrLoad_DGV);
            this.Controls.Add(this.MatrLoad_L);
            this.Controls.Add(this.Result_TB);
            this.Controls.Add(this.SaveR_B);
            this.Controls.Add(this.Calc_B);
            this.Controls.Add(this.Random_B);
            this.Controls.Add(this.Load_B);
            this.Controls.Add(this.Save_B);
            this.Controls.Add(this.Result_L);
            this.Controls.Add(this.MatrA_DGV);
            this.Controls.Add(this.MatrA_L);
            this.Controls.Add(this.CountCol_NUD);
            this.Controls.Add(this.CountCol_L);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CountCol_NUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MatrA_DGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MatrLoad_DGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CountCol_L;
        private System.Windows.Forms.NumericUpDown CountCol_NUD;
        private System.Windows.Forms.Label MatrA_L;
        private System.Windows.Forms.DataGridView MatrA_DGV;
        private System.Windows.Forms.Label Result_L;
        private System.Windows.Forms.Button Save_B;
        private System.Windows.Forms.Button Load_B;
        private System.Windows.Forms.Button Random_B;
        private System.Windows.Forms.Button Calc_B;
        private System.Windows.Forms.Button SaveR_B;
        private System.Windows.Forms.TextBox Result_TB;
        private System.Windows.Forms.Label MatrLoad_L;
        private System.Windows.Forms.DataGridView MatrLoad_DGV;
    }
}

