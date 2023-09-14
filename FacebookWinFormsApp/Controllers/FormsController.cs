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
        private readonly ILoginStrategy r_LoginStrategy;
        private readonly ILogoutStrategy r_LogoutStrategy;
        private Form m_CurrentForm;
        private Dictionary<eFormName, Form> m_EnumFormsDictionary;

        public FormsController()
        {
            r_Login = Login.Instance;
            r_LoginStrategy = new FacebookLoginStrategy();
            r_LogoutStrategy = new FacebookLogoutStrategy();
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
                r_LoginStrategy.ExecuteLogin(loginForm, this);
            }
        }

        private void logoutOfApp()
        {
            if (r_Login.IsLoggedIn())
            {
                LoginBarForm loginForm = getForm(eFormName.LoginBarForm) as LoginBarForm;
                r_LogoutStrategy.ExecuteLogout(loginForm, this);
            }
        }

        private Form getForm(eFormName i_EnumFormName)
        {
            return m_EnumFormsDictionary[i_EnumFormName];
        }

        public void EnableNavBar()
        {
            NavigationBarForm navigationBarForm = getForm(eFormName.NavigationBarForm) as NavigationBarForm;
            navigationBarForm?.EnableNavigationBar();
        }

        public void DisableNavBar()
        {
            NavigationBarForm navigationBarForm = getForm(eFormName.NavigationBarForm) as NavigationBarForm;
            navigationBarForm?.DisableNavigationBar();
        }

        public void EnableLoginBar()
        {
            LoginBarForm loginBarForm = getForm(eFormName.LoginBarForm) as LoginBarForm;
            loginBarForm?.EnableMyProfileButton();
        }

        public void DisableLoginBar()
        {
            LoginBarForm loginBarForm = getForm(eFormName.LoginBarForm) as LoginBarForm;
            loginBarForm?.DisableMyProfileButton();
        }

        public void RemoveCurrentDisplayForm()
        {
            Form appMainForm = getForm(eFormName.AppMainForm);
            if (appMainForm.Controls["panelDisplay"] is Panel panelDisplay)
            {
                if (m_CurrentForm != null)
                {
                    panelDisplay.Controls.Remove(m_CurrentForm);
                }
            }
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
