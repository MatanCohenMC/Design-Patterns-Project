using FacebookApp.Dtos;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookApp.Models
{
    public class Albums
    {
        private readonly Login r_Login = Login.Instance;

        public List<Dictionary<string, string>> m_DataList { get; private set; }

        public Albums()
        {
            m_DataList = new List<Dictionary<string, string>>();
        }

        public List<Dictionary<string, string>> FetchUserAlbums()
        {
            List<Dictionary<string, string>> dataList = new List<Dictionary<string, string>>();

            foreach(Album album in r_Login.LoggedInUser.Albums)
            {
                Dictionary<string, string> albumDictionary = new Dictionary<string, string>();

                if(album.Name != null)
                {
                    albumDictionary["ListBoxText"] = album.Name;
                    albumDictionary["Picture"] = album.PictureAlbumURL;
                    albumDictionary["Description"] = album.Description;
                    albumDictionary["Location"] = album.Location;
                }

                dataList.Add(albumDictionary);
            }

            if(dataList.Count == 0)
            {
                Dictionary<string, string> noAlbumDictionary = new Dictionary<string, string>();
                noAlbumDictionary["ListBoxText"] = "No Posts to retrieve :(";
                dataList.Add(noAlbumDictionary);
            }

            m_DataList = dataList;
            return dataList;
        }

        public void GetPictureAlbumURL(out string pictureAlbumURL, int selectedIndex)
        {
            Dictionary<string, string> albumData = m_DataList[selectedIndex];
            pictureAlbumURL = albumData["Picture"];
        }
    }
}