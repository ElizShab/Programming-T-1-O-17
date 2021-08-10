namespace Задание_8_Вариант_17
{
    partial class Groups_F
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Name_TB = new System.Windows.Forms.TextBox();
            this.Starosta_TB = new System.Windows.Forms.TextBox();
            this.YearP_TB = new System.Windows.Forms.TextBox();
            this.ColvoS_TB = new System.Windows.Forms.TextBox();
            this.OK_B = new System.Windows.Forms.Button();
            this.Cancel_B = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "&Наименование:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(121, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Староста:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Год поступления:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Количество студентов в группе";
            // 
            // Name_TB
            // 
            this.Name_TB.Location = new System.Drawing.Point(184, 39);
            this.Name_TB.Name = "Name_TB";
            this.Name_TB.Size = new System.Drawing.Size(100, 20);
            this.Name_TB.TabIndex = 4;
            // 
            // Starosta_TB
            // 
            this.Starosta_TB.Location = new System.Drawing.Point(184, 79);
            this.Starosta_TB.Name = "Starosta_TB";
            this.Starosta_TB.Size = new System.Drawing.Size(100, 20);
            this.Starosta_TB.TabIndex = 5;
            // 
            // YearP_TB
            // 
            this.YearP_TB.Location = new System.Drawing.Point(184, 119);
            this.YearP_TB.Name = "YearP_TB";
            this.YearP_TB.Size = new System.Drawing.Size(100, 20);
            this.YearP_TB.TabIndex = 6;
            // 
            // ColvoS_TB
            // 
            this.ColvoS_TB.Location = new System.Drawing.Point(184, 161);
            this.ColvoS_TB.Name = "ColvoS_TB";
            this.ColvoS_TB.Size = new System.Drawing.Size(100, 20);
            this.ColvoS_TB.TabIndex = 7;
            // 
            // OK_B
            // 
            this.OK_B.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OK_B.Location = new System.Drawing.Point(45, 221);
            this.OK_B.Name = "OK_B";
            this.OK_B.Size = new System.Drawing.Size(75, 23);
            this.OK_B.TabIndex = 8;
            this.OK_B.Text = "&ОК";
            this.OK_B.UseVisualStyleBackColor = true;
            // 
            // Cancel_B
            // 
            this.Cancel_B.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel_B.Location = new System.Drawing.Point(209, 221);
            this.Cancel_B.Name = "Cancel_B";
            this.Cancel_B.Size = new System.Drawing.Size(75, 23);
            this.Cancel_B.TabIndex = 9;
            this.Cancel_B.Text = "Отмен&а";
            this.Cancel_B.UseVisualStyleBackColor = true;
            // 
            // Groups_F
            // 
            this.AcceptButton = this.OK_B;
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancel_B;
            this.ClientSize = new System.Drawing.Size(317, 256);
            this.Controls.Add(this.Cancel_B);
            this.Controls.Add(this.OK_B);
            this.Controls.Add(this.ColvoS_TB);
            this.Controls.Add(this.YearP_TB);
            this.Controls.Add(this.Starosta_TB);
            this.Controls.Add(this.Name_TB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Groups_F";
            this.Text = "Группа";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Groups_F_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox Name_TB;
        public System.Windows.Forms.TextBox Starosta_TB;
        public System.Windows.Forms.TextBox YearP_TB;
        public System.Windows.Forms.TextBox ColvoS_TB;
        private System.Windows.Forms.Button OK_B;
        private System.Windows.Forms.Button Cancel_B;
    }
}