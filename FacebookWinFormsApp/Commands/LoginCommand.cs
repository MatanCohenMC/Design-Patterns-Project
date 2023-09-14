using System;
using System.Drawing;
using System.Windows.Forms;
using FacebookApp.Controllers;
using FacebookApp.Models;
using FacebookApp.UI.Forms;

namespace FacebookApp.Commands
{
    internal class LoginCommand : ICommand
    {
        private readonly Login r_Login;
        private readonly LoginBarForm r_LoginForm;
        private readonly FormsController r_Controller;

        public LoginCommand(LoginBarForm i_LoginForm, FormsController i_Controller)
        {
            r_Login = Login.Instance;
            r_LoginForm = i_LoginForm;
            r_Controller = i_Controller;
        }

        public void Execute()
        {
            string appId = r_LoginForm.TextBoxAppIdString;

            r_Login.LoginToApp(appId);
            try
            {
                if (r_Login.LoginResult != null && r_Login.LoginResult.LoggedInUser != null)
                {
                    r_LoginForm.ButtonLogin.Text = "Logged in";
                    r_LoginForm.ButtonLogin.BackColor = Color.LightGreen;
                    r_LoginForm.PictureBoxUserProfile.ImageLocation = r_Login.LoginResult.LoggedInUser.PictureNormalURL;
                    r_LoginForm.ButtonLogin.Enabled = false;
                    r_LoginForm.ButtonLogout.Enabled = true;
                    r_Controller.EnableNavBar();
                    r_Controller.EnableLoginBar();
                }
                else
                {
                    if (String.IsNullOrEmpty(r_Login?.LoginResult?.ErrorMessage))
                    {
                        MessageBox.Show("Login Failed, try again");
                    }
                    else
                    {
                        MessageBox.Show(r_Login.LoginResult.ErrorMessage, "Login Failed");
                    }

                    r_LoginForm.PictureBoxUserProfile.ImageLocation = null;
                }
            }
            catch (NullReferenceException)
            {
                r_LoginForm.PictureBoxUserProfile.ImageLocation = null;
            }
        }
    }
}
