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
    public partial class Kafedra_F : Form
    {
        public Kafedra_F()
        {
            InitializeComponent();
        }

        private void Kafedra_F_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {

                try
                {
                    if (Name_TB.Text.Trim() == "")
                    {
                        Name_TB.Focus();
                        throw new Exception("Вы не ввели наименование кафедры");
                    }
                    if (Zavedushiy_TB.Text.Trim() == "")
                    {
                        Zavedushiy_TB.Focus();
                        throw new Exception("Вы не ввели фамилию заведующего кафедры");
                    }
                    int n;
                    string l = Zavedushiy_TB.Text;
                    if (Int32.TryParse(l, out n))
                    {
                        Zavedushiy_TB.Focus();
                        throw new Exception("Фамилия не может содержать цифры и/или знаки");
                    }

                    if (YearO_TB.Text.Trim() == "")
                    {
                        YearO_TB.Focus();
                        throw new Exception("Вы не ввели год основания кафедры");
                    }
                    string k = YearO_TB.Text;
                    if (!Int32.TryParse(k, out n))
                    {
                        YearO_TB.Focus();
                        throw new Exception("Год не может содержать буквы и/или знаки");
                    }
                    if ( n < 0)
                    {
                        YearO_TB.Focus();
                        throw new Exception("Год не может быть отрицательным числом");
                    }
                }
                catch (Exception E)
                {
                    e.Cancel = true;
                    MessageBox.Show(E.Message, "Ошибка");
                }
            }
        }
    }
}
