﻿using FacebookApp.Models;
using FacebookWrapper.ObjectModel;
using System;
using System.Threading;

namespace FacebookApp.Facades
{
    public class PostsFacade
    {
        private readonly Posts r_Posts;

        public event System.Action PostsUpdated;

        public FacebookObjectCollection<Post> Posts { get; private set; }

        public FacebookObjectCollection<Post> PostsByDateRange { get; private set; }

        public Post RandomPost { get; private set; }

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
                        RandomPost = r_Posts.GetRandomPost();
                        PostsUpdated?.Invoke();
                    }).Start();
        }

        public void UpdatePostsByDateRange(DateTime i_DateTimeFrom, DateTime i_DateTimeTo)
        {
            new Thread(
                () =>
                    {
                        PostsByDateRange = r_Posts.GetPostsByDateRange(i_DateTimeFrom, i_DateTimeTo);
                        PostsUpdated?.Invoke();
                    }).Start();
        }
    }
}