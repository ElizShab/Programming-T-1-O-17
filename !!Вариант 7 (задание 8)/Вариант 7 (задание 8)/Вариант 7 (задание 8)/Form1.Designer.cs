namespace Вариант_7__задание_8_
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
            this.Count_L = new System.Windows.Forms.Label();
            this.Count_NUD = new System.Windows.Forms.NumericUpDown();
            this.BooksSave_L = new System.Windows.Forms.Label();
            this.BooksSave_DGV = new System.Windows.Forms.DataGridView();
            this.Save_B = new System.Windows.Forms.Button();
            this.Autor_L = new System.Windows.Forms.Label();
            this.Autor_TB = new System.Windows.Forms.TextBox();
            this.BooksLoad_L = new System.Windows.Forms.Label();
            this.BooksLoad_DGV = new System.Windows.Forms.DataGridView();
            this.FindeBooks_L = new System.Windows.Forms.Label();
            this.FindeBooks_DGV = new System.Windows.Forms.DataGridView();
            this.Year_L = new System.Windows.Forms.Label();
            this.Year_NUD = new System.Windows.Forms.NumericUpDown();
            this.CountFinde_L = new System.Windows.Forms.Label();
            this.CountFinde_TB = new System.Windows.Forms.TextBox();
            this.Load_B = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Count_NUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BooksSave_DGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BooksLoad_DGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FindeBooks_DGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Year_NUD)).BeginInit();
            this.SuspendLayout();
            // 
            // Count_L
            // 
            this.Count_L.AutoSize = true;
            this.Count_L.Location = new System.Drawing.Point(12, 24);
            this.Count_L.Name = "Count_L";
            this.Count_L.Size = new System.Drawing.Size(86, 13);
            this.Count_L.TabIndex = 0;
            this.Count_L.Text = "Количесто к&ниг";
            // 
            // Count_NUD
            // 
            this.Count_NUD.Location = new System.Drawing.Point(100, 18);
            this.Count_NUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Count_NUD.Name = "Count_NUD";
            this.Count_NUD.Size = new System.Drawing.Size(120, 20);
            this.Count_NUD.TabIndex = 1;
            this.Count_NUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Count_NUD.ValueChanged += new System.EventHandler(this.Count_NUD_ValueChanged);
            // 
            // BooksSave_L
            // 
            this.BooksSave_L.AutoSize = true;
            this.BooksSave_L.Location = new System.Drawing.Point(12, 61);
            this.BooksSave_L.Name = "BooksSave_L";
            this.BooksSave_L.Size = new System.Drawing.Size(130, 13);
            this.BooksSave_L.TabIndex = 2;
            this.BooksSave_L.Text = "Список книг для &записи";
            // 
            // BooksSave_DGV
            // 
            this.BooksSave_DGV.AllowUserToAddRows = false;
            this.BooksSave_DGV.AllowUserToDeleteRows = false;
            this.BooksSave_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BooksSave_DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.BooksSave_DGV.Location = new System.Drawing.Point(15, 77);
            this.BooksSave_DGV.Name = "BooksSave_DGV";
            this.BooksSave_DGV.RowHeadersVisible = false;
            this.BooksSave_DGV.Size = new System.Drawing.Size(405, 133);
            this.BooksSave_DGV.TabIndex = 3;
            // 
            // Save_B
            // 
            this.Save_B.Location = new System.Drawing.Point(59, 264);
            this.Save_B.Name = "Save_B";
            this.Save_B.Size = new System.Drawing.Size(135, 56);
            this.Save_B.TabIndex = 4;
            this.Save_B.Text = "З&аписать";
            this.Save_B.UseVisualStyleBackColor = true;
            this.Save_B.Click += new System.EventHandler(this.Save_B_Click);
            // 
            // Autor_L
            // 
            this.Autor_L.AutoSize = true;
            this.Autor_L.Location = new System.Drawing.Point(401, 232);
            this.Autor_L.Name = "Autor_L";
            this.Autor_L.Size = new System.Drawing.Size(90, 13);
            this.Autor_L.TabIndex = 5;
            this.Autor_L.Text = "Заданный а&втор";
            // 
            // Autor_TB
            // 
            this.Autor_TB.Location = new System.Drawing.Point(497, 225);
            this.Autor_TB.Name = "Autor_TB";
            this.Autor_TB.Size = new System.Drawing.Size(123, 20);
            this.Autor_TB.TabIndex = 6;
            // 
            // BooksLoad_L
            // 
            this.BooksLoad_L.AutoSize = true;
            this.BooksLoad_L.Location = new System.Drawing.Point(458, 61);
            this.BooksLoad_L.Name = "BooksLoad_L";
            this.BooksLoad_L.Size = new System.Drawing.Size(127, 13);
            this.BooksLoad_L.TabIndex = 7;
            this.BooksLoad_L.Text = "С&читанный список книг";
            // 
            // BooksLoad_DGV
            // 
            this.BooksLoad_DGV.AllowUserToAddRows = false;
            this.BooksLoad_DGV.AllowUserToDeleteRows = false;
            this.BooksLoad_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BooksLoad_DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.BooksLoad_DGV.Location = new System.Drawing.Point(449, 77);
            this.BooksLoad_DGV.Name = "BooksLoad_DGV";
            this.BooksLoad_DGV.ReadOnly = true;
            this.BooksLoad_DGV.RowHeadersVisible = false;
            this.BooksLoad_DGV.Size = new System.Drawing.Size(405, 133);
            this.BooksLoad_DGV.TabIndex = 8;
            // 
            // FindeBooks_L
            // 
            this.FindeBooks_L.AutoSize = true;
            this.FindeBooks_L.Location = new System.Drawing.Point(326, 264);
            this.FindeBooks_L.Name = "FindeBooks_L";
            this.FindeBooks_L.Size = new System.Drawing.Size(97, 13);
            this.FindeBooks_L.TabIndex = 9;
            this.FindeBooks_L.Text = "На&йденные книги";
            // 
            // FindeBooks_DGV
            // 
            this.FindeBooks_DGV.AllowUserToAddRows = false;
            this.FindeBooks_DGV.AllowUserToDeleteRows = false;
            this.FindeBooks_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FindeBooks_DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.FindeBooks_DGV.Location = new System.Drawing.Point(329, 287);
            this.FindeBooks_DGV.Name = "FindeBooks_DGV";
            this.FindeBooks_DGV.ReadOnly = true;
            this.FindeBooks_DGV.RowHeadersVisible = false;
            this.FindeBooks_DGV.Size = new System.Drawing.Size(405, 122);
            this.FindeBooks_DGV.TabIndex = 10;
            // 
            // Year_L
            // 
            this.Year_L.AutoSize = true;
            this.Year_L.Location = new System.Drawing.Point(85, 443);
            this.Year_L.Name = "Year_L";
            this.Year_L.Size = new System.Drawing.Size(78, 13);
            this.Year_L.TabIndex = 11;
            this.Year_L.Text = "Заданный &год";
            // 
            // Year_NUD
            // 
            this.Year_NUD.Location = new System.Drawing.Point(169, 436);
            this.Year_NUD.Maximum = new decimal(new int[] {
            2018,
            0,
            0,
            0});
            this.Year_NUD.Minimum = new decimal(new int[] {
            1980,
            0,
            0,
            0});
            this.Year_NUD.Name = "Year_NUD";
            this.Year_NUD.Size = new System.Drawing.Size(150, 20);
            this.Year_NUD.TabIndex = 12;
            this.Year_NUD.Value = new decimal(new int[] {
            1980,
            0,
            0,
            0});
            // 
            // CountFinde_L
            // 
            this.CountFinde_L.AutoSize = true;
            this.CountFinde_L.Location = new System.Drawing.Point(352, 443);
            this.CountFinde_L.Name = "CountFinde_L";
            this.CountFinde_L.Size = new System.Drawing.Size(219, 13);
            this.CountFinde_L.TabIndex = 13;
            this.CountFinde_L.Text = "Количество &экземпляров за заданый год";
            // 
            // CountFinde_TB
            // 
            this.CountFinde_TB.Location = new System.Drawing.Point(577, 436);
            this.CountFinde_TB.Name = "CountFinde_TB";
            this.CountFinde_TB.ReadOnly = true;
            this.CountFinde_TB.Size = new System.Drawing.Size(100, 20);
            this.CountFinde_TB.TabIndex = 14;
            // 
            // Load_B
            // 
            this.Load_B.Location = new System.Drawing.Point(59, 339);
            this.Load_B.Name = "Load_B";
            this.Load_B.Size = new System.Drawing.Size(135, 52);
            this.Load_B.TabIndex = 15;
            this.Load_B.Text = "Прочитат&ь и найти";
            this.Load_B.UseVisualStyleBackColor = true;
            this.Load_B.Click += new System.EventHandler(this.Load_B_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Название";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Автор";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Количество экземпляров";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Год издания";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Название";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Автор";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Количество экземпляров";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Год издания";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Название";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Автор";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Количество экземпляров";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Год издания";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 495);
            this.Controls.Add(this.Load_B);
            this.Controls.Add(this.CountFinde_TB);
            this.Controls.Add(this.CountFinde_L);
            this.Controls.Add(this.Year_NUD);
            this.Controls.Add(this.Year_L);
            this.Controls.Add(this.FindeBooks_DGV);
            this.Controls.Add(this.FindeBooks_L);
            this.Controls.Add(this.BooksLoad_DGV);
            this.Controls.Add(this.BooksLoad_L);
            this.Controls.Add(this.Autor_TB);
            this.Controls.Add(this.Autor_L);
            this.Controls.Add(this.Save_B);
            this.Controls.Add(this.BooksSave_DGV);
            this.Controls.Add(this.BooksSave_L);
            this.Controls.Add(this.Count_NUD);
            this.Controls.Add(this.Count_L);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Count_NUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BooksSave_DGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BooksLoad_DGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FindeBooks_DGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Year_NUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Count_L;
        private System.Windows.Forms.NumericUpDown Count_NUD;
        private System.Windows.Forms.Label BooksSave_L;
        private System.Windows.Forms.DataGridView BooksSave_DGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button Save_B;
        private System.Windows.Forms.Label Autor_L;
        private System.Windows.Forms.TextBox Autor_TB;
        private System.Windows.Forms.Label BooksLoad_L;
        private System.Windows.Forms.DataGridView BooksLoad_DGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.Label FindeBooks_L;
        private System.Windows.Forms.DataGridView FindeBooks_DGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label Year_L;
        private System.Windows.Forms.NumericUpDown Year_NUD;
        private System.Windows.Forms.Label CountFinde_L;
        private System.Windows.Forms.TextBox CountFinde_TB;
        private System.Windows.Forms.Button Load_B;
    }
}

