using System;
using System.Windows.Forms;
using FacebookApp.Facades;

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