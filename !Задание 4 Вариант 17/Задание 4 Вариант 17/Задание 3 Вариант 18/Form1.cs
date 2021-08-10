using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Задание_3_Вариант_18
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {           
            if (Spisok_LB.SelectedIndex != -1)
            {   
                Spisok_LB.Items.RemoveAt(Spisok_LB.SelectedIndex);
                if (Spisok_LB.Items.Count == 0)
                {                    
                    Calc_ED(false);
                    Save_ED(false);
                }
            }
            else
                MessageBox.Show("Не выбран элемент в списке", "Информация"); 
        }

        private void Add_B_Click(object sender, EventArgs e)
        {
            Marka_F Dialog = new Marka_F();
            Dialog.Text = "Добавление марки самолёта";
            Dialog.Name_TB.Text = "";
            Dialog.Mas_TB.Text = "";
            Dialog.Self_TB.Text = "";
            if (Dialog.ShowDialog() == DialogResult.OK)
            {
                TMarka Marka = new TMarka();
                Marka.Name = Dialog.Name_TB.Text.Trim();
                Marka.Mas = Convert.ToDouble(Dialog.Mas_TB.Text);
                Marka.Self = Convert.ToInt32(Dialog.Self_TB.Text);
                Spisok_LB.Items.Add(Marka);
                Calc_ED(true);
                Save_ED(true);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
                if (Spisok_LB.SelectedIndex != -1)
                {
                    Marka_F Dialog = new Marka_F();
                    Dialog.Text = "Изменение данных о марке самолёта";
                    TMarka Marka = Spisok_LB.SelectedItem as TMarka;
                    Dialog.Name_TB.Text = Marka.Name;
                    Dialog.Mas_TB.Text = Marka.Mas.ToString();
                    Dialog.Self_TB.Text = Marka.Self.ToString();
                    if (Dialog.ShowDialog() == DialogResult.OK)
                    {
                        Marka.Name = Dialog.Name_TB.Text.Trim();
                        Marka.Mas = Convert.ToDouble(Dialog.Mas_TB.Text);
                        Marka.Self = Convert.ToInt32(Dialog.Self_TB.Text);
                        Spisok_LB.Items[Spisok_LB.SelectedIndex] = Marka;
                    }
                }
                else
                {
                    MessageBox.Show("Не выбран элемент в списке", "Информация");
                }            
        }
        private void Change_ED(bool Value)
        {
            Change_B.Enabled = Value;
            Change_TSB.Enabled = Value;
            Change_TSMI.Enabled = Value;
        }
        private void Del_ED(bool Value)
        {
            Del_B.Enabled = Value;
            Del_TSB.Enabled = Value;
            Del_TSMI.Enabled = Value;
        }
        private void Save_ED(bool Value)
        {
            Save_B.Enabled = Value;
            Save_TSB.Enabled = Value;
            Save_TSMI.Enabled = Value;
        }
        private void Calc_ED(bool Value)
        {
            Calc_B.Enabled = Value;
            Calc_TSB.Enabled = Value;
            Calc_TSMI.Enabled = Value;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void Save_B_Click(object sender, EventArgs e)
        {
            Save_D.FileName = "";
            if (Save_D.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(File.Open(Save_D.FileName, FileMode.Create)))
                {
                    for (int i = 0; i < Spisok_LB.Items.Count; i++)
                    {
                        TMarka Marka = Spisok_LB.Items[i] as TMarka;
                        sw.WriteLine(Marka.Name);
                        sw.WriteLine(Marka.Mas);
                        sw.WriteLine(Marka.Self);
                    }
                }
            }
        }

        private void Calc_B_Click(object sender, EventArgs e)
        {
            if (Zadan_TB.Text.Trim() != "")
            {                
                int n=0;
                TMarka s;
                TMarka [] mas = new TMarka[n];
                TMarka[] Marka = new TMarka[Spisok_LB.Items.Count];
                for (int i = 0; i < Spisok_LB.Items.Count; i++)
                    Marka[i] = Spisok_LB.Items[i] as TMarka;
                FormatSpisok_LB.Items.Clear();                
                for (int i = 0; i < Spisok_LB.Items.Count; i++)
                {
                    if (Marka[i].Mas > Convert.ToInt32(Zadan_TB.Text))
                    {
                        Array.Resize(ref mas, ++n);
                        mas[n - 1] = Marka[i];
                    }
                }
                if ( n != 0 ) 
                {
                    for (int i =0;i < n;i++)
                    {
                        for (int j = 1; j<n;j++)
                        {
                            if (String.Compare(mas[j - 1].Name, mas[j].Name) > 0)
                            {
                                s = mas[j - 1];
                                mas[j - 1] = mas[j];
                                mas[j] = s;
                            }
                        }
                    }
                    for (int i = 0; i < n; i++)
                    {
                        FormatSpisok_LB.Items.Add(mas[i].Name + " " + mas[i].Mas + " " + mas[i].Self);
                    }           
                }
                else
                {
                    FormatSpisok_LB.Items.Add("Ответ не найден");
            }
            }
            else
            {
                Zadan_TB.Focus();
                MessageBox.Show("Введите заданное число");
            }
        }
        private void Load_B_Click(object sender, EventArgs e)
        {
            Open_D.FileName = "";
            if (Open_D.ShowDialog() == DialogResult.OK)
            {
                Spisok_LB.Items.Clear();
                Name_TSSL.Text = "";
                Mas_TSSL.Text = "";
                Self_TSSL.Text = "";
                using (StreamReader sr = new StreamReader(File.Open(Open_D.FileName, FileMode.Open)))
                {
                    while (!sr.EndOfStream)
                    {
                        TMarka Marka = new TMarka();
                        Marka.Name = sr.ReadLine();
                        Marka.Mas = Convert.ToDouble(sr.ReadLine());
                        Marka.Self = Convert.ToInt32(sr.ReadLine());
                        Spisok_LB.Items.Add(Marka);
                    }
                }
                Calc_ED(true);
                Save_ED(true);
            }
        }

        private void Spisok_LB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Spisok_LB.SelectedIndex >= 0)
            {
                TMarka Marka = Spisok_LB.SelectedItem as TMarka;
                Name_TSSL.Text = Marka.Name;
                Mas_TSSL.Text = Marka.Mas.ToString();
                Self_TSSL.Text = Marka.Self.ToString();
                Change_ED(true);
                Del_ED(true);
            }
            else
            {
                Name_TSSL.Text = "";
                Mas_TSSL.Text = "";
                Self_TSSL.Text = "";
                Change_ED(false);
                Del_ED(false);
            }
        }
    }
}

