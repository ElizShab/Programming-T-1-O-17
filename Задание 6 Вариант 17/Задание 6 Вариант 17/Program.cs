﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Задание_6_Вариант_17
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main_F());
        }
    }
}
