using System;
using System.Windows.Forms;
using FacebookApp.Facades;

namespace FacebookApp.UI.Forms
{
    public partial class PostsByDateRangeForm : Form
    {
        private readonly PostsFacade r_PostsFacade;

        public PostsByDateRangeForm()
        {
            InitializeComponent();
            r_PostsFacade = new PostsFacade();
            r_PostsFacade.PostsUpdated += setPostsFacadeByDate;
        }

        private void buttonFetchPostsByDate_Click(object i_Sender, EventArgs i_EventArgs)
        {
            getPostsByDateRange();
        }

        private void getPostsByDateRange()
        {
            labelLoading.Visible = true;
            DateTime dateTimeFrom = dateTimePickerFrom.Value;
            DateTime dateTimeTo = dateTimePickerTo.Value;

            r_PostsFacade.UpdatePostsByDateRange(dateTimeFrom, dateTimeTo);
        }

        private void setPostsFacadeByDate()
        {
            if (InvokeRequired)
            {
                Invoke((Action)setPostsFacadeByDate);
                return;
            }

            postBindingSource.DataSource = r_PostsFacade.PostsByDateRange;
            labelLoading.Visible = false;
        }
    }
}