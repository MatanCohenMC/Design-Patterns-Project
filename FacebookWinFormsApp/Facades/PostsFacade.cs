using System.Threading;
using FacebookApp.Models;
using FacebookWrapper.ObjectModel;

namespace FacebookApp.Facades
{
    public class PostsFacade
    {
        private readonly Posts r_Posts;
        public FacebookObjectCollection<Post> Posts { get; private set; }

        public event System.Action PostsUpdated;

        public PostsFacade()
        {
            r_Posts = new Posts();
        }


        public void UpdatePosts()
        {
            new Thread(
                () =>
                    {
                        Posts = r_Posts.GetPosts();
                        PostsUpdated?.Invoke();
                    }).Start();
        }
    }
}