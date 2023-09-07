using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using FacebookApp.Interfaces;
using FacebookApp.Models;
using FacebookApp.UI.Forms;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace FacebookApp.Controllers
{
    public class FormsController
    {
        private readonly Login r_Login;
        private Form m_CurrentForm;
        private Dictionary<eFormName, Form> m_ENumFormsDictionary;

        public FormsController()
        {
            r_Login = Login.Instance;
            initializeForms();
        }

        private void initializeForms()
        {
            m_ENumFormsDictionary = new Dictionary<eFormName, Form>();
            addAllForms();
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

        private void addForm(eFormName i_EnumFormName, Form i_Form)
        {
            m_ENumFormsDictionary.Add(i_EnumFormName, i_Form);
        }

        private Form getForm(eFormName i_EnumFormName)
        {
            return m_ENumFormsDictionary[i_EnumFormName];
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

        public void Start()
        {
            Clipboard.SetText("design.patterns20cc");
            FacebookService.s_UseForamttedToStrings = true;
            Application.EnableVisualStyles();
            Application.Run(getForm(eFormName.AppMainForm));
        }

        private void addNewForm(eFormName formName)
        {
            switch (formName)
            {
                case eFormName.AlbumForm:
                    AlbumsForm albumsForm = new AlbumsForm();
                    addForm(formName, albumsForm);
                    break;

                case eFormName.EventsForm:
                    EventsForm eventsForm = new EventsForm();
                    addForm(formName, eventsForm);
                    break;

                case eFormName.GroupsForm:
                    GroupsForm groupsForm = new GroupsForm();
                    addForm(formName, groupsForm);
                    break;

                case eFormName.LikedPagesForm:
                    LikedPagesForm likedPagesForm = new LikedPagesForm();
                    addForm(formName, likedPagesForm);
                    break;

                case eFormName.FriendsInUsersAgeRangeForm:
                    FriendsInUsersAgeRangeForm friendsInUsersAgeRangeForm = new FriendsInUsersAgeRangeForm();
                    addForm(formName, friendsInUsersAgeRangeForm);
                    break;

                case eFormName.PostsForm:
                    PostsForm postsForm = new PostsForm();
                    addForm(formName, postsForm);
                    break;

                case eFormName.UserProfileForm:
                    UserProfileForm userProfileForm = new UserProfileForm();
                    addForm(formName, userProfileForm);
                    break;

                case eFormName.PostsByDateRangeForm:
                    PostsByDateRangeForm postsByDateRangeForm = new PostsByDateRangeForm();
                    addForm(formName, postsByDateRangeForm);
                    break;

                case eFormName.EventsByLocationForm:
                    EventsByLocationForm eventsByLocationForm = new EventsByLocationForm();
                    addForm(formName, eventsByLocationForm);
                    break;
                case eFormName.RandomMemoryForm:
                    RandomMemoryForm randomMemoryForm = new RandomMemoryForm();
                    addForm(formName, randomMemoryForm);
                    break;

                case eFormName.NavigationBarForm:
                    NavigationBarForm navigationBarForm = new NavigationBarForm();
                    navigationBarForm.m_OnSubFormButtonPressed += setDisplayPanel;
                    addForm(formName, navigationBarForm);
                    break;

                case eFormName.LoginBarForm:
                    LoginBarForm loginBarForm = new LoginBarForm();
                    loginBarForm.m_LoginButtonPressed += loginToApp;
                    loginBarForm.m_LogoutButtonPressed += logoutOfApp;
                    loginBarForm.m_OnSubFormButtonPressed += setDisplayPanel;
                    addForm(formName, loginBarForm);
                    break;
                case eFormName.AppMainForm:
                    eFormName appMainFormEnum = eFormName.AppMainForm;
                    NavigationBarForm currentNavigationBarForm = getForm(eFormName.NavigationBarForm) as NavigationBarForm;
                    LoginBarForm currentLoginBarForm = getForm(eFormName.LoginBarForm) as LoginBarForm;
                    Form appMainForm = new AppMainForm(currentNavigationBarForm, currentLoginBarForm);
                    addForm(appMainFormEnum, appMainForm);
                    break;

                default:
                    throw new ArgumentException("Invalid form name");
            }
        }


        private void addAllForms()
        {
            foreach(eFormName formName in Enum.GetValues(typeof(eFormName)))
            {
                addNewForm(formName);
            }
        }
    }
}
