using System;
using System.Collections.Generic;
using System.Linq;
using FacebookWrapper.ObjectModel;

namespace FacebookApp.Models
{
    public class Posts
    {
        private readonly Login r_Login = Login.Instance;

        public FacebookObjectCollection<Post> GetPosts()
        {
            return r_Login.LoggedInUser.Posts;
        }

        public FacebookObjectCollection<Post> GetPostsByFilter(Func<Post, int, int, bool> i_Filter)
        {
            List<Post> postsList = r_Login.LoggedInUser.Posts.ToList();
            FacebookObjectCollection<Post> posts = new FacebookObjectCollection<Post>();

            foreach ((Post post, int index) in postsList.WithIndex())
            {
                if (i_Filter(post, index, postsList.Count))
                {
                    posts.Add(post);
                }
            }

            return posts;
        }
    }
}