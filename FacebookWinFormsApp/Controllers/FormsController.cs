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
        private static readonly object sr_MyLock = new object();
        private static FormsController s_Instance = null;
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

            eFormName albumsEnum = eFormName.AlbumForm;
            AlbumsForm albumsForm = new AlbumsForm();
            AddForm(albumsEnum, albumsForm);


            eFormName eventsEnum = eFormName.EventsForm;
            EventsForm eventsForm = new EventsForm();
            AddForm(eventsEnum, eventsForm);

            eFormName groupsEnum = eFormName.GroupsForm;
            GroupsForm groupsForm = new GroupsForm();
            AddForm(groupsEnum, groupsForm);

            eFormName likedPagesEnum = eFormName.LikedPagesForm;
            LikedPagesForm likedPagesForm = new LikedPagesForm();
            AddForm(likedPagesEnum, likedPagesForm);

            eFormName friendsInUsersAgeRangeEnum = eFormName.FriendsInUsersAgeRangeForm;
            FriendsInUsersAgeRangeForm friendsInUsersAgeRangeFrom = new FriendsInUsersAgeRangeForm();
            AddForm(friendsInUsersAgeRangeEnum, friendsInUsersAgeRangeFrom);

            eFormName postsEnum = eFormName.PostsForm;
            PostsForm postsForm = new PostsForm();
            AddForm(postsEnum, postsForm);

            eFormName userProfileEnum = eFormName.UserProfileForm;
            UserProfileForm userProfileForm = new UserProfileForm();
            AddForm(userProfileEnum, userProfileForm);

            eFormName postsByDateRangeEnum = eFormName.PostsByDateRangeForm;
            PostsByDateRangeForm postsByDateRangeForm = new PostsByDateRangeForm();
            AddForm(postsByDateRangeEnum, postsByDateRangeForm);

            eFormName eventsByLocationEnum = eFormName.EventsByLocationForm;
            EventsByLocationForm eventsByLocationForm = new EventsByLocationForm();
            AddForm(eventsByLocationEnum, eventsByLocationForm);

            eFormName randomMemoryEnum = eFormName.RandomMemoryForm;
            RandomMemoryForm randomMemoryForm = new RandomMemoryForm();
            AddForm(randomMemoryEnum, randomMemoryForm);

            eFormName navigationBarEnum = eFormName.NavigationBarForm;
            NavigationBarForm navigationBarForm = new NavigationBarForm();
            navigationBarForm.m_OnSubFormButtonPressed += setDisplayPanel;
            AddForm(navigationBarEnum, navigationBarForm);

            eFormName loginBarEnum = eFormName.LoginBarForm;
            LoginBarForm loginBarForm = new LoginBarForm();
            loginBarForm.m_LoginButtonPressed += loginToApp;
            loginBarForm.m_LogoutButtonPressed += logoutOfApp;
            loginBarForm.m_OnSubFormButtonPressed += setDisplayPanel;
            AddForm(loginBarEnum, loginBarForm);

            eFormName appMainFormEnum = eFormName.AppMainForm;
            Form appMainForm = new AppMainForm(navigationBarForm, loginBarForm);
            AddForm(appMainFormEnum, appMainForm);
        }

        private void loginToApp()
        {
            if (GetForm(eFormName.LoginBarForm) is LoginBarForm loginForm)
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
                        NavigationBarForm navigationBarForm = GetForm(eFormName.NavigationBarForm) as NavigationBarForm;
                        navigationBarForm?.EnableNavigationBar();
                        LoginBarForm loginBarForm = GetForm(eFormName.LoginBarForm) as LoginBarForm;
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
                LoginBarForm loginForm = GetForm(eFormName.LoginBarForm) as LoginBarForm;

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

                    NavigationBarForm navigationBarForm = GetForm(eFormName.NavigationBarForm) as NavigationBarForm;
                    LoginBarForm loginBarForm = GetForm(eFormName.LoginBarForm) as LoginBarForm;
                    Form appMainForm = GetForm(eFormName.AppMainForm);

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

        public void AddForm(eFormName i_EnumFormName, Form i_Form)
        {
            m_ENumFormsDictionary.Add(i_EnumFormName, i_Form);
        }

        public Form GetForm(eFormName i_EnumFormName)
        {
            return m_ENumFormsDictionary[i_EnumFormName];
        }

        private void setDisplayPanel(eFormName i_EnumFormName)
        {
            Form formToSet = GetForm(i_EnumFormName);
            Form appMainForm = GetForm(eFormName.AppMainForm);

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
            Application.Run(GetForm(eFormName.AppMainForm));
        }


        private static void fetchDataToListBox(IComponentHandler i_ComponentHandler, IDataHandler i_DataHandler)
        {
            ListBox listBox = i_ComponentHandler.GetListBox();
            List<Dictionary<string, string>> dataList;

            listBox?.Items.Clear();
            if (i_DataHandler != null)
            {
                i_DataHandler.FetchListBoxData(out dataList);

                if (dataList.Count > 0)
                {
                    listBox.Enabled = true;
                    foreach (Dictionary<string, string> data in dataList)
                    {
                        if (data.ContainsKey("ListBoxText") && data["ListBoxText"] != null)
                        {
                            listBox.Items.Add(data["ListBoxText"]);
                        }
                    }
                }
                else
                {
                    listBox?.Items.Add("No data to retrieve.");
                    listBox.Enabled = false;
                }
            }
        }

    }
}
