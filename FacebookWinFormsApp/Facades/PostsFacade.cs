using System;
using System.Threading;
using FacebookApp.Models;
using FacebookWrapper.ObjectModel;

namespace FacebookApp.Facades
{
    public class PostsFacade
    {
        private readonly Posts r_Posts;
        public FacebookObjectCollection<Post> Posts { get; private set; }
        public FacebookObjectCollection<Post> PostsByDateRange { get; private set; }

        private FacebookObjectCollection<Post> randomPosts;
        public Post RandomPost { get; private set; }

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
        
        public void UpdateRandomPost()
        {
            new Thread(
                () =>
                    {
                        //RandomPost = r_Posts.GetRandomPost();
                        Random random = new Random();
                        bool isRandomSet = false;
                        int randomIndex = 0;
                        randomPosts = this.r_Posts.GetPostsByFilter(
                            (i_Post, i_Index, i_Count) =>
                                {
                                    if(!isRandomSet)
                                    {
                                        randomIndex = random.Next(0, i_Count);
                                        isRandomSet = true;
                                    }
                                    return (i_Index == randomIndex);

                                });
                        RandomPost = randomPosts[0];
                        PostsUpdated?.Invoke();
                    }).Start();
        }

        //public void UpdatePostsByDateRange1(DateTime i_DateTimeFrom, DateTime i_DateTimeTo)
        //{
        //    new Thread(
        //        () =>
        //            {
        //                PostsByDateRange = r_Posts.GetPostsByDateRange(i_DateTimeFrom, i_DateTimeTo);
        //                PostsUpdated?.Invoke();
        //            }).Start();
        //}

        public void UpdatePostsByDateRange(DateTime i_DateTimeFrom, DateTime i_DateTimeTo)
        {
            new Thread(
                () =>
                    {
                        this.PostsByDateRange = this.r_Posts.GetPostsByFilter(
                            (i_Post, i_Index, i_Count) => (i_Post.CreatedTime != null
                                                  && ((DateTime)i_Post.CreatedTime >= i_DateTimeFrom
                                                      && (DateTime)i_Post.CreatedTime <= i_DateTimeTo)));
                        PostsUpdated?.Invoke();
                    }).Start();
        }
    }
}