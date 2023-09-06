using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FacebookApp.Interfaces;
using FacebookApp.Models;
using FacebookWrapper.ObjectModel;

namespace FacebookApp.UI.Forms
{
    public partial class PostsByDateRangeForm : Form
    {
        private readonly Posts r_Posts = new Posts();

        public PostsByDateRangeForm()
        {
            InitializeComponent();
        }

        private void buttonFetchPostsByDate_Click(object i_Sender, EventArgs i_EventArgs)
        {
            fetchPostsByDate();
        }

        private void fetchPostsByDate() // does work
        {
            DateTime dateTimeFrom = dateTimePickerFrom.Value;
            DateTime dateTimeTo = dateTimePickerTo.Value;
            postBindingSource.DataSource = new List<Post>(); // Empty list
            postBindingSource.DataSource = r_Posts.GetPostsByDateRange(dateTimeFrom, dateTimeTo);
        }
    }
}