using System;
using System.Windows.Forms;
using FacebookApp.Facades;

namespace FacebookApp.UI.Forms
{
    public partial class RandomMemoryForm : Form
    {
        private readonly PostsFacade r_PostsFacade;

        public RandomMemoryForm()
        {
            InitializeComponent();
            r_PostsFacade = new PostsFacade();
            r_PostsFacade.PostsUpdated += setRandomPost;
        }

        private void buttonFetchMemory_Click(object i_Sender, EventArgs i_EventArgs)
        {
            getRandomPost();
        }

        private void getRandomPost()
        {
            r_PostsFacade.UpdateRandomPost();
        }

        private void setRandomPost()
        {
            if (InvokeRequired)
            {
                Invoke((Action)setRandomPost);
                return;
            }

            postBindingSource.DataSource = r_PostsFacade.RandomPost;
        }
    }
}