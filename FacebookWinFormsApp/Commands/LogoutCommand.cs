using FacebookApp.Controllers;
using FacebookApp.Models;
using FacebookApp.UI.Forms;
using FacebookWrapper;

namespace FacebookApp.Commands
{
    internal class LogoutCommand : ICommand
    {
        private readonly Login r_Login;
        private readonly LoginBarForm r_LoginForm;
        private readonly FormsController r_FormsController;

        public LogoutCommand(LoginBarForm i_LoginForm, FormsController i_FormsController)
        {
            r_Login = Login.Instance;
            r_LoginForm = i_LoginForm;
            r_FormsController = i_FormsController;
        }

        public void Execute()
        {
            if (r_LoginForm != null)
            {
                string appId = r_LoginForm.TextBoxAppIdString;
                r_Login?.LoginToApp(appId);
                FacebookService.LogoutWithUI();
                r_LoginForm.ButtonLogin.Text = "Login";
                r_LoginForm.ButtonLogin.BackColor = r_LoginForm.ButtonLogout.BackColor;
                r_LoginForm.LoginResult = null;
                r_LoginForm.ButtonLogin.Enabled = true;
                r_LoginForm.ButtonLogout.Enabled = false;
                r_FormsController.DisableNavBar();
                r_FormsController.DisableLoginBar();
                r_LoginForm.PictureBoxUserProfile.Image = null;
                r_FormsController.RemoveCurrentDisplayForm();
            }
        }
    }
}
