using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookApp;
using FacebookApp.Controllers;
using FacebookApp.Models;

namespace FacebookApp.UI.Forms
{
    public delegate void DisplayFormEventHandler(Form i_FormToDisplay);

    public partial class NavigationBarForm : Form
    {

        public Action<eFormName> m_OnSubFormButtonPressed;

        public NavigationBarForm()
        {
            InitializeComponent();
        }

        private void NavigationBarForm_Load(object sender, EventArgs e)
        {

        }

        private void ButtonPosts_Click(object sender, EventArgs e)
        {
            m_OnSubFormButtonPressed?.Invoke(eFormName.PostsForm);

            //displayFormEventHandler.Invoke(m_FormsController.GetForm("PostsForm"));
        }

        private void ButtonAlbums_Click(object i_Sender, EventArgs i_E)
        {
            m_OnSubFormButtonPressed?.Invoke(eFormName.AlbumForm);
            //displayFormEventHandler.Invoke(m_FormsController.GetForm("AlbumsForm"));
        }

        private void ButtonEvents_Click(object i_Sender, EventArgs i_E)
        {
            m_OnSubFormButtonPressed?.Invoke(eFormName.EventsForm);
            //displayFormEventHandler.Invoke(m_FormsController.GetForm("EventsForm"));
        }

        private void ButtonGroups_Click(object i_Sender, EventArgs i_E)
        {
            m_OnSubFormButtonPressed?.Invoke(eFormName.GroupsForm);
            //displayFormEventHandler.Invoke(m_FormsController.GetForm("GroupsForm"));
        }

        private void ButtonLikedPages_Click(object i_Sender, EventArgs i_E)
        {
            m_OnSubFormButtonPressed?.Invoke(eFormName.LikedPagesForm);
            //displayFormEventHandler.Invoke(m_FormsController.GetForm("PagesForm"));
        }


        private void buttonEventByLocation_Click(object i_Sender, EventArgs i_E)
        {
            m_OnSubFormButtonPressed?.Invoke(eFormName.EventsByLocationForm);
        }

        private void buttonPostsByDateRange_Click(object i_Sender, EventArgs i_E)
        {
            m_OnSubFormButtonPressed?.Invoke(eFormName.PostsByDateRangeForm);
        }
    }
}
