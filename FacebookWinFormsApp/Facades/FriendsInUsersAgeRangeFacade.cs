using System;
using System.Threading;
using FacebookApp.Models;
using FacebookWrapper.ObjectModel;

namespace FacebookApp.Facades
{
    public class FriendsInUsersAgeRangeFacade
    {
        private readonly FriendsInUsersAgeRange r_FriendsInUsersAgeRange;
        public event Action FriendsInUserAgeRangeUpdated;

        public FriendsInUsersAgeRangeFacade()
        {
            r_FriendsInUsersAgeRange = new FriendsInUsersAgeRange();
        }

        public FacebookObjectCollection<User> FriendsInUserAgeRange { get; private set; }

        public void UpdateFriendsInUsersAgeRange()
        {
            new Thread(() =>
                {
                    FriendsInUserAgeRange = r_FriendsInUsersAgeRange.GetFriendsInUsersAgeRange();
                    FriendsInUserAgeRangeUpdated?.Invoke();
                }).Start();
        }
    }
}