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

namespace FacebookApp.UI.Forms
{
    public delegate void DisplayFormEventHandler(Form i_FormToDisplay);

    public partial class NavigationBarForm : Form
    {
        private DisplayFormEventHandler displayFormEventHandler;
        private FormsController m_FormsController = FormsController.Instance;

        public Action<string> m_ButtonPressed;



        public void SetDisplayFormEventHandler(DisplayFormEventHandler i_DisplayFormEventHandler)
        {
            this.displayFormEventHandler = i_DisplayFormEventHandler;
        }


        public NavigationBarForm()
        {
            InitializeComponent();
        }

        private void NavigationBarForm_Load(object sender, EventArgs e)
        {

        }

        private void ButtonPosts_Click(object sender, EventArgs e)
        {
            m_ButtonPressed?.Invoke("PostsForm");

            //displayFormEventHandler.Invoke(m_FormsController.GetForm("PostsForm"));
        }

        private void ButtonAlbums_Click(object i_Sender, EventArgs i_E)
        {
            m_ButtonPressed?.Invoke("AlbumsForm");
            //displayFormEventHandler.Invoke(m_FormsController.GetForm("AlbumsForm"));
        }

        private void ButtonEvents_Click(object i_Sender, EventArgs i_E)
        {
            m_ButtonPressed?.Invoke("EventsForm");
            //displayFormEventHandler.Invoke(m_FormsController.GetForm("EventsForm"));
        }

        private void ButtonGroups_Click(object i_Sender, EventArgs i_E)
        {
            m_ButtonPressed?.Invoke("GroupsForm");
            //displayFormEventHandler.Invoke(m_FormsController.GetForm("GroupsForm"));
        }

        private void ButtonLikedPages_Click(object i_Sender, EventArgs i_E)
        {
            m_ButtonPressed?.Invoke("PagesForm");
            //displayFormEventHandler.Invoke(m_FormsController.GetForm("PagesForm"));
        }
    }
}
