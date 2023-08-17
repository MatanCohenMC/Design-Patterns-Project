using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FacebookApp.Interfaces;
using FacebookApp.Models;

namespace FacebookApp.UI.Forms
{
    public partial class FriendsInUsersAgeRangeForm : Form,
                                                      IComponentHandler,
                                                      IDataHandler,
                                                      IPictureHandler,
                                                      IPictureByIndexHandler,
                                                      ILocationHandler,
                                                      IBirthdayHandler,
                                                      IFullNameHandler,
                                                      ISetFetchAction,
                                                      ISetSelectedIndexAction
    {
        private readonly eFormName r_FormName = eFormName.FriendsInUsersAgeRangeForm;
        private readonly FriendsInUsersAgeRange r_FriendsInUsersAgeRange = new FriendsInUsersAgeRange();
        public Action<eFormName> m_FetchButtonPressed;
        public Action<eFormName> m_SelectedIndexChanged;

        public FriendsInUsersAgeRangeForm()
        {
            InitializeComponent();
        }

        public TextBox GetBirthdayTextBox()
        {
            return textBoxBirthday;
        }

        public string GetBirthdayByIndex(int i_Index)
        {
            return r_FriendsInUsersAgeRange.GetBirthday(i_Index);
        }

        public ListBox GetListBox()
        {
            return this.listBoxFriends;
        }

        public void FetchListBoxData(out List<Dictionary<string, string>> i_DataList)
        {
            i_DataList = r_FriendsInUsersAgeRange.FetchUserLikedPages();
        }

        public TextBox GetFullNameTextBox()
        {
            return textBoxFullName;
        }

        public string GetFullNameByIndex(int i_Index)
        {
            return r_FriendsInUsersAgeRange.GetFullName(i_Index);
        }

        public TextBox GetLocationTextBox()
        {
            return textBoxHometown;
        }

        public string GetLocationByIndex(int i_Index)
        {
            return r_FriendsInUsersAgeRange.GetLocation(i_Index);
        }

        public string GetPictureUrlByIndex(int i_Index)
        {
            return r_FriendsInUsersAgeRange.GetPictureUrl(i_Index);
        }

        public PictureBox GetPictureBox()
        {
            return pictureBoxFriendPicture;
        }

        public void SetFetchAction(Action<eFormName> i_Action)
        {
            m_FetchButtonPressed += i_Action;
        }

        public void SetSelectedIndexAction(Action<eFormName> i_Action)
        {
            m_SelectedIndexChanged += i_Action;
        }

        private void buttonFetchFriends_Click(object i_Sender, EventArgs i_EventArgs)
        {
            m_FetchButtonPressed?.Invoke(r_FormName);
        }

        private void listBoxFriends_SelectedIndexChanged(object i_Sender, EventArgs i_EventArgs)
        {
            m_SelectedIndexChanged?.Invoke(r_FormName);
        }
    }
}