using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FacebookApp.Facades;
using FacebookApp.Models;

namespace FacebookApp.UI.Forms
{
    public partial class UserProfileForm : Form
    {
        private readonly UserProfileFacade r_UserProfile;

        public UserProfileForm()
        {
            InitializeComponent();
            r_UserProfile = new UserProfileFacade();
            r_UserProfile.UserProfileUpdated += setUserProfile;
        }

        private void userProfileForm_Load(object i_Sender, EventArgs i_EventArgs)
        {

            r_UserProfile.GetUserProfile();
        }

        private void setUserProfile()
        {
            if(InvokeRequired)
            {
                Invoke((Action)setUserProfile);
                return;
            }

            loginResultBindingSource.DataSource = r_UserProfile.LoginResult;
        }

        private void imageLargePictureBox_Click(object sender, EventArgs e)
        {

        }

        private void birthdayLabel_Click(object sender, EventArgs e)
        {

        }

        private void birthdayTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void emailLabel_Click(object sender, EventArgs e)
        {

        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void panelUserDetails_Paint(object sender, PaintEventArgs e)
        {

        }

        private void localeLabel_Click(object sender, EventArgs e)
        {

        }

        private void localeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void nameLabel_Click(object sender, EventArgs e)
        {

        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}