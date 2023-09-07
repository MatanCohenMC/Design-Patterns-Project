using System;
using System.Windows.Forms;
using FacebookApp.Facades;
using FacebookApp.Interfaces;
using FacebookApp.Models;

namespace FacebookApp.UI.Forms
{
    public partial class RandomMemoryForm : Form
    {
        private readonly PostsFacade r_Posts;
        
        public RandomMemoryForm()
        {
            InitializeComponent();
            r_Posts = new PostsFacade();
            r_Posts.PostsUpdated += setRandomMemory;
        }

        private void buttonFetchMemory_Click(object i_Sender, EventArgs i_EventArgs)
        {
            r_Posts.UpdateRandomPost();
        }

        public void SetPictureBox(string i_PostPictureUrl)
        {
            if(i_PostPictureUrl != null)
            {
                pictureBoxMemory.LoadAsync(i_PostPictureUrl);
            }
            else
            {
                pictureBoxMemory.Image = null;
            }
        }

        private void setRandomMemory()
        {
            if (InvokeRequired)
            {
                Invoke((Action)setRandomMemory);
                return;
            }

            postBindingSource.DataSource = r_Posts.RandomPost;
        }
    }
}