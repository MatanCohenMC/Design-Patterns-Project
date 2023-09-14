using FacebookApp.Controllers;
using FacebookApp.Models;
using FacebookApp.UI.Forms;
using FacebookWrapper;

namespace FacebookApp
{
    internal class FacebookLogoutStrategy : ILogoutStrategy
    {
        private readonly Login r_Login;

        public FacebookLogoutStrategy()
        {
            r_Login = Login.Instance;
        }

        public void ExecuteLogout(LoginBarForm i_LoginForm, FormsController i_Controller)
        {
            if (i_LoginForm != null)
            {
                string appId = i_LoginForm.TextBoxAppIdString;
                r_Login?.LoginToApp(appId);
                FacebookService.LogoutWithUI();
                i_LoginForm.ButtonLogin.Text = "Login";
                i_LoginForm.ButtonLogin.BackColor = i_LoginForm.ButtonLogout.BackColor;
                i_LoginForm.LoginResult = null;
                i_LoginForm.ButtonLogin.Enabled = true;
                i_LoginForm.ButtonLogout.Enabled = false;
                i_Controller.DisableNavBar();
                i_Controller.DisableLoginBar();
                i_LoginForm.PictureBoxUserProfile.Image = null;
                i_Controller.RemoveCurrentDisplayForm();
            }
        }
    }
}
