using System;
using FacebookWrapper.ObjectModel;

namespace FacebookApp.Models
{
    public class FriendsInUsersAgeRange
    {
        private readonly Login r_Login = Login.Instance;

        public FacebookObjectCollection<User> GetFriendsInUsersAgeRange()
        {
            FacebookObjectCollection<User> friends = r_Login.LoggedInUser.Friends;
            FacebookObjectCollection<User> friendsInAgeRange = new FacebookObjectCollection<User>();
            string myBirthdayStr = r_Login.LoggedInUser.Birthday;
            DateTime myBirthday = DateTime.ParseExact(myBirthdayStr, "MM/dd/yyyy", null);
            DateTime startDate = myBirthday.AddYears(-2);
            DateTime endDate = myBirthday.AddYears(2);

            foreach (User friend in friends)
            {
                DateTime friendsBirthday = DateTime.ParseExact(friend.Birthday, "MM/dd/yyyy", null);

                if (friendsBirthday >= startDate && friendsBirthday <= endDate)
                {
                    friendsInAgeRange.Add(friend);
                }
            }

            return friendsInAgeRange;
        }
    }
}