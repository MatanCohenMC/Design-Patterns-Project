using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace FacebookApp.Models
{
    public class Albums
    {
        private readonly Login r_Login = Login.Instance;

        public FacebookObjectCollection<Album> GetAlbums()
        {
            return r_Login.LoggedInUser.Albums;
        }
    }
}