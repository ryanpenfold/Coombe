﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoombeImageEditor
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (args.Length <= 0)
            {
                Application.Run(new Dialogs.MainPage());
            } else
            {
                if(args.Contains("--test"))
                {
                    Application.Run(new Form1());
                } else
                {
                    
                }
            }
        }
    }
}
