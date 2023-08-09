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
        private Login m_Login;
        private User m_LoggedInUser;

        //dictionary with key of album name and value of dictionary of album data
        //the inner dictionary has key of album data name and value of album data value
        private Dictionary<string, Dictionary<string, string> > m_AlbumsDataDictionary;
        public Albums()
        {
            m_Login= Login.Instance;
        }
         
        public List<DataDto> FetchUserAlbums()
        {
            List<DataDto> albumsNames = new List<DataDto>();

            foreach(Album album in m_Login.LoggedInUser.Albums)
            {
                DataDto dataDto = new DataDto();
                dataDto.AddName(album.Name);
                dataDto.AddPicture(album.PictureAlbumURL);
                dataDto.AddDescription(album.Description);
                dataDto.AddDate(album.CreatedTime.ToString());
                albumsNames.Add(dataDto);
            }

            return albumsNames;
        }
    }
}