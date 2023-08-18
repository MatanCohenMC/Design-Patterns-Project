﻿using System;
using System.Windows.Forms;
using FacebookApp.Models;

namespace FacebookApp.UI.Forms
{
    public partial class NavigationBarForm : Form
    {
        public Action<eFormName> m_OnSubFormButtonPressed;

        public NavigationBarForm()
        {
            InitializeComponent();
            DisableNavigationBar();
        }

        public void EnableNavigationBar()
        {
            tableLayoutNavBar.Enabled = true;
        }

        public void DisableNavigationBar()
        {
            tableLayoutNavBar.Enabled = false;
        }

        private void ButtonPosts_Click(object i_Sender, EventArgs i_EventArgs)
        {
            m_OnSubFormButtonPressed?.Invoke(eFormName.PostsForm);
        }

        private void ButtonAlbums_Click(object i_Sender, EventArgs i_EventArgs)
        {
            m_OnSubFormButtonPressed?.Invoke(eFormName.AlbumForm);
        }

        private void ButtonEvents_Click(object i_Sender, EventArgs i_EventArgs)
        {
            m_OnSubFormButtonPressed?.Invoke(eFormName.EventsForm);
        }

        private void ButtonGroups_Click(object i_Sender, EventArgs i_EventArgs)
        {
            m_OnSubFormButtonPressed?.Invoke(eFormName.GroupsForm);
        }

        private void ButtonLikedPages_Click(object i_Sender, EventArgs i_EventArgs)
        {
            m_OnSubFormButtonPressed?.Invoke(eFormName.LikedPagesForm);
        }

        private void buttonEventByLocation_Click(object i_Sender, EventArgs i_EventArgs)
        {
            m_OnSubFormButtonPressed?.Invoke(eFormName.EventsByLocationForm);
        }

        private void buttonPostsByDateRange_Click(object i_Sender, EventArgs i_EventArgs)
        {
            m_OnSubFormButtonPressed?.Invoke(eFormName.PostsByDateRangeForm);
        }

        private void buttonFriendsInMyAgeRange_Click(object i_Sender, EventArgs i_EventArgs)
        {
            m_OnSubFormButtonPressed?.Invoke(eFormName.FriendsInUsersAgeRangeForm);
        }

        private void buttonRandomMemory_Click(object i_Sender, EventArgs i_EventArgs)
        {
            m_OnSubFormButtonPressed?.Invoke(eFormName.RandomMemoryForm);
        }
    }
}