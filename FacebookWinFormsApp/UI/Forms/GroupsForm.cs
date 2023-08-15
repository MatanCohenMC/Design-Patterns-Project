﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookApp.Models;
using FacebookApp.Interfaces;
using FacebookApp.Dtos;

namespace FacebookApp.UI.Forms
{
    public partial class GroupsForm : Form, IComponentHandler, IDataHandler, IDescriptionHandler, IPictureHandler
    {
        private Groups r_Groups = new Groups();
        private readonly string r_FormName = "GroupsForm";
        public Action<string> m_FetchButtonPressed;
        public Action<string> m_SelectedIndexChanged;

        public GroupsForm()
        {
            InitializeComponent();
        }

        private void fetch_groups_button_Click(object sender, EventArgs e)
        {
            m_FetchButtonPressed?.Invoke("GroupsForm");
        }
        private void listBoxGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            m_SelectedIndexChanged?.Invoke(r_FormName);
        }

        public ListBox GetListBox()
        {
            return listBoxGroups;
        }

        public void FetchListBoxData(out List<Dictionary<string, string>> DataList)
        {
            DataList = r_Groups.FetchUserEvents();
        }

        public PictureBox GetPictureBox()
        {
            return pictureBoxGroup;
        }

        public string GetPictureUrlByIndex(int i_Index)
        {
            return r_Groups.GetPictureUrl(i_Index);
        }

        public TextBox GetDescriptionTextBox()
        {
            return textBoxDescription;
        }

        public string GetDescriptionByIndex(int i_Index)
        {
            return r_Groups.GetDescription(i_Index);
        }
    }
}