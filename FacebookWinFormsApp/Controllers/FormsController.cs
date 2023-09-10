using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using FacebookApp.Factory;
using FacebookApp.Models;
using FacebookApp.UI.Forms;
using FacebookWrapper;

namespace FacebookApp.Controllers
{
    public class FormsController
    {
        private readonly Login r_Login;
        private Form m_CurrentForm;
        private Dictionary<eFormName, Form> m_EnumFormsDictionary;

        public FormsController()
        {
            r_Login = Login.Instance;
            initializeForms();
        }

        public void Start()
        {
            Clipboard.SetText("design.patterns20cc");
            FacebookService.s_UseForamttedToStrings = true;
            Application.EnableVisualStyles();
            Application.Run(getForm(eFormName.AppMainForm));
        }

        private void initializeForms()
        {
            m_EnumFormsDictionary = new Dictionary<eFormName, Form>();
            addAllSubForms();
            setActionFunctions();
        }

        private void loginToApp()
        {
            if (getForm(eFormName.LoginBarForm) is LoginBarForm loginForm)
            {
                string appId = loginForm.TextBoxAppIdString;

                r_Login.LoginToApp(appId);
                try
                {
                    if (r_Login.LoginResult != null && r_Login.LoginResult.LoggedInUser != null)
                    {
                        loginForm.ButtonLogin.Text = "Logged in";
                        loginForm.ButtonLogin.BackColor = Color.LightGreen;
                        loginForm.PictureBoxUserProfile.ImageLocation = r_Login.LoginResult.LoggedInUser.PictureNormalURL;
                        loginForm.ButtonLogin.Enabled = false;
                        loginForm.ButtonLogout.Enabled = true;
                        NavigationBarForm navigationBarForm = getForm(eFormName.NavigationBarForm) as NavigationBarForm;
                        navigationBarForm?.EnableNavigationBar();
                        LoginBarForm loginBarForm = getForm(eFormName.LoginBarForm) as LoginBarForm;
                        loginBarForm?.EnableMyProfileButton();
                    }
                    else
                    {
                        if (String.IsNullOrEmpty(r_Login?.LoginResult?.ErrorMessage))
                        {
                            MessageBox.Show("Login Failed, try again");
                        }
                        else
                        {
                            MessageBox.Show(r_Login.LoginResult.ErrorMessage, "Login Failed");
                        }

                        loginForm.PictureBoxUserProfile.ImageLocation = null;
                    }
                }
                catch (NullReferenceException)
                {
                    loginForm.PictureBoxUserProfile.ImageLocation = null;
                }
            }
        }

        private void logoutOfApp()
        {
            if (r_Login.IsLoggedIn())
            {
                LoginBarForm loginForm = getForm(eFormName.LoginBarForm) as LoginBarForm;

                if (loginForm != null)
                {
                    string appId = loginForm.TextBoxAppIdString;
                    r_Login?.LoginToApp(appId);
                    FacebookService.LogoutWithUI();
                    loginForm.ButtonLogin.Text = "Login";
                    loginForm.ButtonLogin.BackColor = loginForm.ButtonLogout.BackColor;
                    loginForm.LoginResult = null;
                    loginForm.ButtonLogin.Enabled = true;
                    loginForm.ButtonLogout.Enabled = false;

                    NavigationBarForm navigationBarForm = getForm(eFormName.NavigationBarForm) as NavigationBarForm;
                    LoginBarForm loginBarForm = getForm(eFormName.LoginBarForm) as LoginBarForm;
                    Form appMainForm = getForm(eFormName.AppMainForm);

                    navigationBarForm?.DisableNavigationBar();
                    loginBarForm?.DisableMyProfileButton();
                    loginForm.PictureBoxUserProfile.Image = null;
                    if (appMainForm.Controls["panelDisplay"] is Panel panelDisplay)
                    {
                        if (m_CurrentForm != null)
                        {
                            panelDisplay.Controls.Remove(m_CurrentForm);
                        }
                    }
                }
            }
        }

        private Form getForm(eFormName i_EnumFormName)
        {
            return m_EnumFormsDictionary[i_EnumFormName];
        }

        private void setDisplayPanel(eFormName i_EnumFormName)
        {
            Form formToSet = getForm(i_EnumFormName);
            Form appMainForm = getForm(eFormName.AppMainForm);

            if (appMainForm.Controls["panelDisplay"] is Panel panelDisplay)
            {
                if (m_CurrentForm != null)
                {
                    panelDisplay.Controls.Remove(m_CurrentForm);
                }

                m_CurrentForm = formToSet;
                m_CurrentForm.Dock = DockStyle.Fill;
                m_CurrentForm.TopLevel = false;
                panelDisplay.Controls.Add(m_CurrentForm);
                m_CurrentForm.Show();
            }
        }

        private void addAllSubForms()
        {
            ConcreteFormsFactory concreteFormsFactory = new ConcreteFormsFactory(ref m_EnumFormsDictionary);
            foreach (eFormName formName in Enum.GetValues(typeof(eFormName)))
            {
                Form formToAdd = concreteFormsFactory.FactoryMethod(formName);
                addForm(formName, formToAdd);
            }
        }

        private void addForm(eFormName i_EnumFormName, Form i_Form)
        {
            m_EnumFormsDictionary.Add(i_EnumFormName, i_Form);
        }

        private void setActionFunctions()
        {
            NavigationBarForm curnNavigationBarForm = getForm(eFormName.NavigationBarForm) as NavigationBarForm;
            LoginBarForm curnLoginBarForm = getForm(eFormName.LoginBarForm) as LoginBarForm;
            if (curnNavigationBarForm != null)
            {
                curnNavigationBarForm.m_OnSubFormButtonPressed += setDisplayPanel;
            }

            if (curnLoginBarForm != null)
            {
                curnLoginBarForm.m_LoginButtonPressed += loginToApp;
                curnLoginBarForm.m_LogoutButtonPressed += logoutOfApp;
                curnLoginBarForm.m_OnSubFormButtonPressed += setDisplayPanel;
            }
        }
    }
}
