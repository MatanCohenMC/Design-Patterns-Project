using System;
using System.Collections.Generic;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace FacebookApp.Models
{
    public class FriendsInUsersAgeRange
    {
        private readonly Login r_Login = Login.Instance;

        public FacebookObjectCollection<User> GetFriendsInUsersAgeRange()
        {
            return r_Login.LoggedInUser.Friends;
        }
    }
}