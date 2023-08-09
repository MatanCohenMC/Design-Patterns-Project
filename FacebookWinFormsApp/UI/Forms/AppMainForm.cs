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
        private User m_LoggedInUser;

        public AppMainForm(NavigationBarForm i_NavigationBarForm, LoginBarForm i_LoginBarForm)
        {
            this.r_NavigationBarForm = i_NavigationBarForm;
            this.r_LoginBar = i_LoginBarForm;

            r_LoginBar.m_LoginButtonPressed += LoginButtonPressed;

            InitializeComponent();
            setNavigationBar();
            setLoginBar();
            FacebookWrapper.FacebookService.s_CollectionLimit = 25;
        }

        private void LoginButtonPressed()
        {
            //m_FormsController.InitiateLogin();
        }

        private void setNavigationBar()
        {
            this.r_NavigationBarForm.Dock = DockStyle.Fill;
            this.r_NavigationBarForm.TopLevel = false;
            this.NavBarPanel.Controls.Add(this.r_NavigationBarForm);
            this.r_NavigationBarForm.Show();
        }

        private void setLoginBar()
        {
            this.r_LoginBar.Dock = DockStyle.Fill;
            this.r_LoginBar.TopLevel = false;
            this.LoginPanel.Controls.Add(this.r_LoginBar);
            this.r_LoginBar.Show();
        }


        private void OnButtonPressed(string parameter)
        {
            // Call the setDisplayPanel function when the button is pressed with the provided parameter
            //setDisplayPanel(m_FormsController.GetForm(parameter));
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void AppMainForm_Load(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        public System.Windows.Forms.Panel GetPanelDisplay()
        {
            return this.panelDisplay;
        }
    }
}
