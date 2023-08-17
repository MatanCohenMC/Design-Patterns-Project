using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace FacebookApp.Models
{
    public class LikedPages
    {
        private readonly Login r_Login = Login.Instance;

        public LikedPages()
        {
            DataList = new List<Dictionary<string, string>>();
        }

        public List<Dictionary<string, string>> DataList { get; private set; }

        public List<Dictionary<string, string>> FetchUserLikedPages()
        {
            List<Dictionary<string, string>> dataList = new List<Dictionary<string, string>>();

            foreach(Page page in r_Login.LoggedInUser.LikedPages)
            {
                if(page.Name != null)
                {
                    Dictionary<string, string> postDictionary = new Dictionary<string, string>();

                    postDictionary["ListBoxText"] = page.Name;
                    postDictionary["Description"] = page.Description;
                    postDictionary["Picture"] = page.PictureURL;
                    dataList.Add(postDictionary);
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