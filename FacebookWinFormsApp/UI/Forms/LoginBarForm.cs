using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookApp.Models;


namespace FacebookApp.UI.Forms
{
    public partial class LoginBarForm : Form
    {
        private readonly Login r_Login = new Login();
        private User m_LoggedInUser = null;
        private FacebookWrapper.LoginResult m_LoginResult;
        public Action m_LoginButtonPressed;

        public LoginBarForm()
        {
            InitializeComponent();
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            m_LoginButtonPressed?.Invoke();
        }

        public void Login()
        {
            if (m_LoginResult == null)
            {
                r_Login.LoginToApp(textBoxAppID.Text);
                m_LoginResult = r_Login.m_LoginResult;
                if (string.IsNullOrEmpty(m_LoginResult.ErrorMessage))
                {
                    ButtonLogin.Text = "Logged in";
                    // $"Logged in as {m_LoginResult.LoggedInUser.Name}";
                    ButtonLogin.BackColor = Color.LightGreen;
                    pictureBoxUserProfile.ImageLocation = m_LoginResult.LoggedInUser.PictureNormalURL;
                    ButtonLogin.Enabled = false;
                    ButtonLogout.Enabled = true;
                }
                else
                {
                    MessageBox.Show(m_LoginResult.ErrorMessage, "Login Failed");
                }
            }
        }


        /*public User Login()
        {
            *//*m_LoggedInUser = r_Login.LoginToApp();
            pictureBoxUserProfile.ImageLocation = m_LoggedInUser.PictureNormalURL;
            ButtonLogin.Enabled = false;
            ButtonLogin.Text = $"Logged in as {m_LoggedInUser.Name}";

            return m_LoggedInUser;*//*

            m_LoggedInUser = r_Login.LoginToApp();
            return m_LoggedInUser;
        }*/

        private void pictureBoxUserProfile_Click(object sender, EventArgs e)
        {

        }
    }
}