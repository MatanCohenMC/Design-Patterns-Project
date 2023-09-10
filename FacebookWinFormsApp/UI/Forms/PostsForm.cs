using System;
using System.Windows.Forms;
using FacebookApp.Facades;
using FacebookWrapper.ObjectModel;

namespace FacebookApp.UI.Forms
{
    public partial class PostsForm : Form
    {
        private readonly PostsFacade r_PostsFacade;

        public PostsForm()
        {
            InitializeComponent();
            r_PostsFacade = new PostsFacade();
            r_PostsFacade.PostsUpdated += setPostsFacade;
        }

        private void buttonFetchPosts_Click(object i_Sender, EventArgs i_EventArgs)
        {
            labelLoading.Visible = true;
            r_PostsFacade.UpdatePosts();
        }

        private void listBoxPosts_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            setPictureBox();
        }

        private void setPictureBox()
        {
            if (listBoxPosts.SelectedIndex >= 0)
            {
                Post selectedPost = listBoxPosts.SelectedItem as Post;

                if (selectedPost != null && !string.IsNullOrEmpty(selectedPost.PictureURL))
                {
                    setPictureUrlToPictureBox(selectedPost.PictureURL);
                }
                else
                {
                    setPictureUrlToPictureBox(null);
                }
            }
            else
            {
                setPictureUrlToPictureBox(null);
            }
        }

        private void setPictureUrlToPictureBox(string i_PostPictureUrl)
        {
            if (i_PostPictureUrl != null)
            {
                pictureBoxPost.LoadAsync(i_PostPictureUrl);
            }
            else
            {
                pictureBoxPost.Image = null;
            }
        }

        private void setPostsFacade()
        {
            if (InvokeRequired)
            {
                Invoke((Action)setPostsFacade);
                return;
            }

            postBindingSource.DataSource = r_PostsFacade.Posts;
            labelLoading.Visible = false;
        }
    }
}