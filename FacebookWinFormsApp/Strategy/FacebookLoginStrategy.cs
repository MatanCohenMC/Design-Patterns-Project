using System;
using System.Drawing;
using System.Windows.Forms;
using FacebookApp.Controllers;
using FacebookApp.Models;
using FacebookApp.UI.Forms;

namespace FacebookApp
{
    internal class FacebookLoginStrategy : ILoginStrategy
    {
        private readonly Login r_Login;

        public FacebookLoginStrategy()
        {
            r_Login = Login.Instance;
        }

        public void ExecuteLogin(LoginBarForm i_LoginForm, FormsController i_Controller)
        {
            string appId = i_LoginForm.TextBoxAppIdString;

            r_Login.LoginToApp(appId);
            try
            {
                if (r_Login.LoginResult != null && r_Login.LoginResult.LoggedInUser != null)
                {
                    i_LoginForm.ButtonLogin.Text = "Logged in";
                    i_LoginForm.ButtonLogin.BackColor = Color.LightGreen;
                    i_LoginForm.PictureBoxUserProfile.ImageLocation = r_Login.LoginResult.LoggedInUser.PictureNormalURL;
                    i_LoginForm.ButtonLogin.Enabled = false;
                    i_LoginForm.ButtonLogout.Enabled = true;
                    i_Controller.EnableNavBar();
                    i_Controller.EnableLoginBar();
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

                    i_LoginForm.PictureBoxUserProfile.ImageLocation = null;
                }
            }
            catch (NullReferenceException)
            {
                i_LoginForm.PictureBoxUserProfile.ImageLocation = null;
            }
        }
    }
}
