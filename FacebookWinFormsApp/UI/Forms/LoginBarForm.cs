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
        public FacebookWrapper.LoginResult LoginResult { get; set; }
        public Action m_LoginButtonPressed;
        public Action m_LogoutButtonPressed;

        public LoginBarForm()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            m_LoginButtonPressed?.Invoke();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            m_LogoutButtonPressed?.Invoke();
        }

        private void pictureBoxUserProfile_Click(object sender, EventArgs e)
        {

        }

        public string TextBoxAppIdString
        {
            get
            {
                return textBoxAppID.Text;
            }
        }

        public Button ButtonLogin
        {
            get
            {
                return buttonLogin;
            }
        } 
        public Button ButtonLogout
        {
            get
            {
                return buttonLogout;
            }
        }


        public System.Windows.Forms.PictureBox PictureBoxUserProfile
        {
            get
            {
                return pictureBoxUserProfile;
            }
        }

        private void buttonMyProfile_Click(object sender, EventArgs e)
        {

        }
    }
}