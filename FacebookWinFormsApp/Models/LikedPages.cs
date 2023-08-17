using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace FacebookApp.Models
{
    public class LikedPages
    {
        private readonly Login r_Login = Login.Instance;
        public List<Dictionary<string, string>> m_DataList { get; private set; }

        public LikedPages()
        {
            m_DataList = new List<Dictionary<string, string>>();
        }

        public List<Dictionary<string, string>> FetchUserLikedPages()
        {
            List<Dictionary<string, string>> dataList = new List<Dictionary<string, string>>();

            foreach (Page page in r_Login.LoggedInUser.LikedPages)
            {
                if (page.Name != null)
                {
                    Dictionary<string, string> postDictionary = new Dictionary<string, string>();

                    postDictionary["ListBoxText"] = page.Name;
                    postDictionary["Description"] = page.Description;
                    postDictionary["Picture"] = page.PictureURL;
                    dataList.Add(postDictionary);
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