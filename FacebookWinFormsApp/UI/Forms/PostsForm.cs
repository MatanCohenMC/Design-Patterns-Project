using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FacebookApp.Interfaces;
using FacebookApp.Models;
using FacebookWrapper.ObjectModel;

namespace FacebookApp.UI.Forms
{
    public partial class PostsForm : Form
    {
        private readonly Posts r_Posts = new Posts();

        public PostsForm()
        {
            InitializeComponent();
        }

        private void buttonFetchPosts_Click(object i_Sender, EventArgs i_EventArgs)
        {
            fetchPosts();
        }

        private void fetchPosts()
        {
            postBindingSource.DataSource = r_Posts.GetPosts();
        }
    }
}