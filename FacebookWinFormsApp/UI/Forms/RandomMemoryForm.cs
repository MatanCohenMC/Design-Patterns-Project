using System;
using System.Windows.Forms;
using FacebookApp.Interfaces;
using FacebookApp.Models;

namespace FacebookApp.UI.Forms
{
    public partial class RandomMemoryForm : Form, IPictureHandler, ISetFetchAction
    {
        private readonly eFormName r_FormName = eFormName.RandomMemoryForm;
        private readonly Posts r_Posts = new Posts();
        public Action<eFormName> m_FetchButtonPressed;

        public RandomMemoryForm()
        {
            InitializeComponent();
        }

        public PictureBox GetPictureBox()
        {
            return pictureBoxMemory;
        }

        public void SetFetchAction(Action<eFormName> i_Action)
        {
            m_FetchButtonPressed += i_Action;
        }

        private void buttonFetchMemory_Click(object i_Sender, EventArgs i_EventArgs)
        {
            m_FetchButtonPressed?.Invoke(r_FormName);
        }

        public void GetRandomPost(out string o_PictureUrl, out string o_Date, out string o_Location, out string o_Text)
        {
            r_Posts.GetRandomPost(out o_PictureUrl, out o_Date, out o_Location, out o_Text);
        }

        public void SetLocationTextBox(string i_Location)
        {
            textBoxLocation.Text = i_Location;
        }

        public void SetDateTextBox(string i_Date)
        {
            textBoxDate.Text = i_Date;
        }

        public void SetPostsTextTextBox(string i_PostsText)
        {
            textBoxPostsText.Text = i_PostsText;
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