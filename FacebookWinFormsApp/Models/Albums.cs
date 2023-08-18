using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace FacebookApp.Models
{
    public class Albums
    {
        private readonly Login r_Login = Login.Instance;

        public Albums()
        {
            DataList = new List<Dictionary<string, string>>();
        }

        public List<Dictionary<string, string>> DataList { get; private set; }

        public List<Dictionary<string, string>> FetchUserAlbums()
        {
            DataList.Clear();
            List<Dictionary<string, string>> dataList = new List<Dictionary<string, string>>();

            foreach(Album album in r_Login.LoggedInUser.Albums)
            {
                Dictionary<string, string> albumDictionary = new Dictionary<string, string>();

                if(album.Name != null)
                {
                    albumDictionary["ListBoxText"] = album.Name;
                    albumDictionary["Picture"] = album.PictureAlbumURL;
                    albumDictionary["Location"] = album.Location;
                    albumDictionary["PictureCount"] = album.Count.ToString();
                    albumDictionary["CreatedTime"] = album.CreatedTime.ToString();
                }

                dataList.Add(albumDictionary);
            }

            DataList = dataList;
            return dataList;
        }

        public string GetPictureUrl(int i_SelectedIndex)
        {
            return DataList[i_SelectedIndex]["Picture"];
        }

        public string GetLocation(int i_SelectedIndex)
        {
            return DataList[i_SelectedIndex]["Location"];
        }

        public string GetCreatedTime(int i_SelectedIndex)
        {
            return DataList[i_SelectedIndex]["CreatedTime"];
        }

        public string GetPictureCount(int i_SelectedIndex)
        {
            return DataList[i_SelectedIndex]["PictureCount"];
        }
    }
}