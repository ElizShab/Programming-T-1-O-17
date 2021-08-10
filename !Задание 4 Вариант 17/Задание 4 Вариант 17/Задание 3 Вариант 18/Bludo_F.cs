using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Задание_3_Вариант_18
{
    public partial class Marka_F : Form
    {
        public Marka_F()
        {
            InitializeComponent();
        }

        private void Bludo_F_Load(object sender, EventArgs e)
        {

        }

        private void Bludo_F_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                try
                {
                    if (Name_TB.Text.Trim() == "")
                    {
                        Name_TB.Focus();
                        throw new Exception("Вы не ввели название марки самолёта");
                    }
                    if (Mas_TB.Text.Trim() == "")
                    {
                        Mas_TB.Focus();
                        throw new Exception("Вы не ввели максимальный объем топлива");
                    }
                    double n;
                    string k = Mas_TB.Text;
                    if (!Double.TryParse(k, out n))
                    {
                        Mas_TB.Focus();
                        throw new Exception("Максимальный объем топлива не может содержать буквы и/или знаки");
                    }
                    if (n < 0.1 || n > 10.0)
                    {
                        Mas_TB.Focus();
                        throw new Exception("Максимальный объём топлива должен быть от 0.1 до 10.0 т.");
                    }
                    if (Self_TB.Text.Trim() == "")
                    {
                        Self_TB.Focus();
                        throw new Exception("Вы не ввели максимальную дальность");
                    }
                    int h;
                    string l = Self_TB.Text;
                    if (!Int32.TryParse(l, out h))
                    {
                        Self_TB.Focus();
                        throw new Exception("Максимальная дальность не может содержать буквы и/или знаки");
                    }
                    if (h < 100 || h > 10000)
                    {
                        Self_TB.Focus();
                        throw new Exception("Максимальная дальность должна быть от 100 до 10000");
                    }
                }
                catch (Exception E)
                {
                    e.Cancel = true;
                    MessageBox.Show(E.Message, "Ошибка");
                }
            }
        }
        private void OK_B_Click(object sender, EventArgs e)
        {

        }
    }
}

