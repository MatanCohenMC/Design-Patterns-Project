using System.Threading;
using FacebookApp.Models;
using FacebookWrapper.ObjectModel;

namespace FacebookApp.Facades
{
    public class LikedPagesFacade
    {
        private readonly LikedPages r_LikedPages;
        private FacebookObjectCollection<Page> m_LikedPages;

        public LikedPagesFacade(){
            r_LikedPages = new LikedPages();
        }

        public FacebookObjectCollection<Page> LikedPages
        {
            get
            {
                new Thread(() => m_LikedPages = r_LikedPages.GetLikedPages()).Start();
                return m_LikedPages;
            }
        }

    }
}