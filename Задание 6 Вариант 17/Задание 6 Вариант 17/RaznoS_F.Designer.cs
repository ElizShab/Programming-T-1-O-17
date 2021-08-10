namespace Задание_6_Вариант_17
{
    partial class RaznoS_F
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
            this.OK_B = new System.Windows.Forms.Button();
            this.Cancel_B = new System.Windows.Forms.Button();
            this.A_L = new System.Windows.Forms.Label();
            this.B_L = new System.Windows.Forms.Label();
            this.C_L = new System.Windows.Forms.Label();
            this.A_TB = new System.Windows.Forms.TextBox();
            this.B_TB = new System.Windows.Forms.TextBox();
            this.C_TB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // OK_B
            // 
            this.OK_B.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OK_B.Location = new System.Drawing.Point(32, 140);
            this.OK_B.Name = "OK_B";
            this.OK_B.Size = new System.Drawing.Size(75, 23);
            this.OK_B.TabIndex = 0;
            this.OK_B.Text = "О&к";
            this.OK_B.UseVisualStyleBackColor = true;
            // 
            // Cancel_B
            // 
            this.Cancel_B.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel_B.Location = new System.Drawing.Point(176, 140);
            this.Cancel_B.Name = "Cancel_B";
            this.Cancel_B.Size = new System.Drawing.Size(75, 23);
            this.Cancel_B.TabIndex = 1;
            this.Cancel_B.Text = "От&мена";
            this.Cancel_B.UseVisualStyleBackColor = true;
            // 
            // A_L
            // 
            this.A_L.AutoSize = true;
            this.A_L.Location = new System.Drawing.Point(29, 20);
            this.A_L.Name = "A_L";
            this.A_L.Size = new System.Drawing.Size(89, 13);
            this.A_L.TabIndex = 2;
            this.A_L.Text = "Первая сторона";
            // 
            // B_L
            // 
            this.B_L.AutoSize = true;
            this.B_L.Location = new System.Drawing.Point(31, 64);
            this.B_L.Name = "B_L";
            this.B_L.Size = new System.Drawing.Size(87, 13);
            this.B_L.TabIndex = 3;
            this.B_L.Text = "Вторая сторона";
            // 
            // C_L
            // 
            this.C_L.AutoSize = true;
            this.C_L.Location = new System.Drawing.Point(31, 100);
            this.C_L.Name = "C_L";
            this.C_L.Size = new System.Drawing.Size(87, 13);
            this.C_L.TabIndex = 4;
            this.C_L.Text = "Третья сторона";
            // 
            // A_TB
            // 
            this.A_TB.Location = new System.Drawing.Point(124, 17);
            this.A_TB.Name = "A_TB";
            this.A_TB.Size = new System.Drawing.Size(100, 20);
            this.A_TB.TabIndex = 5;
            // 
            // B_TB
            // 
            this.B_TB.Location = new System.Drawing.Point(124, 57);
            this.B_TB.Name = "B_TB";
            this.B_TB.Size = new System.Drawing.Size(100, 20);
            this.B_TB.TabIndex = 6;
            // 
            // C_TB
            // 
            this.C_TB.Location = new System.Drawing.Point(124, 93);
            this.C_TB.Name = "C_TB";
            this.C_TB.Size = new System.Drawing.Size(100, 20);
            this.C_TB.TabIndex = 7;
            // 
            // RaznoS_F
            // 
            this.AcceptButton = this.OK_B;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancel_B;
            this.ClientSize = new System.Drawing.Size(304, 195);
            this.Controls.Add(this.C_TB);
            this.Controls.Add(this.B_TB);
            this.Controls.Add(this.A_TB);
            this.Controls.Add(this.C_L);
            this.Controls.Add(this.B_L);
            this.Controls.Add(this.A_L);
            this.Controls.Add(this.Cancel_B);
            this.Controls.Add(this.OK_B);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RaznoS_F";
            this.ShowInTaskbar = false;
            this.Text = "Периметр разностороннего треугольника";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RaznoS_F_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OK_B;
        private System.Windows.Forms.Button Cancel_B;
        private System.Windows.Forms.Label A_L;
        private System.Windows.Forms.Label B_L;
        private System.Windows.Forms.Label C_L;
        public System.Windows.Forms.TextBox A_TB;
        public System.Windows.Forms.TextBox B_TB;
        public System.Windows.Forms.TextBox C_TB;
    }
}