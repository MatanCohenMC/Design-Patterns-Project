using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FacebookApp.Interfaces;
using FacebookApp.Models;

namespace FacebookApp.UI.Forms
{
    public partial class GroupsForm : Form
    {
        private readonly Groups r_Groups = new Groups();

        public GroupsForm()
        {
            InitializeComponent();
        }

        private void buttonFetchGroups_Click(object i_Sender, EventArgs i_EventArgs)
        {
            fetchGroups();
        }

        private void fetchGroups()
        {
            groupBindingSource.DataSource = r_Groups.GetGroups();
        }
    }
}