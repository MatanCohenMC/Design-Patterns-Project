using FacebookApp.Facades;
using System;
using System.Windows.Forms;

namespace FacebookApp.UI.Forms
{
    public partial class FriendsInUsersAgeRangeForm : Form
    {
        private readonly FriendsInUsersAgeRangeFacade r_FriendsInUsersAgeRange;

        public FriendsInUsersAgeRangeForm()
        {
            InitializeComponent();
            r_FriendsInUsersAgeRange = new FriendsInUsersAgeRangeFacade();
            r_FriendsInUsersAgeRange.FriendsInUserAgeRangeUpdated += setFriendsInUsersAgeRange;
        }

        private void buttonFetchFriends_Click(object sender, EventArgs e)
        {
            labelLoading.Visible = true;
            r_FriendsInUsersAgeRange.UpdateFriendsInUsersAgeRange();
        }

        private void setFriendsInUsersAgeRange()
        {
            if (InvokeRequired)
            {
                Invoke((Action)setFriendsInUsersAgeRange);
                return;
            }

            loginResultBindingSource.DataSource = r_FriendsInUsersAgeRange.FriendsInUserAgeRange;
            labelLoading.Visible = false;
        }

        private void imageLargePictureBox_Click(object sender, EventArgs e)
        {

        }
    }
}