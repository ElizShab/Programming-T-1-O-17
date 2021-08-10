namespace Задание_8_Вариант_17
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Список кафедр");
            this.Catalof_L = new System.Windows.Forms.Label();
            this.Catalog_TV = new System.Windows.Forms.TreeView();
            this.Add_B = new System.Windows.Forms.Button();
            this.Change_B = new System.Windows.Forms.Button();
            this.Del_B = new System.Windows.Forms.Button();
            this.Info_L = new System.Windows.Forms.Label();
            this.Info_TB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Catalof_L
            // 
            this.Catalof_L.AutoSize = true;
            this.Catalof_L.Location = new System.Drawing.Point(12, 36);
            this.Catalof_L.Name = "Catalof_L";
            this.Catalof_L.Size = new System.Drawing.Size(107, 13);
            this.Catalof_L.TabIndex = 0;
            this.Catalof_L.Text = "Струк&тура каталога";
            // 
            // Catalog_TV
            // 
            this.Catalog_TV.Location = new System.Drawing.Point(125, 36);
            this.Catalog_TV.Name = "Catalog_TV";
            treeNode1.Name = "Список кафедр";
            treeNode1.Text = "Список кафедр";
            this.Catalog_TV.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.Catalog_TV.Size = new System.Drawing.Size(254, 203);
            this.Catalog_TV.TabIndex = 1;
            this.Catalog_TV.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.Catalog_TV_AfterSelect);
            // 
            // Add_B
            // 
            this.Add_B.Location = new System.Drawing.Point(405, 45);
            this.Add_B.Name = "Add_B";
            this.Add_B.Size = new System.Drawing.Size(70, 26);
            this.Add_B.TabIndex = 2;
            this.Add_B.Text = "Добавит&ь";
            this.Add_B.UseVisualStyleBackColor = true;
            this.Add_B.Click += new System.EventHandler(this.Add_B_Click);
            // 
            // Change_B
            // 
            this.Change_B.Location = new System.Drawing.Point(405, 104);
            this.Change_B.Name = "Change_B";
            this.Change_B.Size = new System.Drawing.Size(70, 27);
            this.Change_B.TabIndex = 3;
            this.Change_B.Text = "Измени&ть";
            this.Change_B.UseVisualStyleBackColor = true;
            this.Change_B.Click += new System.EventHandler(this.Change_B_Click);
            // 
            // Del_B
            // 
            this.Del_B.Location = new System.Drawing.Point(405, 158);
            this.Del_B.Name = "Del_B";
            this.Del_B.Size = new System.Drawing.Size(70, 27);
            this.Del_B.TabIndex = 4;
            this.Del_B.Text = "Удал&ить";
            this.Del_B.UseVisualStyleBackColor = true;
            this.Del_B.Click += new System.EventHandler(this.Del_B_Click);
            // 
            // Info_L
            // 
            this.Info_L.AutoSize = true;
            this.Info_L.Location = new System.Drawing.Point(136, 269);
            this.Info_L.Name = "Info_L";
            this.Info_L.Size = new System.Drawing.Size(73, 13);
            this.Info_L.TabIndex = 5;
            this.Info_L.Text = "Ин&формация";
            // 
            // Info_TB
            // 
            this.Info_TB.Location = new System.Drawing.Point(215, 262);
            this.Info_TB.Name = "Info_TB";
            this.Info_TB.ReadOnly = true;
            this.Info_TB.Size = new System.Drawing.Size(114, 20);
            this.Info_TB.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 313);
            this.Controls.Add(this.Info_TB);
            this.Controls.Add(this.Info_L);
            this.Controls.Add(this.Del_B);
            this.Controls.Add(this.Change_B);
            this.Controls.Add(this.Add_B);
            this.Controls.Add(this.Catalog_TV);
            this.Controls.Add(this.Catalof_L);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Catalof_L;
        private System.Windows.Forms.TreeView Catalog_TV;
        private System.Windows.Forms.Button Add_B;
        private System.Windows.Forms.Button Change_B;
        private System.Windows.Forms.Button Del_B;
        private System.Windows.Forms.Label Info_L;
        private System.Windows.Forms.TextBox Info_TB;
    }
}

