using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookApp.Dtos;
using FacebookWrapper.ObjectModel;

namespace FacebookApp.Models
{
    public class Groups
    {
        private readonly Login r_Login = Login.Instance;
        public List<Dictionary<string, string>> m_DataList { get; private set; }

        public List<Dictionary<string, string>> FetchUserEvents()
        {
            List<Dictionary<string, string>> dataList = new List<Dictionary<string, string>>();

            foreach (Group group in r_Login.LoggedInUser.Groups)
            {
                Dictionary<string, string> groupDictionary = new Dictionary<string, string>();

                if (group.Name != null)
                {
                    groupDictionary["ListBoxText"] = group.Name;
                    groupDictionary["Description"] = group.Description;
                    groupDictionary["Picture"] = group.PictureNormalURL;
                }

                dataList.Add(groupDictionary);
            }

            if (dataList.Count == 0)
            {
                Dictionary<string, string> noGroupsDictionary = new Dictionary<string, string>();
                noGroupsDictionary["ListBoxText"] = "No groups to retrieve.";
                dataList.Add(noGroupsDictionary);
            }

            m_DataList = dataList;
            return dataList;
        }

        public string GetPictureUrl(int i_SelectedIndex)
        {
            return m_DataList[i_SelectedIndex]["Picture"];
        }

        public string GetDescription(int i_SelectedIndex)
        {
            return m_DataList[i_SelectedIndex]["Description"];
        }
    }
}