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
    class MasB
    {
        private int[] t;
        public MasB(int n)
        {
            if (n > 0)
                t = new int[n];
            else
                throw new Exception("Значение размерности массива должно быть больше 0");
        }
        public int this[int Index]
        {
            get
            {
                if (Index >= 0 && Index < t.Length)                
                    return t[Index];                
                else
                    throw new Exception("Индекс имеет недопустимое значение");
            }
            set
            {
                if (Index >= 0 && Index < t.Length)
                    t[Index] = value;
                else
                    throw new Exception("Индекс указан неправильно");
            }
        }
        
    }

}