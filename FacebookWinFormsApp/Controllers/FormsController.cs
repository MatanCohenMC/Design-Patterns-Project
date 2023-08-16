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
using CefSharp.DevTools.Debugger;


namespace FacebookApp.Controllers
{
    public class FormsController
    {
        private Dictionary<string, Form> m_FormsDictionary;
        private static FormsController s_Instance = null;
        private Form m_CurrentForm;
        private readonly Login r_Login;

        private FormsController()
        {
            r_Login = Login.Instance;
            initializeForms();
        }

        private void initializeForms()
        {
            m_FormsDictionary = new Dictionary<string, Form>();

            string formNameAlbums = "AlbumsForm";
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
            groupsForm.m_SelectedIndexChanged += setPicture;
            groupsForm.m_SelectedIndexChanged += setDescription;
            AddForm(formNameGroups, groupsForm);

            string formNamePages = "LikedPagesForm";
            LikedPagesForm likedPagesForm = new LikedPagesForm();
            likedPagesForm.m_FetchButtonPressed += fetchUserFormData;
            likedPagesForm.m_SelectedIndexChanged += setPicture;
            likedPagesForm.m_SelectedIndexChanged += setDescription;
            AddForm(formNamePages, likedPagesForm);

            string formNamePosts = "PostsForm";
            PostsForm postsForm = new PostsForm();
            postsForm.m_FetchButtonPressed += fetchUserFormData;
            postsForm.m_SelectedIndexChanged += setPicture;
            postsForm.m_SelectedIndexChanged += setComments;
            postsForm.m_SelectedIndexChanged += setDate;
            postsForm.m_SelectedIndexChanged += setLocation;
            postsForm.m_SelectedIndexChanged += setCaption;
            AddForm(formNamePosts, postsForm);

            string formNameUserProfile = "UserProfileForm";
            UserProfileForm userProfileForm = new UserProfileForm();
            //userProfileForm.m_FetchButtonPressed += fetchUserFormData;
            userProfileForm.m_FetchUserProfileData += fetchUserProfileData;
            AddForm(formNameUserProfile, userProfileForm);

            string formNamePostsByDateRange = "PostsByDateRangeForm";
            PostsByDateRangeForm postsByDateRangeForm = new PostsByDateRangeForm();
            postsByDateRangeForm.m_FetchButtonPressed += fetchUserFormData;
            postsByDateRangeForm.m_SelectedIndexChanged += setPicture;
            postsByDateRangeForm.m_SelectedIndexChanged += setComments;
            postsByDateRangeForm.m_SelectedIndexChanged += setDate;
            postsByDateRangeForm.m_SelectedIndexChanged += setLocation;
            postsByDateRangeForm.m_SelectedIndexChanged += setCaption;
            AddForm(formNamePostsByDateRange, postsByDateRangeForm);

            string formNameEventsByLocation = "EventsByLocationForm";
            EventsByLocationForm eventsByLocationForm = new EventsByLocationForm();
            eventsByLocationForm.m_FetchButtonPressed += fetchUserFormData;
            eventsByLocationForm.m_SelectedIndexChanged += setDescription;
            eventsByLocationForm.m_SelectedIndexChanged += setDate;
            eventsByLocationForm.m_SelectedIndexChanged += setPicture;
            AddForm(formNameEventsByLocation, eventsByLocationForm);


            string formNameNavigationBarForm = "NavigationBarForm";
            NavigationBarForm navigationBarForm = new NavigationBarForm();
            navigationBarForm.m_OnSubFormButtonPressed += setDisplayPanel;
            AddForm(formNameNavigationBarForm, navigationBarForm);

            string formNameLoginBarForm = "LoginBarForm";
            LoginBarForm loginBarForm = new LoginBarForm();
            loginBarForm.m_LoginButtonPressed += loginToApp;
            loginBarForm.m_LogoutButtonPressed += logoutOfApp;
            loginBarForm.m_OnSubFormButtonPressed += setDisplayPanel;

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

        private void fetchUserProfileData()
        {
            UserProfileForm userProfileForm = GetForm("UserProfileForm") as UserProfileForm;
            Dictionary<string,string> userDataDictionary = userProfileForm?.GetUserProfileData();

            TextBox fullNameTextBox = userProfileForm.GetFullNameTextBox();
            fullNameTextBox.Text = userDataDictionary["FullName"];

            TextBox emailTextBox = userProfileForm.GetEmailTextBox();
            fullNameTextBox.Text = userDataDictionary["Email"];

            TextBox genderTextBox = userProfileForm.GetGenderTextBox();
            genderTextBox.Text = userDataDictionary["Gender"];

            TextBox birthdayTextBox = userProfileForm.GetBirthdayTextBox();
            birthdayTextBox.Text = userDataDictionary["Birthday"];

            TextBox hometownTextBox = userProfileForm.GetHometownTextBox();
            hometownTextBox.Text = userDataDictionary["Hometown"];

            TextBox educationTextBox = userProfileForm.GetEducationTextBox();
            educationTextBox.Text = userDataDictionary["Education"];

            TextBox workTextBox = userProfileForm.GetWorkTextBox();
            workTextBox.Text = userDataDictionary["Work"];

            PictureBox profilePictureBox = userProfileForm.GetProfilePictureBox();
            profilePictureBox.LoadAsync(userDataDictionary["Picture"]);
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
            TextBox locationTextBox = locationHandler.GetLocationTextBox();
            string location = locationHandler.GetLocationByIndex(listBox.SelectedIndex);

            locationTextBox.Text = location ?? "No location mentioned.";
            listBox.Enabled = location != null;
        }

        private void setUpdatedTime(string i_FormName)
        {
            IComponentHandler componentHandler = m_FormsDictionary[i_FormName] as IComponentHandler;
            IUpdatedTimeHandler updatedTimeHandler = m_FormsDictionary[i_FormName] as IUpdatedTimeHandler;
            ListBox listBox = componentHandler.GetListBox();
            TextBox updatedTimeTextBox = updatedTimeHandler.GetUpdatedTimeTextBox();
            string updatedTime = updatedTimeHandler.GetUpdatedTimeByIndex(listBox.SelectedIndex);

            updatedTimeTextBox.Text = updatedTime ?? "No updated time mentioned.";
            listBox.Enabled = updatedTime != null;
        }

        private void setPictureCount(string i_FormName)
        {
            IComponentHandler componentHandler = m_FormsDictionary[i_FormName] as IComponentHandler;
            IPictureCountHandler pictureCountHandler = m_FormsDictionary[i_FormName] as IPictureCountHandler;
            ListBox listBox = componentHandler.GetListBox();
            TextBox pictureCountTextBox = pictureCountHandler.GetPictureCountTextBox();
            string pictureCount = pictureCountHandler.GetPictureCountByIndex(listBox.SelectedIndex);

            pictureCountTextBox.Text = pictureCount ?? "No picture amount mentioned.";
            listBox.Enabled = pictureCount != null;

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
            TextBox dateTextBox = dateHandler.GetDateTextBox();
            string date = dateHandler.GetDateByIndex(listBox.SelectedIndex);

            dateTextBox.Text = date ?? "No date mentioned.";
            listBox.Enabled = date != null;
        }

        private void setDescription(string i_FormName)
        {
            IComponentHandler componentHandler = m_FormsDictionary[i_FormName] as IComponentHandler;
            IDescriptionHandler descriptionHandler = m_FormsDictionary[i_FormName] as IDescriptionHandler;
            ListBox listBox = componentHandler.GetListBox();
            TextBox descriptionTextBox = descriptionHandler.GetDescriptionTextBox();
            string description = descriptionHandler.GetDescriptionByIndex(listBox.SelectedIndex);

            descriptionTextBox.Text = description ?? "No description mentioned.";
            listBox.Enabled = description != null;
        }

        private void setComments(string i_FormName)
        {
            IComponentHandler componentHandler = m_FormsDictionary[i_FormName] as IComponentHandler;
            ICommentsHandler commentsHandler = m_FormsDictionary[i_FormName] as ICommentsHandler;
            ListBox listBox = componentHandler.GetListBox();
            ListBox commentsListBox = commentsHandler.GetCommentsListBox();
            ICollection<Comment> comments = commentsHandler.GetCommentsByIndex(listBox.SelectedIndex);

            commentsListBox.Items.Clear();

            if (comments == null)
            {
                commentsListBox.Items.Add("Unknown.");
                listBox.Enabled = false;
            }
            else if (comments.Count == 0)
            {
                commentsListBox.Items.Add("No comments.");
                listBox.Enabled = false;
            }
            else
            {
                listBox.Enabled = true;
                foreach (Comment comment in comments)
                {
                    commentsListBox.Items.Add(comment.ToString());
                }
            }


        }

        private void setCaption(string i_FormName)
        {
            IComponentHandler componentHandler = m_FormsDictionary[i_FormName] as IComponentHandler;
            ICaptionHandler descriptionHandler = m_FormsDictionary[i_FormName] as ICaptionHandler;
            ListBox listBox = componentHandler.GetListBox();
            TextBox captionTextBox = descriptionHandler.GetCaptionTextBox();
            string description = descriptionHandler.GetCaptionByIndex(listBox.SelectedIndex);

            captionTextBox.Text = description ?? "No caption mentioned.";
            listBox.Enabled = description != null;
        }



    }
}
