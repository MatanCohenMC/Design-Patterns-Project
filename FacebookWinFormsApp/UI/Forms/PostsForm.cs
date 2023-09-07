using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FacebookApp.Facades;
using FacebookApp.Interfaces;
using FacebookApp.Models;
using FacebookWrapper.ObjectModel;

namespace FacebookApp.UI.Forms
{
    public partial class PostsForm : Form
    {
        private readonly PostsFacade r_Posts;

        public PostsForm()
        {
            InitializeComponent();
            r_Posts = new PostsFacade();
            r_Posts.PostsUpdated += setPosts;
        }

        private void buttonFetchPosts_Click(object i_Sender, EventArgs i_EventArgs)
        {
            r_Posts.UpdatePosts();
        }

        public void SetPictureBox(string i_PostPictureUrl)
        {
            if (i_PostPictureUrl != null)
            {
                pictureBoxPosts.LoadAsync(i_PostPictureUrl);
            }
            else
            {
                pictureBoxPosts.Image = null;
            }
        }

        private void setPosts()
        {
            if(InvokeRequired)
            {
                Invoke((Action)setPosts);
                return;
            }

            postBindingSource.DataSource = r_Posts.Posts;


        }
    }
}