using System;
using System.Threading;
using FacebookApp.Models;
using FacebookWrapper.ObjectModel;

namespace FacebookApp.Facades
{
    public class FriendsInUsersAgeRangeFacade
    {
        private readonly FriendsInUsersAgeRange r_FriendsInUsersAgeRange;
        private FacebookObjectCollection<User> m_FriendsInUserAgeRange;
        public event Action FriendsInUserAgeRangeUpdated;

        public FriendsInUsersAgeRangeFacade()
        {
            r_FriendsInUsersAgeRange = new FriendsInUsersAgeRange();
        }

        public FacebookObjectCollection<User> FriendsInUserAgeRange
        {
            get
            {
                return m_FriendsInUserAgeRange;
            }
        }

        public void UpdateFriendsInUsersAgeRange()
        {
            new Thread(() =>
                {
                    m_FriendsInUserAgeRange = r_FriendsInUsersAgeRange.GetFriendsInUsersAgeRange();
                    FriendsInUserAgeRangeUpdated?.Invoke();
                }).Start();
        }
    }
}