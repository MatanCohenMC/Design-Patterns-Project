﻿using FacebookApp.Facades;
using System;
using System.Windows.Forms;

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
            labelLoading.Visible = true;
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
            if (InvokeRequired)
            {
                Invoke((Action)setPosts);
                return;
            }

            postBindingSource.DataSource = r_Posts.m_PostCollection;
            labelLoading.Visible = false;
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}