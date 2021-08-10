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
    public partial class Groups_F : Form
    {
        public Groups_F()
        {
            InitializeComponent();
        }

        private void Groups_F_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                try
                {
                    if (Name_TB.Text.Trim() == "")
                    {
                        Name_TB.Focus();
                        throw new Exception("Вы не ввели наименование группы");
                    }
                    if (Starosta_TB.Text.Trim() == "")
                    {
                        Starosta_TB.Focus();
                        throw new Exception("Вы не ввели фамилию старосты группы");
                    }
                    int n;
                    string l = Starosta_TB.Text;
                    if (Int32.TryParse(l, out n))
                    {
                        Starosta_TB.Focus();
                        throw new Exception("Фамилия не может содержать цифры и/или знаки");
                    }
                    if (YearP_TB.Text.Trim() == "")
                    {
                        YearP_TB.Focus();
                        throw new Exception("Вы не ввели год поступления");
                    }
                    string k = YearP_TB.Text;
                    if (!Int32.TryParse(k, out n))
                    {
                        YearP_TB.Focus();
                        throw new Exception("Год не может содержать буквы и/или знаки");
                    }
                    if (n < 0)
                    {
                        YearP_TB.Focus();
                        throw new Exception("Год не может быть отрицательным числом");
                    }
                    if (ColvoS_TB.Text.Trim() == "")
                    {
                        ColvoS_TB.Focus();
                        throw new Exception("Вы не ввели количество студентов в группе");
                    }
                    int h;
                    string i = ColvoS_TB.Text;
                    if (!Int32.TryParse(i, out h))
                    {
                        ColvoS_TB.Focus();
                        throw new Exception("Количетво студентов записывается только цифрами");
                    }
                    if (h < 0)
                    {
                        ColvoS_TB.Focus();
                        throw new Exception("Количество студентов не может быть отрицательным числом");
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
