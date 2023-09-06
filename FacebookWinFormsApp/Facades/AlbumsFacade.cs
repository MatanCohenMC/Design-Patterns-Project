using FacebookApp.Models;
using FacebookWrapper.ObjectModel;
using System.Collections.Generic;
using System.Threading;

namespace FacebookApp.Facades
{
    public class AlbumsFacade
    {
        private readonly Albums r_Albums;
        private FacebookObjectCollection<Album> m_Albums;

        public AlbumsFacade()
        {
            r_Albums = new Albums();
        }

        public FacebookObjectCollection<Album> Albums
        {
            get
            {
                new Thread(() => m_Albums = r_Albums.GetAlbums()).Start();
                return m_Albums;
            }
        }
    }
}