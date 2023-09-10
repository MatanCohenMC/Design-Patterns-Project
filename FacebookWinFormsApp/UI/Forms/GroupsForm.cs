using System;
using System.Windows.Forms;
using FacebookApp.Facades;

namespace FacebookApp.UI.Forms
{
    public partial class GroupsForm : Form
    {
        private readonly GroupsFacade r_GroupsFacade;

        public GroupsForm()
        {
            InitializeComponent();
            r_GroupsFacade = new GroupsFacade();
            r_GroupsFacade.GroupsUpdated += setGroupsFacade;
        }

        private void buttonFetchGroups_Click(object i_Sender, EventArgs i_EventArgs)
        {
            labelLoading.Visible = true;
            r_GroupsFacade.UpdateGroups();
        }

        private void setGroupsFacade()
        {
            if (InvokeRequired)
            {
                Invoke((Action)setGroupsFacade);
                return;
            }

            groupBindingSource.DataSource = r_GroupsFacade.Groups;
            labelLoading.Visible = false;
        }
    }
}