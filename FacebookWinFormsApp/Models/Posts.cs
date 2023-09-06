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

        public Post GetRandomPost()
        {
            List<Post> posts = r_Login.LoggedInUser.Posts.ToList();
            Post randomPost = null;

            if(posts.Count > 0)
            {
                Random random = new Random();
                int randomIndex = random.Next(0, posts.Count);

                randomPost = posts[randomIndex];
            }

            return randomPost;
        }
    }
}