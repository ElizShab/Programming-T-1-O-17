namespace Задание_7_Вариант_17
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
            this.masA_L = new System.Windows.Forms.Label();
            this.masB_L = new System.Windows.Forms.Label();
            this.n_L = new System.Windows.Forms.Label();
            this.n_NUD = new System.Windows.Forms.NumericUpDown();
            this.Result_L = new System.Windows.Forms.Label();
            this.Result_TB = new System.Windows.Forms.TextBox();
            this.Calc_B = new System.Windows.Forms.Button();
            this.masA_DGV = new System.Windows.Forms.DataGridView();
            this.masB_DGV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.n_NUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masA_DGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masB_DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // masA_L
            // 
            this.masA_L.AutoSize = true;
            this.masA_L.Location = new System.Drawing.Point(12, 30);
            this.masA_L.Name = "masA_L";
            this.masA_L.Size = new System.Drawing.Size(56, 13);
            this.masA_L.TabIndex = 0;
            this.masA_L.Text = "Массив &A";
            // 
            // masB_L
            // 
            this.masB_L.AutoSize = true;
            this.masB_L.Location = new System.Drawing.Point(12, 118);
            this.masB_L.Name = "masB_L";
            this.masB_L.Size = new System.Drawing.Size(56, 13);
            this.masB_L.TabIndex = 1;
            this.masB_L.Text = "Массив &B";
            // 
            // n_L
            // 
            this.n_L.AutoSize = true;
            this.n_L.Location = new System.Drawing.Point(48, 212);
            this.n_L.Name = "n_L";
            this.n_L.Size = new System.Drawing.Size(99, 13);
            this.n_L.TabIndex = 4;
            this.n_L.Text = "Размер массиво&в";
            // 
            // n_NUD
            // 
            this.n_NUD.Location = new System.Drawing.Point(153, 208);
            this.n_NUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.n_NUD.Name = "n_NUD";
            this.n_NUD.Size = new System.Drawing.Size(120, 20);
            this.n_NUD.TabIndex = 5;
            this.n_NUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.n_NUD.ValueChanged += new System.EventHandler(this.n_NUD_ValueChanged);
            // 
            // Result_L
            // 
            this.Result_L.AutoSize = true;
            this.Result_L.Location = new System.Drawing.Point(357, 215);
            this.Result_L.Name = "Result_L";
            this.Result_L.Size = new System.Drawing.Size(59, 13);
            this.Result_L.TabIndex = 6;
            this.Result_L.Text = "Ре&зультат";
            // 
            // Result_TB
            // 
            this.Result_TB.Location = new System.Drawing.Point(422, 212);
            this.Result_TB.Name = "Result_TB";
            this.Result_TB.ReadOnly = true;
            this.Result_TB.Size = new System.Drawing.Size(138, 20);
            this.Result_TB.TabIndex = 7;
            // 
            // Calc_B
            // 
            this.Calc_B.Location = new System.Drawing.Point(277, 246);
            this.Calc_B.Name = "Calc_B";
            this.Calc_B.Size = new System.Drawing.Size(75, 23);
            this.Calc_B.TabIndex = 8;
            this.Calc_B.Text = "Расч&ёт";
            this.Calc_B.UseVisualStyleBackColor = true;
            this.Calc_B.Click += new System.EventHandler(this.Calc_B_Click);
            // 
            // masA_DGV
            // 
            this.masA_DGV.AllowUserToAddRows = false;
            this.masA_DGV.AllowUserToDeleteRows = false;
            this.masA_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.masA_DGV.ColumnHeadersVisible = false;
            this.masA_DGV.Location = new System.Drawing.Point(74, 30);
            this.masA_DGV.Name = "masA_DGV";
            this.masA_DGV.RowHeadersVisible = false;
            this.masA_DGV.Size = new System.Drawing.Size(522, 63);
            this.masA_DGV.TabIndex = 9;
            // 
            // masB_DGV
            // 
            this.masB_DGV.AllowUserToAddRows = false;
            this.masB_DGV.AllowUserToDeleteRows = false;
            this.masB_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.masB_DGV.ColumnHeadersVisible = false;
            this.masB_DGV.Location = new System.Drawing.Point(74, 118);
            this.masB_DGV.Name = "masB_DGV";
            this.masB_DGV.RowHeadersVisible = false;
            this.masB_DGV.Size = new System.Drawing.Size(522, 63);
            this.masB_DGV.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 279);
            this.Controls.Add(this.masB_DGV);
            this.Controls.Add(this.masA_DGV);
            this.Controls.Add(this.Calc_B);
            this.Controls.Add(this.Result_TB);
            this.Controls.Add(this.Result_L);
            this.Controls.Add(this.n_NUD);
            this.Controls.Add(this.n_L);
            this.Controls.Add(this.masB_L);
            this.Controls.Add(this.masA_L);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.n_NUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masA_DGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masB_DGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label masA_L;
        private System.Windows.Forms.Label masB_L;
        private System.Windows.Forms.Label n_L;
        private System.Windows.Forms.NumericUpDown n_NUD;
        private System.Windows.Forms.Label Result_L;
        private System.Windows.Forms.TextBox Result_TB;
        private System.Windows.Forms.Button Calc_B;
        private System.Windows.Forms.DataGridView masA_DGV;
        private System.Windows.Forms.DataGridView masB_DGV;
    }
}

