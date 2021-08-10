using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Вариант_17_задание_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void A_B_Click(object sender, EventArgs e)
        {
            Class1 c = new Class1();
            c.F = Convert.ToInt32(F_TB.Text);
            c.S = Convert.ToInt32(S_TB.Text);
            Spisok_LB.Items.Add(c);
        }

        private void D_B_Click(object sender, EventArgs e)
        {
            if (Spisok_LB.SelectedIndex >= 0)
                Spisok_LB.Items.RemoveAt(Spisok_LB.SelectedIndex);
            else
                MessageBox.Show("Не выбраны данные","Информация");
        }

        private void R_B_Click(object sender, EventArgs e)
        {
            if (Spisok_LB.Items.Count > 0)
            {
                int res = -1 ;
                bool key = false;
                double max = -1;
                for (int i = 0; i < Spisok_LB.Items.Count; i++)
                {
                    Class1 c = Spisok_LB.Items[i] as Class1;
                    double m = (c.F + c.S) / 2;
                    if (!key)
                    {
                        max = m;
                        key = true;
                        res = i;
                    }
                    else
                    {

                        if (max < m)
                        {
                            max = m;
                            res = i;
                        }
                    }
                }
                if (res != -1)
                        R_TB.Text = res.ToString();
                else
                        MessageBox.Show("Ответ не найден", "Информация"); 
             }
             else
                MessageBox.Show("Не введены данные", "Информация");
            }            
          }


}
