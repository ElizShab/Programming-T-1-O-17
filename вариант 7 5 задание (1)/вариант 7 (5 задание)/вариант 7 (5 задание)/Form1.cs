using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace вариант_7__5_задание_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Calc_B_Click(object sender, EventArgs e)
        {
            int count1 = masX_TB.Lines.Length;
            double[] masX = new double[count1];
            int count2 = masY_TB.Lines.Length;
            double[] masY = new double[count2];
            for (int i = 0; i < count1; i++)
                masX[i] = Convert.ToDouble(masX_TB.Lines[i]);
            for (int j = 0; j < count2; j++)
                masY[j] = Convert.ToDouble(masY_TB.Lines[j]);
            double[,] matrZ = new double[count1, count2];
            for (int i = 0; i < count1; i++)
                for (int j = 0; j < count2; j++)
                    matrZ[i, j] = masX[i] * masY[j];
            for (int i = 0; i < matrZ_DGV.RowCount; i++)
                for (int j = 0; j < matrZ_DGV.ColumnCount; j++)                
                    matrZ_DGV[j, i].Value = matrZ[i, j];                 
                double max = matrZ[0, 0];
            for (int i = 0; i < count1; i++)
                for (int j = 0; j < count2; j++)
                    if (max < matrZ[i, j])
                        max = matrZ[i, j];
            matrZ_DGV.RowCount = count1;
            matrZ_DGV.ColumnCount = count2;
            for (int i = 0; i < matrZ_DGV.RowCount; i++)
                for (int j = 0; j < matrZ_DGV.ColumnCount; j++) 
                 matrZ_DGV[j, i].Value = matrZ[i, j].ToString();
            Res_TB.Text = max.ToString();
        }
    }
}
