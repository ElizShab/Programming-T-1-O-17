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
    class MasA
    {
        private int[] m;        
                
        public MasA(int n)
        {
            if (n > 0)
            {
                m = new int[n];                
            }

            else
                throw new Exception("Значение размерности массива должно быть больше 0");
        }
        public int this[int Index]
        {
            get
            {
                
                if (Index >= 0 && Index < m.Length)
                { 
                    return m[Index];
                }
                else
                    throw new Exception("Индекс имеет недопустимое значение");
            }
            set
            {
                if (Index >= 0 && Index < m.Length)
                    m[Index] = value;
                else
                    throw new Exception("Индекс указан неправильно");
            }
        }

        public int [] Mas
        {
            get
            {
                int[] mas= new int [m.Length];
                m.CopyTo (mas,0);
                for (int i = 0; i < m.Length; i++)
                {
                    for (int j = 0; j < m.Length - 1;j++ )
                        if (mas[i] > mas[j])
                        {
                            int z = mas[i];
                            mas[i] = mas[j];
                            mas[j] = z;
                        }
                }
                return mas;
            }
        }
        }
    }
