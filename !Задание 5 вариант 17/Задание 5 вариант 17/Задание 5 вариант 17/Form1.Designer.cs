namespace Задание_5_вариант_17
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
            this.components = new System.ComponentModel.Container();
            this.Picture_PB = new System.Windows.Forms.PictureBox();
            this.Move_T = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Picture_PB)).BeginInit();
            this.SuspendLayout();
            // 
            // Picture_PB
            // 
            this.Picture_PB.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Picture_PB.Location = new System.Drawing.Point(12, 12);
            this.Picture_PB.Name = "Picture_PB";
            this.Picture_PB.Size = new System.Drawing.Size(300, 300);
            this.Picture_PB.TabIndex = 0;
            this.Picture_PB.TabStop = false;
            // 
            // Move_T
            // 
            this.Move_T.Tick += new System.EventHandler(this.Move_T_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 359);
            this.Controls.Add(this.Picture_PB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Picture_PB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Picture_PB;
        private System.Windows.Forms.Timer Move_T;
    }
}

