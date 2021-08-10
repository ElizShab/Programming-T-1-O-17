using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Задание_5_вариант_17
{
    public partial class Form1 : Form
    {
        TFigure Figure;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Picture_PB.Image = new Bitmap(Picture_PB.Width, Picture_PB.Height);
            Figure = new TFigure(Picture_PB.Width/2, Picture_PB);
            Move_T.Enabled = true;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Move_T.Enabled = false;
            Figure.Hide();
        }

        private void Move_T_Tick(object sender, EventArgs e)
        {
            Figure.Move();
        }
    }
}
