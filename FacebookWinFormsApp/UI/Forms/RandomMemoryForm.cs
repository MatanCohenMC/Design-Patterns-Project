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
            r_PostsFacade.PostsUpdated += setRandomMemory;
        }

        private void buttonFetchMemory_Click(object i_Sender, EventArgs i_EventArgs)
        {
            r_PostsFacade.UpdateRandomPost();
        }

        private void setRandomMemory()
        {
            if (InvokeRequired)
            {
                Invoke((Action)setRandomMemory);
                return;
            }

            postBindingSource.DataSource = r_PostsFacade.RandomPost;
        }
    }
}