﻿using System;
using System.Windows.Forms;

namespace LibraryManagement
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());  // Make sure this is the main form you want to open
        }
    }
}
