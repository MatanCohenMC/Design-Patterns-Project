﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookApp.Dtos;
using FacebookApp.Interfaces;
using FacebookApp.Models;
using FacebookWrapper.ObjectModel;

namespace FacebookApp.UI.Forms
{
    public partial class PostsForm : Form, IComponentHandler, IDataHandler, IListBoxHandler
    {
        private readonly Posts r_Posts = new Posts();
        public Action<string> m_FetchButtonPressed;

        public PostsForm()
        {
            InitializeComponent();
        }

        private void listBoxPosts_SelectedIndexChanged(object i_Sender, EventArgs e)
        {
            setComments();
            setCreatedDate();
            setPicture();
            setLocation();
            setTotalLikes();
            setCaption();
        }

        private void setCaption()
        {
            string postCaption;

            textBoxPostsCaption.Text = string.Empty;
            r_Posts.GetCaption(out postCaption, listBoxPosts.SelectedIndex);
            if (postCaption != null)
            {
                textBoxPostsCaption.Text = postCaption;
            }
            else
            {
                textBoxPostsCaption.Text = "No caption";
            }
        }

        private void setTotalLikes()
        {
            string postTotalLikes;

            textBoxLikes.Text = string.Empty;
            r_Posts.GetTotalLikes(out postTotalLikes, listBoxPosts.SelectedIndex);
            textBoxLikes.Text = postTotalLikes;
        }

        private void setLocation()
        {
            string postLocation;

            textBoxPostLocation.Text = string.Empty;
            r_Posts.GetLocation(out postLocation, listBoxPosts.SelectedIndex);
            textBoxPostLocation.Text = postLocation;
        }

        private void setPicture()
        {
            string PictureAlbumURL;

            r_Posts.GetPictureURL(out PictureAlbumURL, listBoxPosts.SelectedIndex);
            if (PictureAlbumURL != null)
            {
                pictureBoxPosts.LoadAsync(PictureAlbumURL);
            }
            else
            {
                pictureBoxPosts.Image = null;
            }
        }

        private void setCreatedDate()
        {
            string postCreatedDate;

            textBoxCreatedDate.Text = String.Empty;
            r_Posts.GetCreatedDate(out postCreatedDate, listBoxPosts.SelectedIndex);
            textBoxCreatedDate.Text = postCreatedDate;
        }

        private void setComments()
        {
            ICollection<Comment> postComments;

            r_Posts.GetComments(out postComments, listBoxPosts.SelectedIndex);
            listBoxComments.Items.Clear();
            if(postComments == null)
            {
                listBoxComments.Items.Add("Unknown");
            }
            else if (postComments.Count == 0)
            {
                listBoxComments.Items.Add("No comments");
            }
            else
            {
                foreach (Comment comment in postComments)
                {
                    listBoxComments.Items.Add(comment.ToString());
                }
            }
        }

        private void fetch_posts_button_Click(object i_Sender, EventArgs e)
        {
            m_FetchButtonPressed?.Invoke("PostsForm");
        }

        public void FetchListBoxData(out List<Dictionary<string, string>> DataList)
        {
            DataList = r_Posts.FetchUserPosts();
        }

        public ListBox GetListBox()
        {
            return this.listBoxPosts;
        }
    }
}