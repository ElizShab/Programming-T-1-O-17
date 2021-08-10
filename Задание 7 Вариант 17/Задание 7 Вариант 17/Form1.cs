using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Задание_7_Вариант_17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Calc_B_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(n_NUD.Value);
            MasA a = new MasA(masA_DGV.ColumnCount);
            MasB b = new MasB(masA_DGV.ColumnCount);
            int i, j;
            for (i = 0; i < n; i++)
                a[i] = Convert.ToInt32(masA_DGV[i, 0].Value);
            for (i = 0; i < n; i++)
                b[i] = Convert.ToInt32(masB_DGV[i, 0].Value);
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n - 1; j++)
                    if (b[i] < b[j])
                    {
                        int z = b[i];
                        b[i] = b[j];
                        b[j] = z;
                    }
            }
            for (i = 0; i < n; i++)
                masB_DGV[i, 0].Value = b[i];
            for (i = 0; i < n; i++)
                masA_DGV[i, 0].Value = a.Mas[i];
            Summ sum = new Summ(n);
            for (i = 0; i < n; i++)
                sum[i] = a.Mas[i] + b[i];
            int max = sum[0];
            for (i = 0; i < n; i++)
                if (max < sum[i])
                    max = sum[i];
            if (i != 0)
                Result_TB.Text = max.ToString();
            else
                Result_TB.Text = "Ответ не найден";
        }
        
            

        private void Form1_Load(object sender, EventArgs e)
        {
            masA_DGV.ColumnCount = Convert.ToInt32(n_NUD.Value);
            masA_DGV.RowCount = 1;
            masB_DGV.ColumnCount = Convert.ToInt32(n_NUD.Value);
            masB_DGV.RowCount = 1;
        }

        private void n_NUD_ValueChanged(object sender, EventArgs e)
        {
            masA_DGV.ColumnCount = Convert.ToInt32(n_NUD.Value);
            masB_DGV.ColumnCount = Convert.ToInt32(n_NUD.Value);
        }
    }
}

