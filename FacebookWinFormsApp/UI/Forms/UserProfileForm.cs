using System;
using System.Windows.Forms;
using FacebookApp.Facades;

namespace FacebookApp.UI.Forms
{
    public partial class UserProfileForm : Form
    {
        private readonly UserProfileFacade r_UserProfileFacade;

        public UserProfileForm()
        {
            InitializeComponent();
            r_UserProfileFacade = new UserProfileFacade();
            r_UserProfileFacade.UserProfileUpdated += setUserProfileFacade;
        }

        private void userProfileForm_Load(object i_Sender, EventArgs i_EventArgs)
        {
            r_UserProfileFacade.GetUserProfile();
        }

        private void setUserProfileFacade()
        {
            if (InvokeRequired)
            {
                Invoke((Action)setUserProfileFacade);
                return;
            }

            loginResultBindingSource.DataSource = r_UserProfileFacade.LoginResult;
        }
    }
}