﻿using System;
using System.Windows.Forms;
using FacebookApp.Controllers;

namespace FacebookApp
{
    public static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.SetCompatibleTextRenderingDefault(false);
            var formsController = FormsController.Instance;
            formsController.Start();
        }
    }
}