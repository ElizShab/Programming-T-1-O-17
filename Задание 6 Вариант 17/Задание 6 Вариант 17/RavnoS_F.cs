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
    public partial class RavnoS_F : Form
    {
        public RavnoS_F()
        {
            InitializeComponent();
        }

        private void RavnoS_F_FormClosing(object sender, FormClosingEventArgs e)
        {
            if ( DialogResult == DialogResult.OK)
                try
                {
                    int l = Convert.ToInt32(A_TB.Text);
                    if (l <= 0)
                    {
                        throw new Exception("Строка должна быть положительным числом");
                    }
                }
                catch (FormatException)
                {
                    e.Cancel = true;
                    A_TB.Focus();
                    MessageBox.Show("Сторона должна содержать только цифры", "Ошибка");
                }
                catch (Exception E)
                {
                    e.Cancel = true;
                    A_TB.Focus();
                    MessageBox.Show(E.Message, "Ошибка");
                }
        }

    }
}
