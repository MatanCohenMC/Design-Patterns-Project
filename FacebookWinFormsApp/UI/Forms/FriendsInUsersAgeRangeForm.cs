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
using FacebookApp.Models;
using FacebookWrapper.ObjectModel;

namespace FacebookApp.UI.Forms
{
    public partial class FriendsInUsersAgeRangeForm : Form, IComponentHandler, IDataHandler, IPictureHandler,ILocationHandler,IBirthdayHandler, IFullNameHandler, ISetFetchAction, ISetSelectedIndexAction
    {
        private readonly FriendsInUsersAgeRange r_FriendsInUsersAgeRange = new FriendsInUsersAgeRange();
        public Action<eFormName> m_FetchButtonPressed;
        public Action<eFormName> m_SelectedIndexChanged;
        private readonly eFormName r_FormName = eFormName.FriendsInUsersAgeRangeForm;

        public FriendsInUsersAgeRangeForm()
        {
            InitializeComponent();
        }

        private void buttonFetchFriends_Click(object sender, EventArgs e)
        {
            m_FetchButtonPressed?.Invoke(r_FormName);
        }

        private void listBoxFriends_SelectedIndexChanged(object sender, EventArgs e)
        {
            m_SelectedIndexChanged?.Invoke(r_FormName);
        }

        public void FetchListBoxData(out List<Dictionary<string, string>> DataList)
        {
            DataList = r_FriendsInUsersAgeRange.FetchUserLikedPages();
        }
        public void SetFetchAction(Action<eFormName> action)
        {
            m_FetchButtonPressed += action;
        }

        public void SetSelectedIndexAction(Action<eFormName> action)
        {
            m_SelectedIndexChanged += action;
        }

        public ListBox GetListBox()
        {
            return this.listBoxFriends;
        }

        public PictureBox GetPictureBox()
        {
            return pictureBoxFriendPicture;
        }

        public string GetPictureUrlByIndex(int i_Index)
        {
            return r_FriendsInUsersAgeRange.GetPictureUrl(i_Index);
        }

        public TextBox GetFullNameTextBox()
        {
            return textBoxFullName;
        }

        public string GetFullNameByIndex(int i_Index)
        {
            return r_FriendsInUsersAgeRange.GetFullName(i_Index);
        }

        public TextBox GetBirthdayTextBox()
        {
            return textBoxBirthday;
        }

        public string GetBirthdayByIndex(int i_Index)
        {
            return r_FriendsInUsersAgeRange.GetBirthday(i_Index);
        }

        public TextBox GetLocationTextBox()
        {
            return textBoxHometown;
        }
        public string GetLocationByIndex(int i_Index)
        {
            return r_FriendsInUsersAgeRange.GetLocation(i_Index);
        }
    }
}
