using System.Threading;
using FacebookApp.Models;
using FacebookWrapper.ObjectModel;

namespace FacebookApp.Facades
{
    public class PostsFacade
    {
        private readonly Posts r_Posts;
        private FacebookObjectCollection<Post> m_Posts;

        public PostsFacade()
        {
            r_Posts = new Posts();
        }

        public FacebookObjectCollection<Post> Posts
        {
            get
            {
                new Thread(() => m_Posts = r_Posts.GetPosts()).Start();
                return m_Posts;
            }
        }

    }
}