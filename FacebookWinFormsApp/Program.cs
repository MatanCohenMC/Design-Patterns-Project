using System;
using System.Windows.Forms;
using FacebookApp.Controllers;

namespace FacebookApp
{
    public static class Program
    {
        [STAThread]
        public static void Main()
        {
            Application.SetCompatibleTextRenderingDefault(false);
            FormsController formsController = new FormsController();

            formsController.Start();
        }
    }
}