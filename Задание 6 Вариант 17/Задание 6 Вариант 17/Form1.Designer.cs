namespace Задание_6_Вариант_17
{
    partial class Main_F
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
            this.Spisok_L = new System.Windows.Forms.Label();
            this.Spisok_LB = new System.Windows.Forms.ListBox();
            this.Select_GB = new System.Windows.Forms.GroupBox();
            this.RaznoS_RB = new System.Windows.Forms.RadioButton();
            this.RavnoB_RB = new System.Windows.Forms.RadioButton();
            this.RavnoS_RB = new System.Windows.Forms.RadioButton();
            this.Add_B = new System.Windows.Forms.Button();
            this.Change_B = new System.Windows.Forms.Button();
            this.Del_B = new System.Windows.Forms.Button();
            this.Result_L = new System.Windows.Forms.Label();
            this.Result_TB = new System.Windows.Forms.TextBox();
            this.Select_GB.SuspendLayout();
            this.SuspendLayout();
            // 
            // Spisok_L
            // 
            this.Spisok_L.AutoSize = true;
            this.Spisok_L.Location = new System.Drawing.Point(12, 32);
            this.Spisok_L.Name = "Spisok_L";
            this.Spisok_L.Size = new System.Drawing.Size(102, 13);
            this.Spisok_L.TabIndex = 0;
            this.Spisok_L.Text = "Список элементов";
            // 
            // Spisok_LB
            // 
            this.Spisok_LB.FormattingEnabled = true;
            this.Spisok_LB.Location = new System.Drawing.Point(120, 30);
            this.Spisok_LB.Name = "Spisok_LB";
            this.Spisok_LB.Size = new System.Drawing.Size(228, 186);
            this.Spisok_LB.TabIndex = 1;
            this.Spisok_LB.SelectedIndexChanged += new System.EventHandler(this.Spisok_LB_SelectedIndexChanged);
            // 
            // Select_GB
            // 
            this.Select_GB.Controls.Add(this.RaznoS_RB);
            this.Select_GB.Controls.Add(this.RavnoB_RB);
            this.Select_GB.Controls.Add(this.RavnoS_RB);
            this.Select_GB.Location = new System.Drawing.Point(385, 12);
            this.Select_GB.Name = "Select_GB";
            this.Select_GB.Size = new System.Drawing.Size(308, 139);
            this.Select_GB.TabIndex = 2;
            this.Select_GB.TabStop = false;
            this.Select_GB.Text = "Вид добавляемого элемента:";
            // 
            // RaznoS_RB
            // 
            this.RaznoS_RB.AutoSize = true;
            this.RaznoS_RB.Location = new System.Drawing.Point(40, 111);
            this.RaznoS_RB.Name = "RaznoS_RB";
            this.RaznoS_RB.Size = new System.Drawing.Size(239, 17);
            this.RaznoS_RB.TabIndex = 2;
            this.RaznoS_RB.TabStop = true;
            this.RaznoS_RB.Text = "Периметр ра&зностороннего треугольника";
            this.RaznoS_RB.UseVisualStyleBackColor = true;
            this.RaznoS_RB.CheckedChanged += new System.EventHandler(this.RaznoS_RB_CheckedChanged);
            // 
            // RavnoB_RB
            // 
            this.RavnoB_RB.AutoSize = true;
            this.RavnoB_RB.Location = new System.Drawing.Point(40, 70);
            this.RavnoB_RB.Name = "RavnoB_RB";
            this.RavnoB_RB.Size = new System.Drawing.Size(240, 17);
            this.RavnoB_RB.TabIndex = 1;
            this.RavnoB_RB.TabStop = true;
            this.RavnoB_RB.Text = "Периметр равно&бедренного треугольника";
            this.RavnoB_RB.UseVisualStyleBackColor = true;
            this.RavnoB_RB.CheckedChanged += new System.EventHandler(this.RavnoB_RB_CheckedChanged);
            // 
            // RavnoS_RB
            // 
            this.RavnoS_RB.AutoSize = true;
            this.RavnoS_RB.Location = new System.Drawing.Point(38, 34);
            this.RavnoS_RB.Name = "RavnoS_RB";
            this.RavnoS_RB.Size = new System.Drawing.Size(239, 17);
            this.RavnoS_RB.TabIndex = 0;
            this.RavnoS_RB.TabStop = true;
            this.RavnoS_RB.Text = "Периметр равностор&оннего треугольника";
            this.RavnoS_RB.UseVisualStyleBackColor = true;
            this.RavnoS_RB.CheckedChanged += new System.EventHandler(this.RavnoS_RB_CheckedChanged);
            // 
            // Add_B
            // 
            this.Add_B.Enabled = false;
            this.Add_B.Location = new System.Drawing.Point(434, 157);
            this.Add_B.Name = "Add_B";
            this.Add_B.Size = new System.Drawing.Size(131, 59);
            this.Add_B.TabIndex = 3;
            this.Add_B.Text = "Добав&ить";
            this.Add_B.UseVisualStyleBackColor = true;
            this.Add_B.Click += new System.EventHandler(this.Add_B_Click);
            // 
            // Change_B
            // 
            this.Change_B.Enabled = false;
            this.Change_B.Location = new System.Drawing.Point(27, 245);
            this.Change_B.Name = "Change_B";
            this.Change_B.Size = new System.Drawing.Size(75, 23);
            this.Change_B.TabIndex = 4;
            this.Change_B.Text = "Изменит&ь";
            this.Change_B.UseVisualStyleBackColor = true;
            this.Change_B.Click += new System.EventHandler(this.Change_B_Click);
            // 
            // Del_B
            // 
            this.Del_B.Enabled = false;
            this.Del_B.Location = new System.Drawing.Point(175, 245);
            this.Del_B.Name = "Del_B";
            this.Del_B.Size = new System.Drawing.Size(75, 23);
            this.Del_B.TabIndex = 5;
            this.Del_B.Text = "Удали&ть";
            this.Del_B.UseVisualStyleBackColor = true;
            this.Del_B.Click += new System.EventHandler(this.Del_B_Click);
            // 
            // Result_L
            // 
            this.Result_L.AutoSize = true;
            this.Result_L.Location = new System.Drawing.Point(340, 255);
            this.Result_L.Name = "Result_L";
            this.Result_L.Size = new System.Drawing.Size(59, 13);
            this.Result_L.TabIndex = 6;
            this.Result_L.Text = "Результ&ат";
            // 
            // Result_TB
            // 
            this.Result_TB.Location = new System.Drawing.Point(405, 248);
            this.Result_TB.Name = "Result_TB";
            this.Result_TB.ReadOnly = true;
            this.Result_TB.Size = new System.Drawing.Size(222, 20);
            this.Result_TB.TabIndex = 7;
            // 
            // Main_F
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 289);
            this.Controls.Add(this.Result_TB);
            this.Controls.Add(this.Result_L);
            this.Controls.Add(this.Del_B);
            this.Controls.Add(this.Change_B);
            this.Controls.Add(this.Add_B);
            this.Controls.Add(this.Select_GB);
            this.Controls.Add(this.Spisok_LB);
            this.Controls.Add(this.Spisok_L);
            this.Name = "Main_F";
            this.Text = "Form1";
            this.Select_GB.ResumeLayout(false);
            this.Select_GB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Spisok_L;
        private System.Windows.Forms.ListBox Spisok_LB;
        private System.Windows.Forms.GroupBox Select_GB;
        private System.Windows.Forms.RadioButton RaznoS_RB;
        private System.Windows.Forms.RadioButton RavnoB_RB;
        private System.Windows.Forms.RadioButton RavnoS_RB;
        private System.Windows.Forms.Button Add_B;
        private System.Windows.Forms.Button Change_B;
        private System.Windows.Forms.Button Del_B;
        private System.Windows.Forms.Label Result_L;
        private System.Windows.Forms.TextBox Result_TB;
    }
}

