using System.Threading;
using FacebookApp.Models;
using FacebookWrapper.ObjectModel;

namespace FacebookApp.Facades
{
    public class LikedPagesFacade
    {
        private readonly LikedPages r_LikedPages;
        public event System.Action LikedPagesUpdated;

        public LikedPagesFacade()
        {
            r_LikedPages = new LikedPages();
        }

        public FacebookObjectCollection<Page> LikedPages { get; private set; }

        public void UpdateLikedPages()
        {
            new Thread(
                () =>
                    {
                        LikedPages = r_LikedPages.GetLikedPages();
                        LikedPagesUpdated?.Invoke();
                    }).Start();
        }
    }
}