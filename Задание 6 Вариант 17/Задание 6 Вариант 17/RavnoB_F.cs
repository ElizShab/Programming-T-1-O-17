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
    public partial class RavnoB_F : Form
    {
        public RavnoB_F()
        {
            InitializeComponent();
        }

        private void RavnoB_F_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
                try
                {
                    int n;
                    string u = A_TB.Text;
                    if (!Int32.TryParse(u, out n))
                    {
                        A_TB.Focus();
                        throw new Exception("Бедро должно содержать только цифры");
                    }
                    if (n <= 0)
                    {
                        throw new Exception("Бедро должно быть положительным числом");
                    }
                    int k = Convert.ToInt32(B_TB.Text);
                    if (k <= 0)
                    {
                        throw new Exception("Третья сторона должна быть положительным числом");
                    }
                }
                catch (FormatException)
                {
                    e.Cancel = true;
                    A_TB.Focus();
                    B_TB.Focus();
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

