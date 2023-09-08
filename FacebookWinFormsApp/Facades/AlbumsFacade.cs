using FacebookApp.Models;
using FacebookWrapper.ObjectModel;
using System;
using System.Threading;

namespace FacebookApp.Facades
{
    public class AlbumsFacade
    {
        private readonly Albums r_Albums;

        public event Action AlbumUpdated;

        public AlbumsFacade()
        {
            r_Albums = new Albums();
        }

        public FacebookObjectCollection<Album> Albums { get; private set; }

        public void UpdateAlbums()
        {
            new Thread(() =>
                {
                    Albums = r_Albums.GetAlbums();
                    AlbumUpdated?.Invoke();
                }).Start();
        }
    }
}