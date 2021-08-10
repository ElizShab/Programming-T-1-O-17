namespace Задание_8_Вариант_17
{
    partial class Kafedra_F
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Name_L = new System.Windows.Forms.Label();
            this.Zavedushiy_L = new System.Windows.Forms.Label();
            this.YearO_L = new System.Windows.Forms.Label();
            this.Name_TB = new System.Windows.Forms.TextBox();
            this.Zavedushiy_TB = new System.Windows.Forms.TextBox();
            this.YearO_TB = new System.Windows.Forms.TextBox();
            this.OK_B = new System.Windows.Forms.Button();
            this.Cancel_B = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Name_L
            // 
            this.Name_L.AutoSize = true;
            this.Name_L.Location = new System.Drawing.Point(49, 43);
            this.Name_L.Name = "Name_L";
            this.Name_L.Size = new System.Drawing.Size(83, 13);
            this.Name_L.TabIndex = 0;
            this.Name_L.Text = "Наименовани&е";
            // 
            // Zavedushiy_L
            // 
            this.Zavedushiy_L.AutoSize = true;
            this.Zavedushiy_L.Location = new System.Drawing.Point(59, 87);
            this.Zavedushiy_L.Name = "Zavedushiy_L";
            this.Zavedushiy_L.Size = new System.Drawing.Size(72, 13);
            this.Zavedushiy_L.TabIndex = 1;
            this.Zavedushiy_L.Text = "Заведую&щий";
            // 
            // YearO_L
            // 
            this.YearO_L.AutoSize = true;
            this.YearO_L.Location = new System.Drawing.Point(49, 142);
            this.YearO_L.Name = "YearO_L";
            this.YearO_L.Size = new System.Drawing.Size(82, 13);
            this.YearO_L.TabIndex = 2;
            this.YearO_L.Text = "Год &основания";
            // 
            // Name_TB
            // 
            this.Name_TB.Location = new System.Drawing.Point(137, 36);
            this.Name_TB.Name = "Name_TB";
            this.Name_TB.Size = new System.Drawing.Size(100, 20);
            this.Name_TB.TabIndex = 3;
            // 
            // Zavedushiy_TB
            // 
            this.Zavedushiy_TB.Location = new System.Drawing.Point(137, 80);
            this.Zavedushiy_TB.Name = "Zavedushiy_TB";
            this.Zavedushiy_TB.Size = new System.Drawing.Size(100, 20);
            this.Zavedushiy_TB.TabIndex = 4;
            // 
            // YearO_TB
            // 
            this.YearO_TB.Location = new System.Drawing.Point(137, 135);
            this.YearO_TB.Name = "YearO_TB";
            this.YearO_TB.Size = new System.Drawing.Size(100, 20);
            this.YearO_TB.TabIndex = 5;
            // 
            // OK_B
            // 
            this.OK_B.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OK_B.Location = new System.Drawing.Point(41, 205);
            this.OK_B.Name = "OK_B";
            this.OK_B.Size = new System.Drawing.Size(75, 23);
            this.OK_B.TabIndex = 8;
            this.OK_B.Text = "О&к";
            this.OK_B.UseVisualStyleBackColor = true;
            // 
            // Cancel_B
            // 
            this.Cancel_B.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel_B.Location = new System.Drawing.Point(186, 205);
            this.Cancel_B.Name = "Cancel_B";
            this.Cancel_B.Size = new System.Drawing.Size(75, 23);
            this.Cancel_B.TabIndex = 9;
            this.Cancel_B.Text = "Отмен&а";
            this.Cancel_B.UseVisualStyleBackColor = true;
            // 
            // Kafedra_F
            // 
            this.AcceptButton = this.OK_B;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancel_B;
            this.ClientSize = new System.Drawing.Size(319, 268);
            this.Controls.Add(this.Cancel_B);
            this.Controls.Add(this.OK_B);
            this.Controls.Add(this.YearO_TB);
            this.Controls.Add(this.Zavedushiy_TB);
            this.Controls.Add(this.Name_TB);
            this.Controls.Add(this.YearO_L);
            this.Controls.Add(this.Zavedushiy_L);
            this.Controls.Add(this.Name_L);
            this.Name = "Kafedra_F";
            this.Text = "Кафедра";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Kafedra_F_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Name_L;
        private System.Windows.Forms.Label Zavedushiy_L;
        private System.Windows.Forms.Label YearO_L;
        private System.Windows.Forms.Button OK_B;
        private System.Windows.Forms.Button Cancel_B;
        public System.Windows.Forms.TextBox Name_TB;
        public System.Windows.Forms.TextBox Zavedushiy_TB;
        public System.Windows.Forms.TextBox YearO_TB;
    }
}