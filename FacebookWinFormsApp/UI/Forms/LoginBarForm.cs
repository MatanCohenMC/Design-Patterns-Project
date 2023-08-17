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
using FacebookWrapper.UI;


namespace FacebookApp.UI.Forms
{
    public partial class LoginBarForm : Form
    {
        public FacebookWrapper.LoginResult LoginResult { get; set; }
        public Action m_LoginButtonPressed;
        public Action m_LogoutButtonPressed;
        public Action<eFormName> m_OnSubFormButtonPressed;


        public LoginBarForm()
        {
            InitializeComponent();
            buttonLogout.Enabled = false;
            DisableMyProfileButton();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            m_LoginButtonPressed?.Invoke();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            m_LogoutButtonPressed?.Invoke();
        }

        private void buttonMyProfile_Click(object sender, EventArgs e)
        {
            m_OnSubFormButtonPressed?.Invoke(eFormName.UserProfileForm);
        }

        public void EnableMyProfileButton()
        {
            buttonMyProfile.Enabled = true;
        }
        public void DisableMyProfileButton()
        {
            buttonMyProfile.Enabled = false;
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

    }
}