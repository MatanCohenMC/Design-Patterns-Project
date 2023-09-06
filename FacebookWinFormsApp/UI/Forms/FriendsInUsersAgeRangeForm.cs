using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FacebookApp.Interfaces;
using FacebookApp.Models;

namespace FacebookApp.UI.Forms
{
    public partial class FriendsInUsersAgeRangeForm : Form
    {
        private readonly FriendsInUsersAgeRange r_FriendsInUsersAgeRange = new FriendsInUsersAgeRange();

        public FriendsInUsersAgeRangeForm()
        {
            InitializeComponent();
        }

        private void buttonFetchFriends_Click(object sender, EventArgs e)
        {
            fetchFriendsInAgeRange();
        }

        private void fetchFriendsInAgeRange()
        {
            loginResultBindingSource.DataSource = r_FriendsInUsersAgeRange.GetFriendsInUsersAgeRange();
        }
    }
}