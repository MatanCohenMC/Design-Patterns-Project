using System;
using System.Windows.Forms;
using FacebookApp.Facades;

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
            if (InvokeRequired)
            {
                Invoke((Action)setUserProfile);
                return;
            }

            loginResultBindingSource.DataSource = r_UserProfile.LoginResult;
        }
    }
}