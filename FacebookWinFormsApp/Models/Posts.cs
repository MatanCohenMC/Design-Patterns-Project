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

        public FacebookObjectCollection<Post> GetPostsByDateRange(DateTime i_DateTimeFrom, DateTime i_DateTimeTo)
        {
            List<Post> postsList = r_Login.LoggedInUser.Posts.ToList();
            FacebookObjectCollection<Post> posts = new FacebookObjectCollection<Post>();

            foreach (Post post in postsList)
            {
                if (post.CreatedTime >= i_DateTimeFrom || post.CreatedTime <= i_DateTimeTo)
                {
                    posts.Add(post);
                }
            }

            return posts;
        }
    }
}