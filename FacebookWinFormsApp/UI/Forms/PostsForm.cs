using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookApp.Dtos;
using FacebookApp.Interfaces;
using FacebookApp.Models;
using FacebookWrapper.ObjectModel;

namespace FacebookApp.UI.Forms
{
    public partial class PostsForm : Form, IComponentHandler, IDataHandler, IPictureHandler, IDateHandler, ILocationHandler, ICaptionHandler, ICommentsHandler, ISetFetchAction, ISetSelectedIndexAction
    {
        private readonly Posts r_Posts = new Posts();
        //private readonly string r_FormName = "PostsForm";
        private readonly eFormName r_FormName = eFormName.PostsForm;
        public Action<eFormName> m_FetchButtonPressed;
        public Action<eFormName> m_SelectedIndexChanged;

        public PostsForm()
        {
            InitializeComponent();
        }

        private void fetch_posts_button_Click(object i_Sender, EventArgs e)
        {
            m_FetchButtonPressed?.Invoke(r_FormName);
        }

        public void FetchListBoxData(out List<Dictionary<string, string>> DataList)
        {
            DataList = r_Posts.FetchUserPosts();
        }

        public ListBox GetListBox()
        {
            return this.listBoxPosts;
        }

        private void listBoxPosts_SelectedIndexChanged(object i_Sender, EventArgs e)
        {
            m_SelectedIndexChanged?.Invoke(r_FormName);
        }


        public PictureBox GetPictureBox()
        {
            return pictureBoxPosts;
        }

        public string GetPictureUrlByIndex(int i_Index)
        {
            return r_Posts.GetPictureUrl(i_Index);
        }

        public TextBox GetLocationTextBox()
        {
            return textBoxLocation;
        }

        public string GetLocationByIndex(int i_Index)
        {
            return r_Posts.GetLocation(i_Index);
        }
        
        public TextBox GetCaptionTextBox()
        {
            return textBoxCaption;
        }

        public string GetCaptionByIndex(int i_Index)
        {
            return r_Posts.GetCaption(i_Index);
        }

        public TextBox GetDateTextBox()
        {
            return textBoxDate;
        }

        public string GetDateByIndex(int i_Index)
        {
            return r_Posts.GetDate(i_Index);
        }

        public ListBox GetCommentsListBox()
        {
            return listBoxComments;
        }

        public ICollection<Comment> GetCommentsByIndex(int i_Index)
        {
            return r_Posts.GetComments(i_Index);
        }

        public void SetFetchAction(Action<eFormName> action)
        {
            m_FetchButtonPressed += action;
        }

        public void SetSelectedIndexAction(Action<eFormName> action)
        {
            m_SelectedIndexChanged += action;
        }
    }
}