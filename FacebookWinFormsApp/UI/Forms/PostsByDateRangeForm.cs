using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FacebookApp.Facades;
using FacebookApp.Interfaces;
using FacebookApp.Models;
using FacebookWrapper.ObjectModel;

namespace FacebookApp.UI.Forms
{
    public partial class PostsByDateRangeForm : Form
    {
        private readonly PostsFacade r_Posts;

        public PostsByDateRangeForm()
        {
            InitializeComponent();
            r_Posts = new PostsFacade();
            r_Posts.PostsUpdated += setPostsByDate;
        }

        private void buttonFetchPostsByDate_Click(object i_Sender, EventArgs i_EventArgs)
        {
            DateTime dateTimeFrom = dateTimePickerFrom.Value;
            DateTime dateTimeTo = dateTimePickerTo.Value;

            r_Posts.UpdatePostsByDateRange(dateTimeFrom, dateTimeTo);
        }

        private void setPostsByDate()
        {
            if (InvokeRequired)
            {
                Invoke((Action)setPostsByDate);
                return;
            }

            postBindingSource.DataSource = r_Posts.PostsByDateRange;
        }
    }
}