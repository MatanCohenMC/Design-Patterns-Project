using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FacebookApp.Facades;
using FacebookApp.Interfaces;
using FacebookApp.Models;

namespace FacebookApp.UI.Forms
{
    public partial class GroupsForm : Form
    {
        private readonly GroupsFacade r_Groups;

        public GroupsForm()
        {
            InitializeComponent();
            r_Groups = new GroupsFacade();
            r_Groups.GroupsUpdated += setGroups;
        }

        private void buttonFetchGroups_Click(object i_Sender, EventArgs i_EventArgs)
        {
            labelLoading.Visible = true;
            r_Groups.updateGroups();
        }


        private void setGroups()
        {
            if(InvokeRequired)
            {
                Invoke((Action)setGroups);
                return;
            }

            groupBindingSource.DataSource = r_Groups.Groups;
            labelLoading.Visible = false;
        }

        private void descriptionTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}