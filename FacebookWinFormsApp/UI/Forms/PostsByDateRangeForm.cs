using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FacebookApp.Interfaces;
using FacebookApp.Models;
using FacebookWrapper.ObjectModel;

namespace FacebookApp.UI.Forms
{
    public partial class PostsByDateRangeForm : Form,
                                                IComponentHandler,
                                                IDataHandler,
                                                IPictureHandler,
                                                IDateHandler,
                                                ILocationHandler,
                                                ICaptionHandler,
                                                ICommentsHandler,
                                                ISetFetchAction,
                                                ISetSelectedIndexAction,
                                                IPictureByIndexHandler
    {
        private readonly eFormName r_FormName = eFormName.PostsByDateRangeForm;
        private readonly Posts r_Posts = new Posts();
        public Action<eFormName> m_FetchButtonPressed;
        public Action<eFormName> m_SelectedIndexChanged;

        public PostsByDateRangeForm()
        {
            InitializeComponent();
        }

        public TextBox GetCaptionTextBox()
        {
            return textBoxCaption;
        }

        public string GetCaptionByIndex(int i_Index)
        {
            return r_Posts.GetCaption(i_Index);
        }

        public ListBox GetCommentsListBox()
        {
            return listBoxComments;
        }

        public ICollection<Comment> GetCommentsByIndex(int i_Index)
        {
            return r_Posts.GetComments(i_Index);
        }

        public ListBox GetListBox()
        {
            return listBoxPosts;
        }

        public void FetchListBoxData(out List<Dictionary<string, string>> DataList)
        {
            DateTime dateTimeFrom = this.dateTimePickerFrom.Value;
            DateTime dateTimeTo = this.dateTimePickerTo.Value;
            DataList = r_Posts.FetchUserPostsByDateRange(dateTimeFrom, dateTimeTo);
        }

        public TextBox GetDateTextBox()
        {
            return textBoxDate;
        }

        public string GetDateByIndex(int i_Index)
        {
            return r_Posts.GetDate(i_Index);
        }

        public TextBox GetLocationTextBox()
        {
            return textBoxLocation;
        }

        public string GetLocationByIndex(int i_Index)
        {
            return r_Posts.GetLocation(i_Index);
        }

        public string GetPictureUrlByIndex(int i_Index)
        {
            return r_Posts.GetPictureUrl(i_Index);
        }

        public PictureBox GetPictureBox()
        {
            return pictureBoxPosts;
        }


        public void SetFetchAction(Action<eFormName> i_Action)
        {
            m_FetchButtonPressed += i_Action;
        }

        public void SetSelectedIndexAction(Action<eFormName> i_Action)
        {
            m_SelectedIndexChanged += i_Action;
        }

        private void buttonFetchPostsByDate_Click(object i_Sender, EventArgs i_EventArgs)
        {
            m_FetchButtonPressed?.Invoke(r_FormName);
        }

        private void listBoxPosts_SelectedIndexChanged(object i_Sender, EventArgs i_EventArgs)
        {
            m_SelectedIndexChanged?.Invoke(r_FormName);
        }
    }
}