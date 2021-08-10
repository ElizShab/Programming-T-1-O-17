using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _7_вариант__4_задание_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int count = MAS_TB.Lines.Length;
            int[] mas = new int[count];
            for (int i=0; i< count; i++) 
                 mas [i]= Convert.ToInt32(MAS_TB.Lines[i]);
            int sum1 = 0;
            for (int i = 0; i < count; i++)
                if (mas[i] > 0)
                  sum1 += mas[i]; 
                int sum2 = 0;
            for (int i = 0;i < count; i++)
                if (mas[i] < 0)
                sum2 += mas[i]; 
            if (sum1 == 0)
             { SUM1_TB.Text = sum1.ToString("Элементов не найдено");}
            else
            { SUM1_TB.Text = sum1.ToString(); }
            if (sum2 == 0)
            { SUM2_TB.Text = sum2.ToString("Элементов не найдено"); }
            else
            { SUM2_TB.Text = sum2.ToString(); } 
        }
    }
}
