using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {

        private string Method(int max)
    {
        return "max " + max ;
    }
        public Form1()
        {
            InitializeComponent();
        }

       

        private void Calc_B_Click(object sender, EventArgs e)
        {
            int count1 = MASS1_TB.Lines.Length ;
            int[] mas1 = new int[count1];
            int count2 = MASS2_TB.Lines.Length;
            int[] mas2 = new int[count2];
            int count3 = MASS3_TB.Lines.Length;
            int[] mas3 = new int[count3];
            for (int i = 0; i < count1; i++)
                mas1[i] = Convert.ToInt32(MASS1_TB.Lines[i]);
            for (int j = 0; j < count2; j++)
                mas2[j] = Convert.ToInt32(MASS2_TB.Lines[j]);
            for (int k = 0; k < count3; k++)
                mas3[k] = Convert.ToInt32(MASS3_TB.Lines[k]);
            int max = 0;
            int max1 = mas1[0];
            int max2 = mas2[0];
            int max3 = mas3[0];
            for (int i = 1; i < count1; i++)
            {
                if (max1 < mas1[i]) 
                max1 = mas1[i];
            }
            for (int j = 1; j < count2; j++)
            {
                if (max2 < mas2[j])
                    max2 = mas2[j];
            }
            for (int k = 1; k < count3; k++)
            {
                if (max3 < mas3[k])
                    max3 = mas3[k];
            }
            if (max1 > max2)
                max = max1;
            else if (max2 > max3)
                max = max2;
            else
                max = max3;
            Result_TB.Text = Method(max);
        }
    }
}
