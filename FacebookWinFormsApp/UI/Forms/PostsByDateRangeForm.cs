using System;
using System.Windows.Forms;
using FacebookApp.Facades;
using FacebookWrapper.ObjectModel;

namespace FacebookApp.UI.Forms
{
    public partial class PostsByDateRangeForm : Form
    {
        private readonly PostsFacade r_PostsFacade;

        public PostsByDateRangeForm()
        {
            InitializeComponent();
            r_PostsFacade = new PostsFacade();
            r_PostsFacade.PostsUpdated += setPostsFacadeByDate;
        }

        private void buttonFetchPostsByDate_Click(object i_Sender, EventArgs i_EventArgs)
        {
            labelLoading.Visible = true;
            DateTime dateTimeFrom = dateTimePickerFrom.Value;
            DateTime dateTimeTo = dateTimePickerTo.Value;

            r_PostsFacade.UpdatePostsByDateRange(dateTimeFrom, dateTimeTo);
        }

        private void listBoxPosts_SelectedIndexChanged(object sender, EventArgs e)
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

        private void setPostsFacadeByDate()
        {
            if (InvokeRequired)
            {
                Invoke((Action)setPostsFacadeByDate);
                return;
            }

            postBindingSource.DataSource = r_PostsFacade.PostsByDateRange;
            labelLoading.Visible = false;
        }
    }
}