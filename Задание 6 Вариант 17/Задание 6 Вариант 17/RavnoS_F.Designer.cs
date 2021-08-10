namespace Задание_6_Вариант_17
{
    partial class RavnoS_F
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
            this.A_TB = new System.Windows.Forms.TextBox();
            this.OK_B = new System.Windows.Forms.Button();
            this.Cancel_B = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // A_L
            // 
            this.A_L.AutoSize = true;
            this.A_L.Location = new System.Drawing.Point(44, 49);
            this.A_L.Name = "A_L";
            this.A_L.Size = new System.Drawing.Size(49, 13);
            this.A_L.TabIndex = 0;
            this.A_L.Text = "Сторо&на";
            // 
            // A_TB
            // 
            this.A_TB.Location = new System.Drawing.Point(99, 42);
            this.A_TB.Name = "A_TB";
            this.A_TB.Size = new System.Drawing.Size(100, 20);
            this.A_TB.TabIndex = 1;
            // 
            // OK_B
            // 
            this.OK_B.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OK_B.Location = new System.Drawing.Point(27, 98);
            this.OK_B.Name = "OK_B";
            this.OK_B.Size = new System.Drawing.Size(75, 23);
            this.OK_B.TabIndex = 2;
            this.OK_B.Text = "О&к";
            this.OK_B.UseVisualStyleBackColor = true;
            // 
            // Cancel_B
            // 
            this.Cancel_B.Location = new System.Drawing.Point(163, 98);
            this.Cancel_B.Name = "Cancel_B";
            this.Cancel_B.Size = new System.Drawing.Size(75, 23);
            this.Cancel_B.TabIndex = 3;
            this.Cancel_B.Text = "Отмен&а";
            this.Cancel_B.UseVisualStyleBackColor = true;
            // 
            // RavnoS_F
            // 
            this.AcceptButton = this.OK_B;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancel_B;
            this.ClientSize = new System.Drawing.Size(287, 141);
            this.Controls.Add(this.Cancel_B);
            this.Controls.Add(this.OK_B);
            this.Controls.Add(this.A_TB);
            this.Controls.Add(this.A_L);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RavnoS_F";
            this.ShowInTaskbar = false;
            this.Text = "Периметр равностороннего треугольника";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RavnoS_F_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label A_L;
        private System.Windows.Forms.Button OK_B;
        private System.Windows.Forms.Button Cancel_B;
        public System.Windows.Forms.TextBox A_TB;
    }
}