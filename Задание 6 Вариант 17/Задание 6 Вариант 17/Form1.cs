using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Задание_6_Вариант_17
{
    public partial class Main_F : Form
    {
        public Main_F()
        {
            InitializeComponent();
        }

        private void Add_B_Click(object sender, EventArgs e)
        {
            if (RavnoS_RB.Checked)
            {
                RavnoS_F Dialog = new RavnoS_F();
                Dialog.Text = "Добавление периметра равностороннего треугольника";
                Dialog.A_TB.Text = "";
                if (Dialog.ShowDialog() == DialogResult.OK)
                {
                    TRavnoS Func = new TRavnoS(Convert.ToInt32(Dialog.A_TB.Text));
                    Spisok_LB.Items.Add(Func);
                    Result_TB.Text = Func.Calc().ToString();
                }
            }
            else if (RavnoB_RB.Checked)
            {
                RavnoB_F Dialog = new RavnoB_F();
                Dialog.Text = "Добавление периметра равнобедренного треугольника";
                Dialog.A_TB.Text = "";
                Dialog.B_TB.Text = "";
                if (Dialog.ShowDialog() == DialogResult.OK)
                {
                    TRavnoB Func = new TRavnoB(Convert.ToInt32(Dialog.A_TB.Text), Convert.ToInt32(Dialog.B_TB.Text));
                    Spisok_LB.Items.Add(Func);
                    Result_TB.Text = Func.Calc().ToString();
                }
            }
            else if (RaznoS_RB.Checked)
            {
                RaznoS_F Dialog = new RaznoS_F();
                Dialog.Text = "Добавление периметра разностороннего треугольника ";
                Dialog.A_TB.Text = "";
                Dialog.B_TB.Text = "";
                Dialog.C_TB.Text = "";
                if (Dialog.ShowDialog() == DialogResult.OK)
                {
                    TRaznoS Func = new TRaznoS(Convert.ToInt32(Dialog.A_TB.Text), Convert.ToInt32(Dialog.B_TB.Text), Convert.ToInt32(Dialog.C_TB.Text));
                    Spisok_LB.Items.Add(Func);
                    Result_TB.Text = Func.Calc().ToString();
                }
            }
        }

        private void Change_B_Click(object sender, EventArgs e)
        {
            if (Spisok_LB.SelectedIndex >= 0)
            {
                if (Spisok_LB.SelectedItem is TRavnoS)
                {
                    TRavnoS Func = Spisok_LB.SelectedItem as TRavnoS;
                    RavnoS_F Dialog = new RavnoS_F();
                    Dialog.Text = "Изменение периметра равностороннего треугольника";
                    Dialog.A_TB.Text = Func.A.ToString();
                    if (Dialog.ShowDialog() == DialogResult.OK)
                    {
                        Func.A = Convert.ToInt32(Dialog.A_TB.Text);
                        Spisok_LB.Items[Spisok_LB.SelectedIndex] = Func;
                        Result_TB.Text = Func.Calc().ToString();
                    }
                }
                else if (Spisok_LB.SelectedItem is TRavnoB)
                {
                    TRavnoB Func = Spisok_LB.SelectedItem as TRavnoB;
                    RavnoB_F Dialog = new RavnoB_F();
                    Dialog.Text = "Изменение периметра равнобедренного треугольника";
                    Dialog.A_TB.Text = Func.A.ToString();
                    Dialog.B_TB.Text = Func.B.ToString();
                    if (Dialog.ShowDialog() == DialogResult.OK)
                    {
                        Func.A = Convert.ToInt32(Dialog.A_TB.Text);
                        Func.B = Convert.ToInt32(Dialog.B_TB.Text);
                        Spisok_LB.Items[Spisok_LB.SelectedIndex] = Func;
                        Result_TB.Text = Func.Calc().ToString();
                    }
                }
                else if (Spisok_LB.SelectedItem is TRaznoS)
                {
                    TRaznoS Func = Spisok_LB.SelectedItem as TRaznoS;
                    RaznoS_F Dialog = new RaznoS_F();
                    Dialog.Text = "Изменение периметра разностороннего треугольника";
                    Dialog.A_TB.Text = Func.A.ToString();
                    Dialog.B_TB.Text = Func.B.ToString();
                    Dialog.C_TB.Text = Func.C.ToString();
                    if (Dialog.ShowDialog() == DialogResult.OK)
                    {
                        Func.A = Convert.ToInt32(Dialog.A_TB.Text);
                        Func.B = Convert.ToInt32(Dialog.B_TB.Text);
                        Func.C = Convert.ToInt32(Dialog.C_TB.Text);
                        Spisok_LB.Items[Spisok_LB.SelectedIndex] = Func;
                        Result_TB.Text = Func.Calc().ToString();
                    }
                }
            }
            else
                MessageBox.Show("Не выбран элемент в списке", "Ошибка");
        }

        private void Del_B_Click(object sender, EventArgs e)
        {
            if (Spisok_LB.SelectedIndex >= 0)
            {
                Spisok_LB.Items.RemoveAt(Spisok_LB.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Не выбран элемент в списке ", "Информация");
            }
        }

        private void Spisok_LB_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (Spisok_LB.SelectedIndex >= 0)
            {
                Change_B.Enabled = true;
                Del_B.Enabled = true;
                TFunction F = Spisok_LB.SelectedItem as TFunction;
                Result_TB.Text = F.Calc().ToString();
            }
            else
            {
                Change_B.Enabled = false;
                Del_B.Enabled = false;
            }
        }

        private void RavnoS_RB_CheckedChanged(object sender, EventArgs e)
        {
            Add_B.Enabled = true;
        }

        private void RavnoB_RB_CheckedChanged(object sender, EventArgs e)
        {
            Add_B.Enabled = true;
        }

        private void RaznoS_RB_CheckedChanged(object sender, EventArgs e)
        {
            Add_B.Enabled = true;
        }
    }
}

