using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FacebookApp.Facades;
using FacebookApp.Interfaces;
using FacebookApp.Models;

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
        }
    }
}