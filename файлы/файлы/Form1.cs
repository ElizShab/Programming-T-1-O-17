using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace файлы
{
    public partial class Form1 : Form
    {
        struct TBooks
        {
            public string LastName;
            public string Write;
            public int Colv;
            public int Year;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Autor_L_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BooksSave_DGV.RowCount = Convert.ToInt32(Count_NUD.Value);
            BooksLoad_DGV.RowCount = 1;
            Autorbooks_DGV.RowCount = 1;
        }

        private void Load_B_Click(object sender, EventArgs e)
        {
            TBooks[] books = new TBooks[0];
            int n = 0;
            using (BinaryReader br = new BinaryReader(File.Open("data.dat", FileMode.Open)))
            {
                while (br.PeekChar() != -1)
                {
                    Array.Resize(ref books, ++n);
                    books[n - 1].LastName = br.ReadString();
                    books[n - 1].Write = br.ReadString();
                    books[n - 1].Colv = br.ReadInt32();
                    books[n - 1].Year = br.ReadInt32();
                }
            }
            BooksLoad_DGV.RowCount = n;
            for (int i = 0; i < n; i++)
            {
                BooksLoad_DGV[0, i].Value = books[i].LastName;
                BooksLoad_DGV[1, i].Value = books[i].Write;
                BooksLoad_DGV[2, i].Value = books[i].Colv;
                BooksLoad_DGV[3, i].Value = books[i].Year;
            }
            string Autor = Convert.ToString(Autor_TB.Text);
            for (int i = 0; i < n; i++)
                if (books[i].Write == Autor)
                {
                    Autorbooks_DGV[0, i].Value = books[i].LastName;
                    Autorbooks_DGV[1, i].Value = books[i].Write;
                    Autorbooks_DGV[2, i].Value = books[i].Colv;
                    Autorbooks_DGV[3, i].Value = books[i].Year;
                }
        }




        

        private void Count_NUD_ValueChanged(object sender, EventArgs e)
        {
            BooksSave_DGV.RowCount = Convert.ToInt32(Count_NUD.Value);
        }

        private void Save_B_Click(object sender, EventArgs e)
        {
            TBooks books;
            using (BinaryWriter bw = new BinaryWriter(File.Open("data.dat", FileMode.Create)))
            {
                for (int i = 0; i < BooksSave_DGV.RowCount; i++)
                {
                    books.LastName = Convert.ToString(BooksSave_DGV[0, i].Value);
                    books.Write = Convert.ToString(BooksSave_DGV[0, i].Value);
                    books.Colv = Convert.ToInt32(BooksSave_DGV[0, i].Value);
                    books.Year = Convert.ToInt32(BooksSave_DGV[0, i].Value);
                    bw.Write(books.LastName);
                    bw.Write(books.Write);
                    bw.Write(books.Colv);
                    bw.Write(books.Year);
                }
            }
        }

        private void Autorbooks_DGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}