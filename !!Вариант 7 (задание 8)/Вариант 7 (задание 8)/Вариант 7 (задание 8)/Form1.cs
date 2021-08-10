using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Вариант_7__задание_8_
{
    public partial class Form1 : Form
    {
        struct TBook
        {
            public string Title;
            public string Autor;
            public int Count;
            public int Year;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BooksSave_DGV.RowCount = Convert.ToInt32(Count_NUD.Value);
            BooksLoad_DGV.RowCount = 1;
            FindeBooks_DGV.RowCount = 1;
        }

        private void Count_NUD_ValueChanged(object sender, EventArgs e)
        {
            BooksSave_DGV.RowCount = Convert.ToInt32(Count_NUD.Value);
        }

        private void Save_B_Click(object sender, EventArgs e)
        {
            TBook book;
            using (BinaryWriter bw = new BinaryWriter(File.Open("data.dat", FileMode.Create)))
            {
                for (int i = 0; i < BooksSave_DGV.RowCount; i++)
                {
                    book.Title = Convert.ToString(BooksSave_DGV[0, i].Value);
                    book.Autor = Convert.ToString(BooksSave_DGV[1, i].Value);
                    book.Count = Convert.ToInt32(BooksSave_DGV[2, i].Value);
                    book.Year = Convert.ToInt32(BooksSave_DGV[3, i].Value);
                    bw.Write(book.Title);
                    bw.Write(book.Autor);
                    bw.Write(book.Count);
                    bw.Write(book.Year);
                }
            }
        }

        private void Load_B_Click(object sender, EventArgs e)
        {
            TBook[] books = new TBook[0];
            int n = 0;
            using (BinaryReader br = new BinaryReader(File.Open("data.dat", FileMode.Open)))
            {
                while (br.PeekChar() != -1)
                {
                    Array.Resize(ref books, ++n);
                    books[n - 1].Title = br.ReadString();
                    books[n - 1].Autor = br.ReadString();
                    books[n - 1].Count = br.ReadInt32();
                    books[n - 1].Year = br.ReadInt32();
                }
            }
            BooksLoad_DGV.RowCount = n;
            FindeBooks_DGV.RowCount = n;

            for (int i = 0; i < n; i++)
            {
                BooksLoad_DGV[0, i].Value = books[i].Title;
                BooksLoad_DGV[1, i].Value = books[i].Autor;
                BooksLoad_DGV[2, i].Value = books[i].Count;
                BooksLoad_DGV[3, i].Value = books[i].Year;
            }
           
            string Autor = Convert.ToString(Autor_TB.Text);
            int j = 0;

            for (int i = 0; i < n; i++)
            
                if (books[i].Autor == Autor)
            {
                FindeBooks_DGV[0, j].Value = books[i].Title;
                FindeBooks_DGV[1, j].Value = books[i].Autor;
                FindeBooks_DGV[2, j].Value = books[i].Count;
                FindeBooks_DGV[3, j].Value = books[i].Year;
                       j++;
            }
            FindeBooks_DGV.RowCount = j;

            if (j == 0)
            {
                FindeBooks_DGV.RowCount = 1;
                FindeBooks_DGV[0, 0].Value ="Не найдено";
                FindeBooks_DGV[1, 0].Value ="";
                FindeBooks_DGV[2, 0].Value ="";
                FindeBooks_DGV[3, 0].Value ="";
             } 
            int year = Convert.ToInt32(Year_NUD.Value);
            int summ = 0;
            for (int i = 0; i < n; i++)
                if (books[i].Year == year)
                    summ += books[i].Count;
            CountFinde_TB.Text = summ.ToString();
          
        }
    }
}
