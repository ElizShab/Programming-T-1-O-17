namespace файлы
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
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Save_B = new System.Windows.Forms.Button();
            this.Autor_L = new System.Windows.Forms.Label();
            this.Autor_TB = new System.Windows.Forms.TextBox();
            this.Year_L = new System.Windows.Forms.Label();
            this.Year_NUD = new System.Windows.Forms.NumericUpDown();
            this.Load_B = new System.Windows.Forms.Button();
            this.BooksLoad_L = new System.Windows.Forms.Label();
            this.BooksLoad_DGV = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Autorbooks_DGV = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Autorbooks_L = new System.Windows.Forms.Label();
            this.Rres_L = new System.Windows.Forms.Label();
            this.Pres_TB = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Count_NUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BooksSave_DGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Year_NUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BooksLoad_DGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Autorbooks_DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // Count_L
            // 
            this.Count_L.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Count_L.AutoSize = true;
            this.Count_L.Location = new System.Drawing.Point(12, 19);
            this.Count_L.Name = "Count_L";
            this.Count_L.Size = new System.Drawing.Size(92, 13);
            this.Count_L.TabIndex = 0;
            this.Count_L.Text = "Количество &книг";
            // 
            // Count_NUD
            // 
            this.Count_NUD.Location = new System.Drawing.Point(110, 12);
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
            this.BooksSave_L.Location = new System.Drawing.Point(12, 117);
            this.BooksSave_L.Name = "BooksSave_L";
            this.BooksSave_L.Size = new System.Drawing.Size(130, 13);
            this.BooksSave_L.TabIndex = 2;
            this.BooksSave_L.Text = "Спи&сок книг для записи";
            // 
            // BooksSave_DGV
            // 
            this.BooksSave_DGV.AllowUserToAddRows = false;
            this.BooksSave_DGV.AllowUserToDeleteRows = false;
            this.BooksSave_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BooksSave_DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.BooksSave_DGV.Location = new System.Drawing.Point(148, 64);
            this.BooksSave_DGV.Name = "BooksSave_DGV";
            this.BooksSave_DGV.RowHeadersVisible = false;
            this.BooksSave_DGV.Size = new System.Drawing.Size(405, 168);
            this.BooksSave_DGV.TabIndex = 3;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Название";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Автор";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Количество экземпляров";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Год издания";
            this.Column4.Name = "Column4";
            // 
            // Save_B
            // 
            this.Save_B.Location = new System.Drawing.Point(579, 93);
            this.Save_B.Name = "Save_B";
            this.Save_B.Size = new System.Drawing.Size(90, 37);
            this.Save_B.TabIndex = 4;
            this.Save_B.Text = "Записат&ь";
            this.Save_B.UseVisualStyleBackColor = true;
            this.Save_B.Click += new System.EventHandler(this.Save_B_Click);
            // 
            // Autor_L
            // 
            this.Autor_L.AutoSize = true;
            this.Autor_L.Location = new System.Drawing.Point(107, 340);
            this.Autor_L.Name = "Autor_L";
            this.Autor_L.Size = new System.Drawing.Size(37, 13);
            this.Autor_L.TabIndex = 5;
            this.Autor_L.Text = "&Автор";
            this.Autor_L.Click += new System.EventHandler(this.Autor_L_Click);
            // 
            // Autor_TB
            // 
            this.Autor_TB.Location = new System.Drawing.Point(150, 333);
            this.Autor_TB.Name = "Autor_TB";
            this.Autor_TB.Size = new System.Drawing.Size(100, 20);
            this.Autor_TB.TabIndex = 6;
            // 
            // Year_L
            // 
            this.Year_L.AutoSize = true;
            this.Year_L.Location = new System.Drawing.Point(119, 499);
            this.Year_L.Name = "Year_L";
            this.Year_L.Size = new System.Drawing.Size(25, 13);
            this.Year_L.TabIndex = 7;
            this.Year_L.Text = "Го&д";
            // 
            // Year_NUD
            // 
            this.Year_NUD.Location = new System.Drawing.Point(150, 492);
            this.Year_NUD.Maximum = new decimal(new int[] {
            2018,
            0,
            0,
            0});
            this.Year_NUD.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.Year_NUD.Name = "Year_NUD";
            this.Year_NUD.Size = new System.Drawing.Size(100, 20);
            this.Year_NUD.TabIndex = 8;
            this.Year_NUD.Value = new decimal(new int[] {
            1970,
            0,
            0,
            0});
            // 
            // Load_B
            // 
            this.Load_B.Location = new System.Drawing.Point(886, 383);
            this.Load_B.Name = "Load_B";
            this.Load_B.Size = new System.Drawing.Size(141, 47);
            this.Load_B.TabIndex = 9;
            this.Load_B.Text = "Прочитать и на&йти";
            this.Load_B.UseVisualStyleBackColor = true;
            this.Load_B.Click += new System.EventHandler(this.Load_B_Click);
            // 
            // BooksLoad_L
            // 
            this.BooksLoad_L.AutoSize = true;
            this.BooksLoad_L.Location = new System.Drawing.Point(700, 117);
            this.BooksLoad_L.Name = "BooksLoad_L";
            this.BooksLoad_L.Size = new System.Drawing.Size(127, 13);
            this.BooksLoad_L.TabIndex = 10;
            this.BooksLoad_L.Text = "С&читанный список книг";
            // 
            // BooksLoad_DGV
            // 
            this.BooksLoad_DGV.AllowUserToAddRows = false;
            this.BooksLoad_DGV.AllowUserToDeleteRows = false;
            this.BooksLoad_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BooksLoad_DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.BooksLoad_DGV.Location = new System.Drawing.Point(833, 64);
            this.BooksLoad_DGV.Name = "BooksLoad_DGV";
            this.BooksLoad_DGV.ReadOnly = true;
            this.BooksLoad_DGV.RowHeadersVisible = false;
            this.BooksLoad_DGV.Size = new System.Drawing.Size(404, 168);
            this.BooksLoad_DGV.TabIndex = 11;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Название";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Автор";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Количество экземпляров";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Год издания";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // Autorbooks_DGV
            // 
            this.Autorbooks_DGV.AllowUserToAddRows = false;
            this.Autorbooks_DGV.AllowUserToDeleteRows = false;
            this.Autorbooks_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Autorbooks_DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.Autorbooks_DGV.Location = new System.Drawing.Point(438, 280);
            this.Autorbooks_DGV.Name = "Autorbooks_DGV";
            this.Autorbooks_DGV.ReadOnly = true;
            this.Autorbooks_DGV.RowHeadersVisible = false;
            this.Autorbooks_DGV.Size = new System.Drawing.Size(406, 163);
            this.Autorbooks_DGV.TabIndex = 13;
            this.Autorbooks_DGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Autorbooks_DGV_CellContentClick);
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
            // Autorbooks_L
            // 
            this.Autorbooks_L.AutoSize = true;
            this.Autorbooks_L.Location = new System.Drawing.Point(343, 340);
            this.Autorbooks_L.Name = "Autorbooks_L";
            this.Autorbooks_L.Size = new System.Drawing.Size(89, 13);
            this.Autorbooks_L.TabIndex = 12;
            this.Autorbooks_L.Text = "Книги по автор&у";
            // 
            // Rres_L
            // 
            this.Rres_L.AutoSize = true;
            this.Rres_L.Location = new System.Drawing.Point(334, 499);
            this.Rres_L.Name = "Rres_L";
            this.Rres_L.Size = new System.Drawing.Size(186, 13);
            this.Rres_L.TabIndex = 14;
            this.Rres_L.Text = "Число экземпляров за данн&ый год";
            // 
            // Pres_TB
            // 
            this.Pres_TB.Location = new System.Drawing.Point(526, 492);
            this.Pres_TB.Name = "Pres_TB";
            this.Pres_TB.ReadOnly = true;
            this.Pres_TB.Size = new System.Drawing.Size(100, 20);
            this.Pres_TB.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1249, 604);
            this.Controls.Add(this.Pres_TB);
            this.Controls.Add(this.Rres_L);
            this.Controls.Add(this.Autorbooks_L);
            this.Controls.Add(this.Autorbooks_DGV);
            this.Controls.Add(this.BooksLoad_DGV);
            this.Controls.Add(this.BooksLoad_L);
            this.Controls.Add(this.Load_B);
            this.Controls.Add(this.Year_NUD);
            this.Controls.Add(this.Year_L);
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
            ((System.ComponentModel.ISupportInitialize)(this.Year_NUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BooksLoad_DGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Autorbooks_DGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Count_L;
        private System.Windows.Forms.NumericUpDown Count_NUD;
        private System.Windows.Forms.Label BooksSave_L;
        private System.Windows.Forms.DataGridView BooksSave_DGV;
        private System.Windows.Forms.Button Save_B;
        private System.Windows.Forms.Label Autor_L;
        private System.Windows.Forms.TextBox Autor_TB;
        private System.Windows.Forms.Label Year_L;
        private System.Windows.Forms.NumericUpDown Year_NUD;
        private System.Windows.Forms.Button Load_B;
        private System.Windows.Forms.Label BooksLoad_L;
        private System.Windows.Forms.DataGridView BooksLoad_DGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridView Autorbooks_DGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.Label Autorbooks_L;
        private System.Windows.Forms.Label Rres_L;
        private System.Windows.Forms.TextBox Pres_TB;
    }
}

