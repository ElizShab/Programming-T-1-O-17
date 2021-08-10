using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Вариант_21__задание_9__
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MatrA_DGV.RowCount = 2;
            MatrA_DGV.ColumnCount = Convert.ToInt32(CountCol_NUD.Value);
        }

        private void CountCol_NUD_ValueChanged(object sender, EventArgs e)
        {
            MatrA_DGV.ColumnCount = Convert.ToInt32(CountCol_NUD.Value);
        }

        private void Calc_B_Click(object sender, EventArgs e)
        {
            int number = 0;
           int[,] MatrA = new int[MatrA_DGV.RowCount, MatrA_DGV.ColumnCount];
            for (int i = 0; i < MatrA_DGV.RowCount; i++)
                for (int j = 0; j < MatrA_DGV.ColumnCount; j++)
                    MatrA[i, j] = Convert.ToInt32(MatrA_DGV[j, i].Value);
            double sumLengh;
            double Sum = 0;
            for (int j = 0; j < MatrA_DGV.ColumnCount-1; j++)
            {
                sumLengh = Math.Sqrt(Math.Pow((MatrA[0,j+1] - MatrA [0,0]),2)+Math.Pow((MatrA[1,j+1]-MatrA[1,0]),2));
                Sum += sumLengh;
                number=1;
            }
            
            double Sum1 = 0;
            double maxSum = Sum;
            for (int j = 1; j < MatrA_DGV.ColumnCount; j++)
            {
                for (int i = 0; i < MatrA_DGV.ColumnCount - 1; i++)
                {
                    sumLengh = Math.Sqrt(Math.Pow((MatrA[0, i + 1] - MatrA[0, j]), 2) + Math.Pow((MatrA[1, i + 1] - MatrA[1, j]), 2));
                    Sum1 += sumLengh;
                 
                } 
                if (Sum1 > maxSum)
                    {
                        number = j;
                        maxSum = Sum1;
                    }
            }
                Result_TB.Text = number.ToString();
         }

        private void Save_B_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(CountCol_NUD.Value);
            using (BinaryWriter bw = new BinaryWriter(File.Open("source.dat", FileMode.Create)))
            {
                bw.Write(n);
                for (int i = 0; i < MatrA_DGV.ColumnCount; i++)
                    for( int j = 0; j < MatrA_DGV.RowCount; j++)
                {
                    bw.Write(Convert.ToInt32(MatrA_DGV[i, j].Value));
                }
            }
            MessageBox.Show("Запись успешно выполнена", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Load_B_Click(object sender, EventArgs e)
        {
            using (BinaryReader br = new BinaryReader(File.Open("source.dat", FileMode.Open)))
            {
                int n = br.ReadInt32();
                MatrLoad_DGV.RowCount = 2;
                MatrLoad_DGV.ColumnCount = n;
                for (int i = 0; i < MatrA_DGV.ColumnCount; i++)
                    for (int j = 0; j < MatrA_DGV.RowCount; j++)               
                {
                    MatrLoad_DGV[i, j].Value = br.ReadInt32();
                }
                Result_TB.Text = "";
            }

        }

        private void Random_B_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int n = rnd.Next(3, 8);
            CountCol_NUD.Value = n;
            for (int i = 0; i < MatrA_DGV.ColumnCount; i++)
                for (int j = 0; j < MatrA_DGV.RowCount; j++)     
                    MatrA_DGV[i, j].Value = rnd.Next(10,26);
        }

        private void SaveR_B_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter(File.Open("result.txt", FileMode.OpenOrCreate)))
            {
                sw.Write(Result_TB.Text + " ");
            }
            MessageBox.Show ("Сохраниение результатов успешно выполнено", "Информация",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
    

