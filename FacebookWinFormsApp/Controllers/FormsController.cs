using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookApp.UI.Forms;
using FacebookApp.UI;
using FacebookApp.UI.Forms;
using FacebookApp.Interfaces;
using FacebookApp.Models;
using FacebookWrapper;


namespace FacebookApp.Controllers
{
    public class FormsController
    {
        private Dictionary<string, Form> m_FormsDictionary;
        private static FormsController s_Instance = null;
        private Form m_CurrentForm;
        private Login m_Login;

        private FormsController()
        {
            m_Login = Login.Instance;
            initializeForms();
        }
        // //

        private void initializeForms()
        {
            m_FormsDictionary = new Dictionary<string, Form>();

            string formNameAlbums = "AlbumsForm";
            AlbumsForm albumsForm = new AlbumsForm();
            albumsForm.m_FetchButtonPressed += fetchUserFormData;
            AddForm(formNameAlbums, albumsForm);

            string formNameEvents = "EventsForm";
            EventsForm eventsForm = new EventsForm();
            eventsForm.m_FetchButtonPressed += fetchUserFormData;
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


            string formNameNavigationBarForm = "NavigationBarForm";
            NavigationBarForm navigationBarForm = new NavigationBarForm();
            navigationBarForm.m_OnSubFormButtonPressed += setDisplayPanel;
            AddForm(formNameNavigationBarForm, navigationBarForm);

            string formNameLoginBarForm = "LoginBarForm";
            LoginBarForm loginBarForm = new LoginBarForm();
            loginBarForm.m_LoginButtonPressed += loginToApp;

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
                m_Login.LoginToApp(appId);

                try
                {
                    if (m_Login.LoginResult != null && m_Login.LoginResult.LoggedInUser != null)
                    {
                        loginForm.ButtonLogin.Text = "Logged in";
                        loginForm.ButtonLogin.BackColor = Color.LightGreen;
                        loginForm.PictureBoxUserProfile.ImageLocation = m_Login.LoginResult.LoggedInUser.PictureNormalURL;
                        loginForm.ButtonLogin.Enabled = false;
                        loginForm.ButtonLogout.Enabled = true;
                    }
                    else
                    {
                        if(String.IsNullOrEmpty(m_Login.LoginResult.ErrorMessage))
                        {
                            MessageBox.Show("Login Failed, try again");
                        }
                        else
                        {
                            MessageBox.Show(m_Login.LoginResult.ErrorMessage, "Login Failed");
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
            ListBox formListBox = componentHandler?.GetListBox();
            formListBox?.Items.Clear();

            foreach (string post in dataHandler.FetchListBoxData())
            {
                formListBox?.Items.Add(post);
            }
            //TODO: should add a picture box to the form
            //TODO: should load extra data about the list box items such as date and total likes and comments to a static dictionary later display it on the form

        }





        private void setDisplayPanel(string i_FormName)
        {
            Form formToSet = GetForm(i_FormName);
            Form appMainForm = GetForm("AppMainForm");
            if(appMainForm.Controls["panelDisplay"] is Panel panelDisplay)
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

    }
}
