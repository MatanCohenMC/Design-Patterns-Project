using FacebookApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookApp.Interfaces;

namespace FacebookApp.UI.Forms
{
    public partial class RandomMemoryForm : Form, IPictureHandler, ISetFetchAction
    {
        private readonly Posts r_Posts = new Posts();
        //private readonly string r_FormName = "PostsByDateRangeForm";
        private readonly eFormName r_FormName = eFormName.RandomMemoryForm;
        public Action<eFormName> m_FetchButtonPressed;

        public RandomMemoryForm()
        {
            InitializeComponent();
        }

        private void buttonFetchMemory_Click(object sender, EventArgs e)
        {
            m_FetchButtonPressed?.Invoke(r_FormName);
        }

        public PictureBox GetPictureBox()
        {
            return pictureBoxMemory;
        }

        public void GetRandomPost(out string o_pictureUrl, out string o_Date, out string o_Location, out string o_Text)
        {
            r_Posts.GetRandomPost(out o_pictureUrl, out o_Date, out o_Location, out o_Text);
        }

        public void SetFetchAction(Action<eFormName> action)
        {
            m_FetchButtonPressed += action;
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
    }
}
