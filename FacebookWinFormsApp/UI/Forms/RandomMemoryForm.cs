using System;
using System.Windows.Forms;
using FacebookApp.Interfaces;
using FacebookApp.Models;

namespace FacebookApp.UI.Forms
{
    public partial class RandomMemoryForm : Form
    {
        private readonly Posts r_Posts = new Posts();
        
        public RandomMemoryForm()
        {
            InitializeComponent();
        }

        private void buttonFetchMemory_Click(object i_Sender, EventArgs i_EventArgs)
        {
            postBindingSource.DataSource = r_Posts.GetRandomPost();
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
    }
}