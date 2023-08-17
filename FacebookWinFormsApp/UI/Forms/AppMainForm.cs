using System;
using System.Windows.Forms;
using FacebookApp.Controllers;
using FacebookWrapper.ObjectModel;

namespace FacebookApp.UI.Forms
{

    public partial class AppMainForm : Form
    {
        private readonly NavigationBarForm r_NavigationBarForm;
        private readonly LoginBarForm r_LoginBar;

        public AppMainForm(NavigationBarForm i_NavigationBarForm, LoginBarForm i_LoginBarForm)
        {
            r_NavigationBarForm = i_NavigationBarForm;
            r_LoginBar = i_LoginBarForm;

            InitializeComponent();
            setNavigationBar();
            setLoginBar();
            FacebookWrapper.FacebookService.s_CollectionLimit = 25;
        }

        private void setNavigationBar()
        {
            r_NavigationBarForm.Dock = DockStyle.Fill;
            r_NavigationBarForm.TopLevel = false;
            NavBarPanel.Controls.Add(r_NavigationBarForm);
            r_NavigationBarForm.Show();
        }

        private void setLoginBar()
        {
            r_LoginBar.Dock = DockStyle.Fill;
            r_LoginBar.TopLevel = false;
            LoginPanel.Controls.Add(r_LoginBar);
            r_LoginBar.Show();
        }
    }
}
