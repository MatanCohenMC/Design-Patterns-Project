using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FacebookApp.Models;

namespace FacebookApp.UI.Forms
{
    public partial class UserProfileForm : Form
    {
        private readonly UserProfile r_UserProfile = new UserProfile();

        public UserProfileForm()
        {
            InitializeComponent();
        }

        private void userProfileForm_Load(object i_Sender, EventArgs i_EventArgs)
        {
            loginResultBindingSource.DataSource = r_UserProfile.GetUserProfile().LoggedInUser;
        }
    }
}