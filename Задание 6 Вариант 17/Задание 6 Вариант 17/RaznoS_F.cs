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
    public partial class RaznoS_F : Form
    {
        public RaznoS_F()
        {
            InitializeComponent();
        }

        private void RaznoS_F_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
                try
                {
                    int n;
                    string u = A_TB.Text;
                    if (!Int32.TryParse(u, out n))
                    {
                        A_TB.Focus();
                        throw new Exception("Первая сторона должна содержать только цифры");
                    }
                    
                    if (n <= 0)
                    {
                        throw new Exception("Первая сторона должна быть положительным числом");
                    }
                    int h;
                    string y = B_TB.Text;
                    if (!Int32.TryParse(y, out h))
                    {
                        B_TB.Focus();
                        throw new Exception("Вторая сторона должна содержать только цифры");
                    }
                    if (h <= 0)
                    {
                        throw new Exception("Вторая сторона должна быть положительным числом");
                    }
                    int o = Convert.ToInt32(C_TB.Text);
                    if (o <= 0)
                    {
                        throw new Exception("Третья сторона должна быть положительным числом");
                    } 
                }
                catch (FormatException)
                {
                    e.Cancel = true;
                    A_TB.Focus();
                    B_TB.Focus();
                    C_TB.Focus();
                    MessageBox.Show("Третья сторона должна содержать только цифры", "Ошибка");
                }
                catch (Exception E)
                {
                    e.Cancel = true;
                    A_TB.Focus();
                    B_TB.Focus();
                    MessageBox.Show(E.Message, "Ошибка");
                }
        }
    }
}
