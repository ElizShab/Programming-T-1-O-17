using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Задание_8_Вариант_17
{
    public partial class Form1 : Form
    {
        List<TKafedra> Catalog = new List<TKafedra>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Add_B_Click(object sender, EventArgs e)
        {
            if (Catalog_TV.SelectedNode != null)
            {
                if (Catalog_TV.SelectedNode.Level == 0)
                {
                    Kafedra_F Dialog = new Kafedra_F();
                    if (Dialog.ShowDialog() == DialogResult.OK)
                    {
                        TKafedra Kafedra = new TKafedra();
                        Kafedra.Name = Dialog.Name_TB.Text.Trim();
                        Kafedra.Zavedushiy = Dialog.Zavedushiy_TB.Text.Trim();
                        Kafedra.YearO = Convert.ToInt32(Dialog.YearO_TB.Text.Trim());
                        Catalog.Add(Kafedra);
                        TreeNode TempNode = Catalog_TV.SelectedNode.Nodes.Add(Kafedra.Name);
                        TempNode.Nodes.Add("Заведующий: " + Kafedra.Zavedushiy);
                        TempNode.Nodes.Add("Год основания: " + Kafedra.YearO);
                        TempNode.Nodes.Add("Список групп");
                    }
                }
                else
                    if (Catalog_TV.SelectedNode.Level == 2 && Catalog_TV.SelectedNode.Index == 2)
                    {
                        Groups_F Dialog = new Groups_F();
                        if (Dialog.ShowDialog() == DialogResult.OK)
                        {
                            TGroups Group = new TGroups();
                            Group.Name = Dialog.Name_TB.Text.Trim();
                            Group.Starosta = Dialog.Starosta_TB.Text.Trim();
                            Group.YearP = Convert.ToInt32(Dialog.YearP_TB.Text.Trim());
                            Group.ColvoS = Convert.ToInt32(Dialog.ColvoS_TB.Text.Trim());
                            TKafedra Kafedra = Catalog.ElementAt(Catalog_TV.SelectedNode.Parent.Index);
                            Kafedra.Groups.Add(Group);
                            TreeNode TempNode = Catalog_TV.SelectedNode.Nodes.Add(Group.Name);
                            TempNode.Nodes.Add("Староста: " + Group.Starosta);
                            TempNode.Nodes.Add("Год поступления: " + Group.YearP);
                            TempNode.Nodes.Add("Количество студентов: " + Group.ColvoS);
                        }
                    }
                    else
                        MessageBox.Show("Добавление возможно только в списки кафедр и групп", "Информация");
            }
            else
                MessageBox.Show("Выберете список для добавления", "Информация");
        }

        private void Change_B_Click(object sender, EventArgs e)
        {
            if (Catalog_TV.SelectedNode != null)
            {
                if (Catalog_TV.SelectedNode.Level == 1 || Catalog_TV.SelectedNode.Level == 3)
                {
                    if (Catalog_TV.SelectedNode.Level == 1)
                    {
                        TKafedra Kafedra = Catalog.ElementAt(Catalog_TV.SelectedNode.Index);
                        Kafedra_F Dialog = new Kafedra_F();
                        if (Dialog.ShowDialog() == DialogResult.OK)
                        {
                            Kafedra.Name = Dialog.Name_TB.Text.Trim();
                            Kafedra.Zavedushiy = Dialog.Zavedushiy_TB.Text.Trim();
                            Kafedra.YearO = Convert.ToInt32(Dialog.YearO_TB.Text.Trim());
                            Catalog.Add(Kafedra);
                            Catalog_TV.SelectedNode.Text = Kafedra.Name;
                            Catalog_TV.SelectedNode.Nodes[0].Text = "Заведующий: " + Kafedra.Zavedushiy;
                            Catalog_TV.SelectedNode.Nodes[1].Text = "Год основания: " + Kafedra.YearO;
                        }
                    }
                    else
                        if (Catalog_TV.SelectedNode.Level == 3)
                        {
                            TKafedra Kafedra = Catalog.ElementAt(Catalog_TV.SelectedNode.Parent.Parent.Index);
                            TGroups Groups = Kafedra.Groups.ElementAt(Catalog_TV.SelectedNode.Index);
                            Groups_F Dialog = new Groups_F();
                            if (Dialog.ShowDialog() == DialogResult.OK)
                            {
                                Groups.Name = Dialog.Name_TB.Text.Trim();
                                Groups.Starosta = Dialog.Starosta_TB.Text.Trim();
                                Groups.YearP = Convert.ToInt32(Dialog.YearP_TB.Text.Trim());
                                Groups.ColvoS = Convert.ToInt32(Dialog.ColvoS_TB.Text.Trim());
                                Kafedra.Groups.Add(Groups);
                                Catalog_TV.SelectedNode.Text = Groups.Name;
                                Catalog_TV.SelectedNode.Nodes[0].Text = "Староста: " + Groups.Starosta;
                                Catalog_TV.SelectedNode.Nodes[1].Text = "Год поступления: " + Groups.YearP;
                                Catalog_TV.SelectedNode.Nodes[2].Text = "Количество студентов: " + Groups.ColvoS;
                            }
                        }
                        else
                            MessageBox.Show("Изменение возможно только в списке кафедр и групп", "Информация");
                }
                else
                    MessageBox.Show("Выберете кафедру или группу для изменения", "Информация");
            }
        }

        private void Del_B_Click(object sender, EventArgs e)
        {
            if (Catalog_TV.SelectedNode != null)
            {
                if (Catalog_TV.SelectedNode.Level == 1 || Catalog_TV.SelectedNode.Level == 3)
                {
                    if (Catalog_TV.SelectedNode.Level == 1)
                        Catalog.RemoveAt(Catalog_TV.SelectedNode.Index);
                    else
                    {
                        TKafedra Kafedra = Catalog.ElementAt(Catalog_TV.SelectedNode.Parent.Parent.Parent.Index);
                        Kafedra.Groups.RemoveAt(Catalog_TV.SelectedNode.Index);
                    }
                    Catalog_TV.SelectedNode.Remove();
                }
                else
                    MessageBox.Show("Удалить можно только кафедру или группу", "Информация");

            }
            else
                MessageBox.Show("Выберете кафедру или группу для удаления", "Информация");
        }

        private void Catalog_TV_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TGroups Groups;
            TKafedra Kafedra;
            switch (Catalog_TV.SelectedNode.Level)
            {
                case 0:
                    Info_TB.Text = "Это корень дерева";
                    Add_B.Enabled = true;
                    Change_B.Enabled = false;
                    Del_B.Enabled = false;
                    break;
                case 1:
                    Kafedra = Catalog.ElementAt(Catalog_TV.SelectedNode.Index);
                    int sum = 0;                        
                    for (int i = 0; i < Kafedra.Groups.Count; i++)
                    {
                        sum +=Convert.ToInt32(Kafedra.Groups[i].ColvoS);
                    } 
                    Info_TB.Text = "Всего студентов: " + sum;
                    Add_B.Enabled = false;
                    Change_B.Enabled = true;
                    Del_B.Enabled = true;

                    break;
                case 2:
                    Kafedra = Catalog.ElementAt(Catalog_TV.SelectedNode.Parent.Index);
                    Info_TB.Text = "Всего групп: " + Kafedra.Groups.Count;
                    Add_B.Enabled = false;
                    Change_B.Enabled = false;
                    Del_B.Enabled = false;
                    if (Catalog_TV.SelectedNode.Index == 2)
                    {
                        Add_B.Enabled = true;
                    }
                    break;
                case 3:
                    Kafedra = Catalog.ElementAt(Catalog_TV.SelectedNode.Parent.Parent.Index);
                    Info_TB.Text = "Кафедра: " + Kafedra.Name;
                    Add_B.Enabled = false;
                    Change_B.Enabled = true;
                    Del_B.Enabled = true;
                    break;
                case 4:
                    Kafedra = Catalog.ElementAt(Catalog_TV.SelectedNode.Parent.Parent.Parent.Index);
                    Groups = Kafedra.Groups.ElementAt(Catalog_TV.SelectedNode.Parent.Index);
                    Info_TB.Text = "Группа: " + Groups.Name;
                    Add_B.Enabled = false;
                    Change_B.Enabled = false;
                    Del_B.Enabled = false;
                    break;
            }
        }
    }
}
