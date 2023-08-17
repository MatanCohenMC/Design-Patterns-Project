using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                if (group.Name != null)
                {
                    Dictionary<string, string> groupDictionary = new Dictionary<string, string>();

                    groupDictionary["ListBoxText"] = group.Name;
                    groupDictionary["Description"] = group.Description;
                    groupDictionary["Picture"] = group.PictureNormalURL;
                    dataList.Add(groupDictionary);
                }
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