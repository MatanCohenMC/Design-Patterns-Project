using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FacebookApp.Models
{
    public class FriendsInUsersAgeRange
    {
        private readonly Login r_Login = Login.Instance;
        public List<Dictionary<string, string>> m_DataList { get; private set; }

        public FriendsInUsersAgeRange()
        {
            m_DataList = new List<Dictionary<string, string>>();
        }

        public List<Dictionary<string, string>> FetchUserLikedPages()
        {
            List<Dictionary<string, string>> dataList = new List<Dictionary<string, string>>();
            string myBirthdayStr = r_Login.LoggedInUser.Birthday; // Replace with your actual birthday in "dd/mm/yyyy" format
            DateTime myBirthday = DateTime.ParseExact(myBirthdayStr, "MM/dd/yyyy", null);
            DateTime startDate = myBirthday.AddYears(-2);
            DateTime endDate = myBirthday.AddYears(2);

            foreach (User friend in r_Login.LoggedInUser.Friends)
            {
                DateTime friendsBirthday = DateTime.ParseExact(friend.Birthday, "MM/dd/yyyy", null);

                if (friendsBirthday >= startDate && friendsBirthday <= endDate)
                {
                    Dictionary<string, string> friendsDictionary = new Dictionary<string, string>();

                    if (friend.Name != null)
                    {
                        friendsDictionary["ListBoxText"] = friend.Name;
                        friendsDictionary["Picture"] = friend.PictureLargeURL;
                        friendsDictionary["Birthday"] = friend.Birthday;
                        friendsDictionary["Hometown"] = friend.Hometown?.ToString();
                    }

                    dataList.Add(friendsDictionary);
                }

            }

            if (dataList.Count == 0)
            {
                Dictionary<string, string> noFriendsDictionary = new Dictionary<string, string>();
                noFriendsDictionary["ListBoxText"] = "No friends to retrieve.";
                dataList.Add(noFriendsDictionary);
            }

            m_DataList = dataList;
            return dataList;
        }

        public string GetBirthday(int i_SelectedIndex)
        {
            return m_DataList[i_SelectedIndex]["Birthday"];
        }
        public string GetLocation(int i_SelectedIndex)
        {
            return m_DataList[i_SelectedIndex]["Hometown"];
        }
        public string GetPictureUrl(int i_SelectedIndex)
        {
            return m_DataList[i_SelectedIndex]["Picture"];
        }
        public string GetFullName(int i_SelectedIndex)
        {
            return m_DataList[i_SelectedIndex]["ListBoxText"];
        }

    }
}
