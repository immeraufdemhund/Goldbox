﻿using Goldbox.Engine;
using Goldbox.Engine.DependencyResolution;
using System;
using System.Windows.Forms;

namespace Goldbox.Gui
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            IoC.Initialize();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var display = GoldboxEngineFactory.GetDisplay();
            var mainForm = new MainForm(display);
            Application.Run(mainForm);
        }
    }
}
