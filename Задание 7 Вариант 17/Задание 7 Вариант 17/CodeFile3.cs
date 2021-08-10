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
    class Summ
    {
        private int[] s;
        public Summ(int n)
        {
            if (n > 0)
                s = new int[n];
            else
                throw new Exception("Значение размерности массива должно быть больше 0");
        }
        public int this[int Index]
        {
            get
            {
                if (Index >= 0 && Index < s.Length)
                {
                    return s[Index];
                }
                else
                    throw new Exception("Индекс имеет недопустимое значение");
            }
            set
            {
                if (Index >= 0 && Index < s.Length)
                    s[Index] = value;
                else
                    throw new Exception("Индекс указан неправильно");
            }
        }

    }
}