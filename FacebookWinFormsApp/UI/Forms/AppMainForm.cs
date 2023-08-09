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
        private Form m_CurrentForm;
        private FormsController m_FormsController = FormsController.Instance;
        private User m_LoggedInUser;

        public AppMainForm(NavigationBarForm i_NavigationBarForm, LoginBarForm i_LoginBarForm)
        {
            this.r_NavigationBarForm = i_NavigationBarForm;
            r_LoginBar = i_LoginBarForm;

            r_NavigationBarForm.SetDisplayFormEventHandler(setDisplayPanel);
            r_NavigationBarForm.m_ButtonPressed += OnButtonPressed;
            r_LoginBar.m_LoginButtonPressed += LoginButtonPressed;

            InitializeComponent();
            setNavigationBar();
            setLoginBar();
            FacebookWrapper.FacebookService.s_CollectionLimit = 25;
        }

        private User LoginButtonPressed()
        {
            m_LoggedInUser = r_LoginBar.Login();
            return m_LoggedInUser;
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

        private void setDisplayPanel(Form i_Form)
        {
            if (m_CurrentForm != null)
            {
                panelDisplay.Controls.Remove(m_CurrentForm);
            }
            m_CurrentForm = i_Form;
            m_CurrentForm.Dock = DockStyle.Fill;
            m_CurrentForm.TopLevel = false;
            panelDisplay.Controls.Add(m_CurrentForm);
            m_CurrentForm.Show();

        }

        private void OnButtonPressed(string parameter)
        {
            // Call the setDisplayPanel function when the button is pressed with the provided parameter
            setDisplayPanel(m_FormsController.GetForm(parameter));
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
    }
}
