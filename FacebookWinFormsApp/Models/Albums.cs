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
                    albumDictionary["PictureCount"] = album.Count.ToString(); // new
                    albumDictionary["UpdatedTime"] = album.UpdateTime.ToString();
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

        /*public void GetPictureAlbumURL(out string i_PictureAlbumUrl, int i_SelectedIndex)
        {
            Dictionary<string, string> albumData = m_DataList[i_SelectedIndex];
            i_PictureAlbumUrl = albumData["Picture"];
        }*/

        public string GetPictureURL(int i_SelectedIndex)
        {
            return m_DataList[i_SelectedIndex]["Picture"];
        }

        public void GetDescription(out string i_AlbumDescription, int i_SelectedIndex)
        {
            Dictionary<string, string> albumData = m_DataList[i_SelectedIndex];
            i_AlbumDescription = albumData["Description"];
        }

        /*public void GetLocation(out string i_AlbumLocation, int i_SelectedIndex)
        {
            Dictionary<string, string> albumData = m_DataList[i_SelectedIndex];
            i_AlbumLocation = albumData["Location"];
        }*/

        public string GetLocation(int i_SelectedIndex)
        {
            return m_DataList[i_SelectedIndex]["Location"];
        }

        public void GetUpdatedTime(out string i_AlbumUpdatedTime, int i_SelectedIndex)
        {
            Dictionary<string, string> albumData = m_DataList[i_SelectedIndex];
            i_AlbumUpdatedTime = albumData["UpdatedTime"];
        }

        public void GetPictureCount(out string i_AlbumPictureCount, int i_SelectedIndex)
        {
            Dictionary<string, string> albumData = m_DataList[i_SelectedIndex];
            i_AlbumPictureCount = albumData["PictureCount"];
        }
    }
}