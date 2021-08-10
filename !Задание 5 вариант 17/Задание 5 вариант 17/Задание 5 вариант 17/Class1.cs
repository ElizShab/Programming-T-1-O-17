using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;


namespace Задание_5_вариант_17
{
    class TFigure
    {
        int X, Y, dX, dY;
        int Size;
        PictureBox cPictureBox;

        public TFigure(int NewSize, PictureBox NewPictureBox)
        {
            dX = -1;
            dY = -1;
            Size = NewSize;
            cPictureBox = NewPictureBox;
            X = 0;
            Y = 0;
            Show();
        }
        public void Show()
        {
            Pen cPen = new Pen(Color.Black);
            SolidBrush cBrush = new SolidBrush(Color.Blue);
            Graphics cGraphics = Graphics.FromImage(cPictureBox.Image);
            cGraphics.DrawEllipse(cPen, X, Y, Size, Size);
            Point point1 = new Point((int)(X + Size/2 - Size/2 * Math.Cos(Math.PI/6)), (int)(Y + Size/2+Size/2*Math.Sin( Math.PI/6 )));
            Point point2 = new Point(X+Size/2,Y);//Вершина
            Point point3 = new Point(X+Size/2,Y+Size/2);//Центр
            Point[] curvePoints = {point1,point2,point3};
            cGraphics.FillPolygon(cBrush,curvePoints);
            cBrush.Color = Color.Green;
            Point point7 = new Point ((int)(X + Size/2 - Size/2 * Math.Cos(Math.PI/6)), (int)(Y + Size/2+Size/2*Math.Sin( Math.PI/6 )));
            Point point8 = new Point(X + Size / 2, Y + Size / 2 );//Центр
            Point point9 = new Point ((int)(X + Size/2+Size/2*Math.Cos(Math.PI/6)), (int) (Y+ Size/2 + Size/2* Math.Sin(Math.PI/6)));;
           Point[] curve2Points = { point7, point8, point9 };
            cGraphics.FillPolygon(cBrush, curve2Points);
            cBrush.Color = Color.Red;
            Point point4 = new Point(X + Size / 2, Y);//Вершина
            Point point5 = new Point(X + Size / 2, Y + Size / 2);//Центр
            Point point6 = new Point((int)(X + Size/2+Size/2*Math.Cos(Math.PI/6)), (int) (Y+ Size/2 + Size/2* Math.Sin(Math.PI/6)));
            Point[] curve1Points = { point4, point5, point6 };
            cGraphics.FillPolygon(cBrush,curve1Points);            
            cPictureBox.Refresh();
            cGraphics.Dispose();
            cBrush.Dispose();
            cPen.Dispose();
        }

        public void Hide()
        {
            SolidBrush cBrush = new SolidBrush(Color.White);
            Graphics cGraphics = Graphics.FromImage(cPictureBox.Image);
            cGraphics.FillEllipse(cBrush, X-1, Y-1, Size+2, Size+2);            
            cPictureBox.Refresh();
            cGraphics.Dispose();
            cBrush.Dispose();
        }
        public void Move()
        {
            Hide();
            int Temp = X + dX;
            if (Temp < 0 || Temp + Size > cPictureBox.Width)
                dX = -dX;
            X += dX;
            Temp = Y + dY;
            if (Temp < 0 || Temp + Size > cPictureBox.Height)
                dY = -dY;
            Y += dY;
            Show();
        }
    }
}
