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
        //private Dictionary<string, Form> m_FormsDictionary;
        private Dictionary<eFormName, Form> m_eNumFormsDictionary;
        private static FormsController s_Instance = null;
        private Form m_CurrentForm;
        private readonly Login r_Login;

        private FormsController()
        {
            r_Login = Login.Instance;
            initializeForms();
        }
        // //

        private void initializeForms()
        {
            //m_FormsDictionary = new Dictionary<string, Form>();
            m_eNumFormsDictionary = new Dictionary<eFormName, Form>();

            eFormName AlbumsEnum = eFormName.AlbumForm;
            AlbumsForm albumsForm = new AlbumsForm();
            AddForm(AlbumsEnum, albumsForm);

            //albumsForm.m_FetchButtonPressed += fetchUserFormData;
            //albumsForm.m_SelectedIndexChanged += setLocation;
            //albumsForm.m_SelectedIndexChanged +=  setPicture;
            //albumsForm.m_SelectedIndexChanged += setUpdatedTime;
            //albumsForm.m_SelectedIndexChanged += setPictureCount;
            setFetchActionFunctions(AlbumsEnum, fetchUserFormData);
            setSelectedIndexActionFunctions(AlbumsEnum, setLocation, setPicture, setUpdatedTime, setPictureCount);

            eFormName EventsEnum = eFormName.EventsForm;
            EventsForm eventsForm = new EventsForm();
            AddForm(EventsEnum, eventsForm);
            setFetchActionFunctions(EventsEnum, fetchUserFormData);
            setSelectedIndexActionFunctions(EventsEnum, setLocation, setDescription, setDate, setPicture);
            //eventsForm.m_FetchButtonPressed += fetchUserFormData;
            //eventsForm.m_SelectedIndexChanged += setLocation;
            //eventsForm.m_SelectedIndexChanged += setDescription;
            //eventsForm.m_SelectedIndexChanged += setDate;
            //eventsForm.m_SelectedIndexChanged += setPicture;

            eFormName groupsEnum = eFormName.GroupsForm;
            GroupsForm groupsForm = new GroupsForm();
            AddForm(groupsEnum, groupsForm);
            setFetchActionFunctions(groupsEnum, fetchUserFormData);
            setSelectedIndexActionFunctions(groupsEnum, setPicture, setDescription);
            //groupsForm.m_FetchButtonPressed += fetchUserFormData;
            //groupsForm.m_SelectedIndexChanged += setPicture;
            //groupsForm.m_SelectedIndexChanged += setDescription;

            eFormName LikedPagesEnum = eFormName.LikedPagesForm;
            LikedPagesForm likedPagesForm = new LikedPagesForm();
            AddForm(LikedPagesEnum, likedPagesForm);
            setFetchActionFunctions(LikedPagesEnum, fetchUserFormData);
            setSelectedIndexActionFunctions(LikedPagesEnum, setPicture, setDescription);
            //likedPagesForm.m_FetchButtonPressed += fetchUserFormData;
            //likedPagesForm.m_SelectedIndexChanged += setPicture;
            //likedPagesForm.m_SelectedIndexChanged += setDescription;

            eFormName PostsEnum = eFormName.PostsForm;
            PostsForm postsForm = new PostsForm();
            AddForm(PostsEnum, postsForm);
            setFetchActionFunctions(PostsEnum, fetchUserFormData);
            setSelectedIndexActionFunctions(PostsEnum, setPicture, setComments, setDate, setLocation, setCaption);
            //postsForm.m_FetchButtonPressed += fetchUserFormData;
            //postsForm.m_SelectedIndexChanged += setPicture;
            //postsForm.m_SelectedIndexChanged += setComments;
            //postsForm.m_SelectedIndexChanged += setDate;
            //postsForm.m_SelectedIndexChanged += setLocation;
            //postsForm.m_SelectedIndexChanged += setCaption;

            eFormName UserProfileEnum = eFormName.UserProfileForm;
            UserProfileForm userProfileForm = new UserProfileForm();
            AddForm(UserProfileEnum, userProfileForm);
            userProfileForm.m_FetchUserProfileData += fetchUserProfileData;

            eFormName PostsByDateRangeEnum = eFormName.PostsByDateRangeForm;
            PostsByDateRangeForm postsByDateRangeForm = new PostsByDateRangeForm();
            AddForm(PostsByDateRangeEnum, postsByDateRangeForm);
            setFetchActionFunctions(PostsByDateRangeEnum, fetchUserFormData);
            setSelectedIndexActionFunctions(PostsByDateRangeEnum, setPicture, setComments, setDate, setLocation, setCaption);
            //postsByDateRangeForm.m_FetchButtonPressed += fetchUserFormData;
            //postsByDateRangeForm.m_SelectedIndexChanged += setPicture;
            //postsByDateRangeForm.m_SelectedIndexChanged += setComments;
            //postsByDateRangeForm.m_SelectedIndexChanged += setDate;
            //postsByDateRangeForm.m_SelectedIndexChanged += setLocation;
            //postsByDateRangeForm.m_SelectedIndexChanged += setCaption;

            eFormName EventsByLocationEnum = eFormName.EventsByLocationForm;
            EventsByLocationForm eventsByLocationForm = new EventsByLocationForm();
            AddForm(EventsByLocationEnum, eventsByLocationForm);
            setFetchActionFunctions(EventsByLocationEnum, fetchUserFormData);
            setSelectedIndexActionFunctions(EventsByLocationEnum, setLocation, setDescription, setDate, setPicture);
            //eventsByLocationForm.m_FetchButtonPressed += fetchUserFormData;
            //eventsByLocationForm.m_SelectedIndexChanged += setDescription;
            //eventsByLocationForm.m_SelectedIndexChanged += setDate;
            //eventsByLocationForm.m_SelectedIndexChanged += setPicture;


            eFormName NavigationBarEnum = eFormName.NavigationBarForm;
            NavigationBarForm navigationBarForm = new NavigationBarForm();
            navigationBarForm.m_OnSubFormButtonPressed += setDisplayPanel;
            AddForm(NavigationBarEnum, navigationBarForm);

            eFormName LoginBarEnum = eFormName.LoginBarForm;
            LoginBarForm loginBarForm = new LoginBarForm();
            loginBarForm.m_LoginButtonPressed += loginToApp;
            loginBarForm.m_LogoutButtonPressed += logoutOfApp;
            loginBarForm.m_OnSubFormButtonPressed += setDisplayPanel;

            AddForm(LoginBarEnum, loginBarForm);
            eFormName AppMainFormEnum = eFormName.AppMainForm;
            Form appMainForm = new AppMainForm(navigationBarForm, loginBarForm);
            AddForm(AppMainFormEnum, appMainForm);


        }


        private void setFetchActionFunctions(eFormName i_EnumFormName, Action<eFormName> i_Action)
        {
            ISetFetchAction fetchActionInterface = GetForm(i_EnumFormName) as ISetFetchAction;
            fetchActionInterface.SetFetchAction(i_Action);
        }

        private void setSelectedIndexActionFunctions(eFormName i_EnumFormName, params Action<eFormName>[] i_Actions)
        {
            ISetSelectedIndexAction selectedIndexActionInterface = GetForm(i_EnumFormName) as ISetSelectedIndexAction;
            foreach(Action<eFormName> action in i_Actions)
            {
                selectedIndexActionInterface.SetSelectedIndexAction(action);
            }
        }

        private void loginToApp()
        {
            LoginBarForm loginForm = GetForm(eFormName.LoginBarForm) as LoginBarForm;
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
            LoginBarForm loginForm = GetForm(eFormName.LoginBarForm) as LoginBarForm;
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

        public void AddForm(eFormName i_EnumFormName, Form i_Form)
        {
            m_eNumFormsDictionary.Add(i_EnumFormName, i_Form);
        }

        public Form GetForm(eFormName i_EnumFormName)
        {
            return m_eNumFormsDictionary[i_EnumFormName];
        }

        private void setDisplayPanel(eFormName i_EnumFormName)
        {
            Form formToSet = GetForm(i_EnumFormName);
            //Form appMainForm = GetForm("AppMainForm");
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
            //Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(GetForm(eFormName.AppMainForm));
        }

        private void fetchUserFormData(eFormName i_EnumFormName)
        {
            IComponentHandler componentHandler = GetForm(i_EnumFormName) as IComponentHandler;
            IDataHandler dataHandler = GetForm(i_EnumFormName) as IDataHandler;
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
            UserProfileForm userProfile = GetForm(eFormName.UserProfileForm) as UserProfileForm;
            Dictionary<string,string> userDataDictionary = userProfile?.GetUserProfileData();

            TextBox fullNameTextBox = userProfile.GetFullNameTextBox();
            fullNameTextBox.Text = userDataDictionary["FullName"];

            TextBox emailTextBox = userProfile.GetEmailTextBox();
            fullNameTextBox.Text = userDataDictionary["Email"];

            TextBox genderTextBox = userProfile.GetGenderTextBox();
            genderTextBox.Text = userDataDictionary["Gender"];

            TextBox birthdayTextBox = userProfile.GetBirthdayTextBox();
            birthdayTextBox.Text = userDataDictionary["Birthday"];

            TextBox hometownTextBox = userProfile.GetHometownTextBox();
            hometownTextBox.Text = userDataDictionary["Hometown"];

            TextBox educationTextBox = userProfile.GetEducationTextBox();
            educationTextBox.Text = userDataDictionary["Education"];

            TextBox workTextBox = userProfile.GetWorkTextBox();
            workTextBox.Text = userDataDictionary["Work"];

            PictureBox profilePictureBox = userProfile.GetProfilePictureBox();
            profilePictureBox.LoadAsync(userDataDictionary["Picture"]);

        }


        private void setPicture(eFormName i_EnumFormName)
        {
            //hello!! delete this comment
            IComponentHandler componentHandler = GetForm(i_EnumFormName) as IComponentHandler;
            IPictureHandler pictureHandler = GetForm(i_EnumFormName) as IPictureHandler;
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

        private void setLocation(eFormName i_EnumFormName)
        {
            IComponentHandler componentHandler = GetForm(i_EnumFormName) as IComponentHandler;
            ILocationHandler locationHandler = GetForm(i_EnumFormName) as ILocationHandler;
            ListBox listBox = componentHandler.GetListBox();
            TextBox locationTextBox = locationHandler.GetLocationTextBox();
            string location = locationHandler.GetLocationByIndex(listBox.SelectedIndex);

            locationTextBox.Text = location ?? "No location mentioned.";
            listBox.Enabled = location != null;
        }

        private void setUpdatedTime(eFormName i_EnumFormName)
        {
            IComponentHandler componentHandler = GetForm(i_EnumFormName) as IComponentHandler;
            IUpdatedTimeHandler updatedTimeHandler = GetForm(i_EnumFormName) as IUpdatedTimeHandler;
            ListBox listBox = componentHandler.GetListBox();
            TextBox updatedTimeTextBox = updatedTimeHandler.GetUpdatedTimeTextBox();
            string updatedTime = updatedTimeHandler.GetUpdatedTimeByIndex(listBox.SelectedIndex);

            updatedTimeTextBox.Text = updatedTime ?? "No updated time mentioned.";
            listBox.Enabled = updatedTime != null;
        }

        private void setPictureCount(eFormName i_EnumFormName)
        {
            IComponentHandler componentHandler = GetForm(i_EnumFormName) as IComponentHandler;
            IPictureCountHandler pictureCountHandler = GetForm(i_EnumFormName) as IPictureCountHandler;
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

        private void setDate(eFormName i_EnumFormName)
        {
            IComponentHandler componentHandler = GetForm(i_EnumFormName) as IComponentHandler;
            IDateHandler dateHandler = GetForm(i_EnumFormName) as IDateHandler;
            ListBox listBox = componentHandler.GetListBox();
            TextBox dateTextBox = dateHandler.GetDateTextBox();
            string date = dateHandler.GetDateByIndex(listBox.SelectedIndex);

            dateTextBox.Text = date ?? "No date mentioned.";
            listBox.Enabled = date != null;
        }

        private void setDescription(eFormName i_EnumFormName)
        {
            IComponentHandler componentHandler = GetForm(i_EnumFormName) as IComponentHandler;
            IDescriptionHandler descriptionHandler = GetForm(i_EnumFormName) as IDescriptionHandler;
            ListBox listBox = componentHandler.GetListBox();
            TextBox descriptionTextBox = descriptionHandler.GetDescriptionTextBox();
            string description = descriptionHandler.GetDescriptionByIndex(listBox.SelectedIndex);

            descriptionTextBox.Text = description ?? "No description mentioned.";
            listBox.Enabled = description != null;
        }

        private void setComments(eFormName i_EnumFormName)
        {
            IComponentHandler componentHandler = GetForm(i_EnumFormName) as IComponentHandler;
            ICommentsHandler commentsHandler = GetForm(i_EnumFormName) as ICommentsHandler;
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

        private void setCaption(eFormName i_EnumFormName)
        {
            IComponentHandler componentHandler = GetForm(i_EnumFormName) as IComponentHandler;
            ICaptionHandler descriptionHandler = GetForm(i_EnumFormName) as ICaptionHandler;
            ListBox listBox = componentHandler.GetListBox();
            TextBox captionTextBox = descriptionHandler.GetCaptionTextBox();
            string description = descriptionHandler.GetCaptionByIndex(listBox.SelectedIndex);

            captionTextBox.Text = description ?? "No caption mentioned.";
            listBox.Enabled = description != null;
        }



    }
}
