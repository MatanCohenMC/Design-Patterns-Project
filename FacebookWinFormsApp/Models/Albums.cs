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

        public FacebookObjectCollection<Album> GetAlbums()
        {
            return r_Login.LoggedInUser.Albums;
        }
    }
}