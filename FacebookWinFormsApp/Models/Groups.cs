using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace FacebookApp.Models
{
    public class Groups
    {
        private readonly Login r_Login = Login.Instance;

        public List<Dictionary<string, string>> DataList { get; private set; }

        public List<Dictionary<string, string>> FetchUserEvents()
        {
            List<Dictionary<string, string>> dataList = new List<Dictionary<string, string>>();

            foreach(Group group in r_Login.LoggedInUser.Groups)
            {
                if(group.Name != null)
                {
                    Dictionary<string, string> groupDictionary = new Dictionary<string, string>();

                    groupDictionary["ListBoxText"] = group.Name;
                    groupDictionary["Description"] = group.Description;
                    groupDictionary["Picture"] = group.PictureNormalURL;
                    dataList.Add(groupDictionary);
                }
            }

            DataList = dataList;
            return dataList;
        }

        public string GetPictureUrl(int i_SelectedIndex)
        {
            return DataList[i_SelectedIndex]["Picture"];
        }

        public string GetDescription(int i_SelectedIndex)
        {
            return DataList[i_SelectedIndex]["Description"];
        }
    }
}