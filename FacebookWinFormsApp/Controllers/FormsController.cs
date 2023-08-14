using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookApp.Dtos;
using FacebookApp.UI.Forms;
using FacebookApp.UI;
using FacebookApp.Interfaces;
using FacebookApp.Models;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;


namespace FacebookApp.Controllers
{
    public class FormsController
    {
        private Dictionary<string, Form> m_FormsDictionary;
        private static FormsController s_Instance = null;
        private Form m_CurrentForm;
        private readonly Login r_Login;
        private Albums m_albums;

        private FormsController()
        {
            r_Login = Login.Instance;
            initializeForms();
        }
        // //

        private void initializeForms()
        {
            m_FormsDictionary = new Dictionary<string, Form>();

            string formNameAlbums = "AlbumsForm";
            m_albums = new Albums();
            AlbumsForm albumsForm = new AlbumsForm();
            albumsForm.m_FetchButtonPressed += fetchUserFormData;
            albumsForm.m_SelectedIndexChanged += setPicture;
            albumsForm.m_SelectedIndexChanged += setLocation;
            albumsForm.m_SelectedIndexChanged += setUpdatedTime;
            albumsForm.m_SelectedIndexChanged += setPictureCount;
            AddForm(formNameAlbums, albumsForm);

            string formNameEvents = "EventsForm";
            EventsForm eventsForm = new EventsForm();
            eventsForm.m_FetchButtonPressed += fetchUserFormData;
            eventsForm.m_SelectedIndexChanged += setLocation;
            eventsForm.m_SelectedIndexChanged += setDescription;
            eventsForm.m_SelectedIndexChanged += setDate;
            eventsForm.m_SelectedIndexChanged += setPicture;
            AddForm(formNameEvents, eventsForm);

            string formNameGroups = "GroupsForm";
            GroupsForm groupsForm = new GroupsForm();
            groupsForm.m_FetchButtonPressed += fetchUserFormData;
            AddForm(formNameGroups, groupsForm);

            string formNamePages = "PagesForm";
            FormPages pagesForm = new FormPages();
            pagesForm.m_FetchButtonPressed += fetchUserFormData;
            AddForm(formNamePages, pagesForm);

            string formNamePosts = "PostsForm";
            PostsForm postsForm = new PostsForm();
            postsForm.m_FetchButtonPressed += fetchUserFormData;
            AddForm(formNamePosts, postsForm);

            string formNameUserProfile = "UserProfileForm";
            UserProfileForm userProfileForm = new UserProfileForm();
            //postsForm.m_FetchButtonPressed += fetchUserFormData;
            AddForm(formNameUserProfile, userProfileForm);

            string formNameNavigationBarForm = "NavigationBarForm";
            NavigationBarForm navigationBarForm = new NavigationBarForm();
            navigationBarForm.m_OnSubFormButtonPressed += setDisplayPanel;
            AddForm(formNameNavigationBarForm, navigationBarForm);

            string formNameLoginBarForm = "LoginBarForm";
            LoginBarForm loginBarForm = new LoginBarForm();
            loginBarForm.m_LoginButtonPressed += loginToApp;
            loginBarForm.m_LogoutButtonPressed += logoutOfApp;

            AddForm(formNameLoginBarForm, loginBarForm);
            string formNameAppMainForm = "AppMainForm";
            Form appMainForm = new AppMainForm(navigationBarForm, loginBarForm);
            AddForm(formNameAppMainForm, appMainForm);

        }

        private void loginToApp()
        {
            LoginBarForm loginForm = GetForm("LoginBarForm") as LoginBarForm;
            if(loginForm != null)
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
                    }
                    else
                    {
                        if(String.IsNullOrEmpty(r_Login.LoginResult.ErrorMessage))
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
            LoginBarForm loginForm = GetForm("LoginBarForm") as LoginBarForm;
            string appId = loginForm.TextBoxAppIdString;
            r_Login.LoginToApp(appId);
            FacebookService.LogoutWithUI();
            loginForm.ButtonLogin.Text = "Login";
            loginForm.ButtonLogin.BackColor = loginForm.ButtonLogout.BackColor;
            loginForm.LoginResult = null;
            loginForm.ButtonLogin.Enabled = true;
            loginForm.ButtonLogout.Enabled = false;
        }

        public static FormsController Instance
        {
            get
            {
                if (s_Instance == null)
                {
                    s_Instance = new FormsController();
                }

                return s_Instance;
            }
        }

        public void AddForm(string i_FormName, Form i_Form)
        {
            m_FormsDictionary.Add(i_FormName, i_Form);
        }

        public Form GetForm(string i_FormName)
        {
            return m_FormsDictionary[i_FormName];
        }

        private void setDisplayPanel(string i_FormName)
        {
            Form formToSet = GetForm(i_FormName);
            Form appMainForm = GetForm("AppMainForm");
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
            //Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(GetForm("AppMainForm"));
        }

        private void fetchUserFormData(string i_FormName)
        {
            IComponentHandler componentHandler = m_FormsDictionary[i_FormName] as IComponentHandler;
            IDataHandler dataHandler = m_FormsDictionary[i_FormName] as IDataHandler;
            fetchDataToListBox(componentHandler, dataHandler);
        }

        /*private static void fetchDataToListBox(IComponentHandler i_ComponentHandler, IDataHandler i_DataHandler)
        {
            Type componentType = i_ComponentHandler.GetType();

            if (typeof(IListBoxHandler).IsAssignableFrom(componentType))
            {
                MethodInfo listBoxMethod = componentType.GetMethod("GetListBox");
                if (listBoxMethod != null)
                {
                    ListBox listBox = (ListBox)listBoxMethod.Invoke(i_ComponentHandler, null);
                    listBox?.Items.Clear();
                    List<Dictionary<string, string>> dataList;

                    if (i_DataHandler != null)
                    {
                        i_DataHandler.FetchListBoxData(out dataList);

                        foreach (Dictionary<string, string> data in dataList)
                        {
                            if (data.ContainsKey("ListBoxText"))
                            {
                                listBox.Items.Add(data["ListBoxText"]);
                            }
                        }
                    }
                }
            }
        }*/

        private static void fetchDataToListBox(IComponentHandler i_ComponentHandler, IDataHandler i_DataHandler)
        {
            ListBox listBox = i_ComponentHandler.GetListBox();
            listBox?.Items.Clear();
            List<Dictionary<string, string>> dataList;

            if (i_DataHandler != null)
            {
                i_DataHandler.FetchListBoxData(out dataList);

                foreach (Dictionary<string, string> data in dataList)
                {
                    if (data.ContainsKey("ListBoxText"))
                    {
                        listBox.Items.Add(data["ListBoxText"]);
                    }
                }
            }
        }


        private void setPicture(string i_FormName)
        {
            IComponentHandler componentHandler = m_FormsDictionary[i_FormName] as IComponentHandler;
            IPictureHandler pictureHandler = m_FormsDictionary[i_FormName] as IPictureHandler;
            ListBox listBox = componentHandler.GetListBox();
            PictureBox pictureBox = pictureHandler.GetPictureBox();

            string pictureUrl = pictureHandler.GetPictureUrlByIndex(listBox.SelectedIndex);
            if (pictureUrl != null)
            {
                pictureBox.LoadAsync(pictureUrl);
            }
            else
            {
                pictureBox.Image = pictureBox.ErrorImage;
            }
        }

        private void setLocation(string i_FormName)
        {
            IComponentHandler componentHandler = m_FormsDictionary[i_FormName] as IComponentHandler;
            ILocationHandler locationHandler = m_FormsDictionary[i_FormName] as ILocationHandler;
            ListBox listBox = componentHandler.GetListBox();
            TextBox textBox = locationHandler.GetLocationTextBox();
            string location = locationHandler.GetLocationByIndex(listBox.SelectedIndex);

            textBox.Text = location ?? "No location mentioned.";
        }

        private void setUpdatedTime(string i_FormName)
        {
            IComponentHandler componentHandler = m_FormsDictionary[i_FormName] as IComponentHandler;
            IUpdatedTimeHandler updatedTimeHandler = m_FormsDictionary[i_FormName] as IUpdatedTimeHandler;
            ListBox listBox = componentHandler.GetListBox();
            TextBox textBox = updatedTimeHandler.GetUpdatedTimeTextBox();
            string updatedTime = updatedTimeHandler.GetUpdatedTimeByIndex(listBox.SelectedIndex);

            textBox.Text = updatedTime ?? "No updated time mentioned.";
        }

        private void setPictureCount(string i_FormName)
        {
            IComponentHandler componentHandler = m_FormsDictionary[i_FormName] as IComponentHandler;
            IPictureCountHandler pictureCountHandler = m_FormsDictionary[i_FormName] as IPictureCountHandler;
            ListBox listBox = componentHandler.GetListBox();
            TextBox textBox = pictureCountHandler.GetPictureCountTextBox();
            string pictureCount = pictureCountHandler.GetPictureCountByIndex(listBox.SelectedIndex);
            textBox.Text = pictureCount ?? "No picture amount mentioned.";

           /* if (albumPictureCount != null && albumPictureCount != String.Empty)
            {
                textBoxPictureAmount.Text = albumPictureCount;
            }
            else
            {
                textBoxPictureAmount.Text = "0";
            }*/
        }

        private void setDate(string i_FormName)
        {
            IComponentHandler componentHandler = m_FormsDictionary[i_FormName] as IComponentHandler;
            IDateHandler dateHandler = m_FormsDictionary[i_FormName] as IDateHandler;
            ListBox listBox = componentHandler.GetListBox();
            TextBox textBox = dateHandler.GetDateTextBox();
            string date = dateHandler.GetDateByIndex(listBox.SelectedIndex);

            textBox.Text = date ?? "No date mentioned.";
        }

        private void setDescription(string i_FormName)
        {
            IComponentHandler componentHandler = m_FormsDictionary[i_FormName] as IComponentHandler;
            IDescriptionHandler descriptionHandler = m_FormsDictionary[i_FormName] as IDescriptionHandler;
            ListBox listBox = componentHandler.GetListBox();
            TextBox textBox = descriptionHandler.GetDescriptionTextBox();
            string description = descriptionHandler.GetDescriptionByIndex(listBox.SelectedIndex);

            textBox.Text = description ?? "No description mentioned.";
        }
        
        



    }
}
