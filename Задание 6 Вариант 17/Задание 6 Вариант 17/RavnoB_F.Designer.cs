namespace Задание_6_Вариант_17
{
    partial class RavnoB_F
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
            this.A_L = new System.Windows.Forms.Label();
            this.B_L = new System.Windows.Forms.Label();
            this.A_TB = new System.Windows.Forms.TextBox();
            this.B_TB = new System.Windows.Forms.TextBox();
            this.OK_B = new System.Windows.Forms.Button();
            this.Cancel_B = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // A_L
            // 
            this.A_L.AutoSize = true;
            this.A_L.Location = new System.Drawing.Point(61, 32);
            this.A_L.Name = "A_L";
            this.A_L.Size = new System.Drawing.Size(38, 13);
            this.A_L.TabIndex = 0;
            this.A_L.Text = "Бедр&о";
            // 
            // B_L
            // 
            this.B_L.AutoSize = true;
            this.B_L.Location = new System.Drawing.Point(12, 86);
            this.B_L.Name = "B_L";
            this.B_L.Size = new System.Drawing.Size(87, 13);
            this.B_L.TabIndex = 1;
            this.B_L.Text = "Третья сторон&а";
            // 
            // A_TB
            // 
            this.A_TB.Location = new System.Drawing.Point(105, 25);
            this.A_TB.Name = "A_TB";
            this.A_TB.Size = new System.Drawing.Size(100, 20);
            this.A_TB.TabIndex = 2;
            // 
            // B_TB
            // 
            this.B_TB.Location = new System.Drawing.Point(105, 79);
            this.B_TB.Name = "B_TB";
            this.B_TB.Size = new System.Drawing.Size(100, 20);
            this.B_TB.TabIndex = 3;
            // 
            // OK_B
            // 
            this.OK_B.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OK_B.Location = new System.Drawing.Point(43, 134);
            this.OK_B.Name = "OK_B";
            this.OK_B.Size = new System.Drawing.Size(56, 27);
            this.OK_B.TabIndex = 4;
            this.OK_B.Text = "О&к";
            this.OK_B.UseVisualStyleBackColor = true;
            // 
            // Cancel_B
            // 
            this.Cancel_B.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel_B.Location = new System.Drawing.Point(162, 138);
            this.Cancel_B.Name = "Cancel_B";
            this.Cancel_B.Size = new System.Drawing.Size(75, 23);
            this.Cancel_B.TabIndex = 5;
            this.Cancel_B.Text = "Отме&на";
            this.Cancel_B.UseVisualStyleBackColor = true;
            // 
            // RavnoB_F
            // 
            this.AcceptButton = this.OK_B;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancel_B;
            this.ClientSize = new System.Drawing.Size(285, 179);
            this.Controls.Add(this.Cancel_B);
            this.Controls.Add(this.OK_B);
            this.Controls.Add(this.B_TB);
            this.Controls.Add(this.A_TB);
            this.Controls.Add(this.B_L);
            this.Controls.Add(this.A_L);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RavnoB_F";
            this.ShowInTaskbar = false;
            this.Text = "Периметр равнобедренного треугольника";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RavnoB_F_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label A_L;
        private System.Windows.Forms.Label B_L;
        private System.Windows.Forms.Button OK_B;
        private System.Windows.Forms.Button Cancel_B;
        public System.Windows.Forms.TextBox A_TB;
        public System.Windows.Forms.TextBox B_TB;
    }
}