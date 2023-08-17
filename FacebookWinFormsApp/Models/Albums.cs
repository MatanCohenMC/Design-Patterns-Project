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
        bool m_IsDataFetched = false;
        public Albums()
        {
            m_DataList = new List<Dictionary<string, string>>();
        }

        public List<Dictionary<string, string>> FetchUserAlbums()
        {
            m_IsDataFetched = false;
            m_DataList.Clear();
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
                    albumDictionary["UpdatedTime"] = album.CreatedTime.ToString();
                }

                dataList.Add(albumDictionary);
            }

            if(dataList.Count == 0)
            {
                Dictionary<string, string> noAlbumDictionary = new Dictionary<string, string>();
                noAlbumDictionary["ListBoxText"] = "No albums to retrieve.";
                dataList.Add(noAlbumDictionary);
            }

            m_DataList = dataList;
            m_IsDataFetched = true;
            return dataList;
        }

        public string GetPictureUrl(int i_SelectedIndex)
        {
            return m_DataList[i_SelectedIndex]["Picture"];
        }

        public string GetLocation(int i_SelectedIndex)
        {
            return m_DataList[i_SelectedIndex]["Location"];
        }

        public string GetUpdatedTime(int i_SelectedIndex)
        {
            return m_DataList[i_SelectedIndex]["UpdatedTime"];
        }

        public string GetPictureCount(int i_SelectedIndex)
        {
            return m_DataList[i_SelectedIndex]["PictureCount"];
        }

        public void GetRandomPictureUrl(out string o_pictureUrl, out string o_date)
        {
            if(!m_IsDataFetched)
                m_DataList = FetchUserAlbums();

            Random random = new Random();
            int randomIndex = random.Next(0, m_DataList.Count);
            o_pictureUrl = m_DataList[randomIndex]["Picture"];
            o_date = m_DataList[randomIndex]["UpdatedTime"];
        }
    }
}