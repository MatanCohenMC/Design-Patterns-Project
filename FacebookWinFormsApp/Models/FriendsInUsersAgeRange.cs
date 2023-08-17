using System;
using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace FacebookApp.Models
{
    public class FriendsInUsersAgeRange
    {
        private readonly Login r_Login = Login.Instance;

        public FriendsInUsersAgeRange()
        {
            DataList = new List<Dictionary<string, string>>();
        }

        public List<Dictionary<string, string>> DataList { get; private set; }

        public List<Dictionary<string, string>> FetchUserLikedPages()
        {
            List<Dictionary<string, string>> dataList = new List<Dictionary<string, string>>();
            string myBirthdayStr = r_Login.LoggedInUser.Birthday;
            DateTime myBirthday = DateTime.ParseExact(myBirthdayStr, "MM/dd/yyyy", null);
            DateTime startDate = myBirthday.AddYears(-2);
            DateTime endDate = myBirthday.AddYears(2);

            foreach(User friend in r_Login.LoggedInUser.Friends)
            {
                DateTime friendsBirthday = DateTime.ParseExact(friend.Birthday, "MM/dd/yyyy", null);

                if(friendsBirthday >= startDate && friendsBirthday <= endDate)
                {
                    if(friend.Name != null)
                    {
                        Dictionary<string, string> friendsDictionary = new Dictionary<string, string>();

                        friendsDictionary["ListBoxText"] = friend.Name;
                        friendsDictionary["Picture"] = friend.PictureLargeURL;
                        friendsDictionary["Birthday"] = friend.Birthday;
                        friendsDictionary["Hometown"] = friend.Hometown?.ToString();
                        dataList.Add(friendsDictionary);
                    }
                }
            }

            DataList = dataList;
            return dataList;
        }

        public string GetBirthday(int i_SelectedIndex)
        {
            return DataList[i_SelectedIndex]["Birthday"];
        }

        public string GetLocation(int i_SelectedIndex)
        {
            return DataList[i_SelectedIndex]["Hometown"];
        }

        public string GetPictureUrl(int i_SelectedIndex)
        {
            return DataList[i_SelectedIndex]["Picture"];
        }

        public string GetFullName(int i_SelectedIndex)
        {
            return DataList[i_SelectedIndex]["ListBoxText"];
        }
    }
}