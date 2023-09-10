using System;
using System.Windows.Forms;
using FacebookApp.Facades;

namespace FacebookApp.UI.Forms
{
    public partial class FriendsInUsersAgeRangeForm : Form
    {
        private readonly FriendsInUsersAgeRangeFacade r_FriendsInUsersAgeRangeFacade;

        public FriendsInUsersAgeRangeForm()
        {
            InitializeComponent();
            r_FriendsInUsersAgeRangeFacade = new FriendsInUsersAgeRangeFacade();
            r_FriendsInUsersAgeRangeFacade.FriendsInUserAgeRangeUpdated += setFriendsInUsersAgeRangeFacade;
        }

        private void buttonFetchFriends_Click(object sender, EventArgs e)
        {
            labelLoading.Visible = true;
            r_FriendsInUsersAgeRangeFacade.UpdateFriendsInUsersAgeRange();
        }

        private void setFriendsInUsersAgeRangeFacade()
        {
            if (InvokeRequired)
            {
                Invoke((Action)setFriendsInUsersAgeRangeFacade);
                return;
            }

            loginResultBindingSource.DataSource = r_FriendsInUsersAgeRangeFacade.FriendsInUserAgeRange;
            labelLoading.Visible = false;
        }
    }
}