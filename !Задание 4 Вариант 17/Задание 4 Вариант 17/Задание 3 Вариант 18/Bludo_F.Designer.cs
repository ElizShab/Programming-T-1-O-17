namespace Задание_3_Вариант_18
{
    partial class Marka_F
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
            this.Name_TB = new System.Windows.Forms.TextBox();
            this.Mas_L = new System.Windows.Forms.Label();
            this.Mas_TB = new System.Windows.Forms.TextBox();
            this.Self_L = new System.Windows.Forms.Label();
            this.Self_TB = new System.Windows.Forms.TextBox();
            this.OK_B = new System.Windows.Forms.Button();
            this.Cancel_B = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Name_L
            // 
            this.Name_L.AutoSize = true;
            this.Name_L.Location = new System.Drawing.Point(3, 24);
            this.Name_L.Name = "Name_L";
            this.Name_L.Size = new System.Drawing.Size(144, 13);
            this.Name_L.TabIndex = 0;
            this.Name_L.Text = "Наз&вание марки самолета";
            // 
            // Name_TB
            // 
            this.Name_TB.Location = new System.Drawing.Point(153, 17);
            this.Name_TB.Name = "Name_TB";
            this.Name_TB.Size = new System.Drawing.Size(100, 20);
            this.Name_TB.TabIndex = 1;
            // 
            // Mas_L
            // 
            this.Mas_L.AutoSize = true;
            this.Mas_L.Location = new System.Drawing.Point(13, 70);
            this.Mas_L.Name = "Mas_L";
            this.Mas_L.Size = new System.Drawing.Size(134, 13);
            this.Mas_L.TabIndex = 2;
            this.Mas_L.Text = "Макс. объем топл&ива (т.)";
            // 
            // Mas_TB
            // 
            this.Mas_TB.Location = new System.Drawing.Point(153, 63);
            this.Mas_TB.Name = "Mas_TB";
            this.Mas_TB.Size = new System.Drawing.Size(100, 20);
            this.Mas_TB.TabIndex = 3;
            // 
            // Self_L
            // 
            this.Self_L.AutoSize = true;
            this.Self_L.Location = new System.Drawing.Point(54, 123);
            this.Self_L.Name = "Self_L";
            this.Self_L.Size = new System.Drawing.Size(93, 13);
            this.Self_L.TabIndex = 4;
            this.Self_L.Text = "Макс. даль&ность";
            // 
            // Self_TB
            // 
            this.Self_TB.Location = new System.Drawing.Point(153, 116);
            this.Self_TB.Name = "Self_TB";
            this.Self_TB.Size = new System.Drawing.Size(100, 20);
            this.Self_TB.TabIndex = 5;
            // 
            // OK_B
            // 
            this.OK_B.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OK_B.Location = new System.Drawing.Point(33, 174);
            this.OK_B.Name = "OK_B";
            this.OK_B.Size = new System.Drawing.Size(75, 23);
            this.OK_B.TabIndex = 8;
            this.OK_B.Text = "OK";
            this.OK_B.UseVisualStyleBackColor = true;
            this.OK_B.Click += new System.EventHandler(this.OK_B_Click);
            // 
            // Cancel_B
            // 
            this.Cancel_B.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel_B.Location = new System.Drawing.Point(178, 174);
            this.Cancel_B.Name = "Cancel_B";
            this.Cancel_B.Size = new System.Drawing.Size(75, 23);
            this.Cancel_B.TabIndex = 9;
            this.Cancel_B.Text = "&Отмена";
            this.Cancel_B.UseVisualStyleBackColor = true;
            // 
            // Marka_F
            // 
            this.AcceptButton = this.OK_B;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancel_B;
            this.ClientSize = new System.Drawing.Size(287, 226);
            this.Controls.Add(this.Cancel_B);
            this.Controls.Add(this.OK_B);
            this.Controls.Add(this.Self_TB);
            this.Controls.Add(this.Self_L);
            this.Controls.Add(this.Mas_TB);
            this.Controls.Add(this.Mas_L);
            this.Controls.Add(this.Name_TB);
            this.Controls.Add(this.Name_L);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Marka_F";
            this.ShowInTaskbar = false;
            this.Text = "Информация о марке самолёта";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Bludo_F_FormClosing);
            this.Load += new System.EventHandler(this.Bludo_F_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Name_L;
        private System.Windows.Forms.Label Mas_L;
        private System.Windows.Forms.Label Self_L;
        private System.Windows.Forms.Button OK_B;
        private System.Windows.Forms.Button Cancel_B;
        public System.Windows.Forms.TextBox Name_TB;
        public System.Windows.Forms.TextBox Mas_TB;
        public System.Windows.Forms.TextBox Self_TB;
    }
}