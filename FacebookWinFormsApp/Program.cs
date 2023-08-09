using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using FacebookApp.Controllers;
using FacebookWrapper;
using FacebookApp.UI.Forms;
using FacebookApp;

namespace FacebookApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            /*Clipboard.SetText("design.patterns20cc");
            FacebookService.s_UseForamttedToStrings = true;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain());*/

            Application.SetCompatibleTextRenderingDefault(false);
            var formsController = FormsController.Instance;
            formsController.Start();
        }
    }
}
