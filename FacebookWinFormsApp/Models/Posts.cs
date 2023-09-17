using System;
using System.Collections.Generic;
using System.Linq;
using FacebookWrapper.ObjectModel;



namespace FacebookApp.Models
{
    public static class EnumExtension
    {
        public static IEnumerable<(T item, int index)> WithIndex<T>(this IEnumerable<T> self)
            => self.Select((item, index) => (item, index));
    }
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

            if (posts.Count > 0)
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
                if (post.CreatedTime != null && ((DateTime)post.CreatedTime >= i_DateTimeFrom && (DateTime)post.CreatedTime <= i_DateTimeTo))
                {
                    posts.Add(post);
                }
            }

            return posts;
        }

        public FacebookObjectCollection<Post> GetPostsByFilter(Func<Post, int, int, bool> i_Filter)
        {
            List<Post> postsList = r_Login.LoggedInUser.Posts.ToList();
            FacebookObjectCollection<Post> posts = new FacebookObjectCollection<Post>();

            foreach (var (post, index) in postsList.WithIndex())
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