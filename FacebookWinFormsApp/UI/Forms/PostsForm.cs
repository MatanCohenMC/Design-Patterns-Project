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
    public partial class PostsForm : Form, IComponentHandler, IDataHandler, IListBoxHandler
    {
        private readonly Posts r_Posts = new Posts();
        public Action<string> m_FetchButtonPressed;

        public PostsForm()
        {
            InitializeComponent();
        }

        private void listBoxPosts_SelectedIndexChanged(object i_Sender, EventArgs e)
        {
            setComments();
            setCreatedDate();
            setPicture();
        }

        private void setPicture()
        {
            throw new NotImplementedException();
        }

        private void setCreatedDate()
        {
            string postCreatedDate;
            r_Posts.GetCreatedDate(out postCreatedDate, listBoxPosts.SelectedIndex);

            if (postCreatedDate != null && postCreatedDate != String.Empty)
            {
                textBoxCreatedDate.Text = postCreatedDate;
            }
            else
            {
                textBoxCreatedDate.Text = "No created date mentioned.";
            }
        }

        private void setComments()
        {
            ICollection<Comment> postComments;
            r_Posts.GetComments(out postComments, listBoxPosts.SelectedIndex);
            listBoxComments.Items.Clear();

            if (postComments.Count == 0)
            {
                listBoxComments.Items.Add("No comments");
            }
            else
            {
                foreach (Comment comment in postComments)
                {
                    listBoxComments.Items.Add(comment.ToString());
                }
            }
        }

        private void fetch_posts_button_Click(object i_Sender, EventArgs e)
        {
            m_FetchButtonPressed?.Invoke("PostsForm");
        }

        public void FetchListBoxData(out List<Dictionary<string, string>> DataList)
        {
            DataList = r_Posts.FetchUserPosts();
        }

        public ListBox GetListBox()
        {
            return this.listBoxPosts;
        }
    }
}