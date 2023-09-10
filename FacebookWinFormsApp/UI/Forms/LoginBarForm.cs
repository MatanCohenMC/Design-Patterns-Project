using System;
using System.Windows.Forms;
using FacebookApp.Models;

namespace FacebookApp.UI.Forms
{
    public partial class LoginBarForm : Form
    {
        public Action m_LoginButtonPressed;
        public Action m_LogoutButtonPressed;
        public Action<eFormName> m_OnSubFormButtonPressed;

        public LoginBarForm()
        {
            InitializeComponent();
            ButtonLogout.Enabled = false;
            DisableMyProfileButton();
        }

        public FacebookWrapper.LoginResult LoginResult { get; set; }

        public Button ButtonLogin { get; private set; }

        public Button ButtonLogout { get; private set; }

        public PictureBox PictureBoxUserProfile { get; private set; }

        public string TextBoxAppIdString => textBoxAppID.Text;

        private void buttonLogin_Click(object i_Sender, EventArgs i_EventArgs)
        {
            m_LoginButtonPressed?.Invoke();
        }

        private void buttonLogout_Click(object i_Sender, EventArgs i_EventArgs)
        {
            m_LogoutButtonPressed?.Invoke();
        }

        private void buttonMyProfile_Click(object i_Sender, EventArgs i_EventArgs)
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
    }
}