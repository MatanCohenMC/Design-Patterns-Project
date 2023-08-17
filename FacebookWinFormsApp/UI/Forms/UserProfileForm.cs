using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FacebookApp.Models;

namespace FacebookApp.UI.Forms
{
    public partial class UserProfileForm : Form
    {
        private readonly UserProfile r_UserProfile = new UserProfile();
        public Action m_FetchUserProfileData;

        public UserProfileForm()
        {
            InitializeComponent();
        }

        private void UserProfileForm_Load(object i_Sender, EventArgs i_EventArgs)
        {
            m_FetchUserProfileData?.Invoke();
        }

        public Dictionary<string, string> GetUserProfileData()
        {
            return r_UserProfile.FetchUserProfileData();
        }

        public TextBox GetFullNameTextBox()
        {
            return textBoxFullName;
        }

        public TextBox GetEmailTextBox()
        {
            return textBoxEmail;
        }

        public TextBox GetGenderTextBox()
        {
            return textBoxGender;
        }

        public TextBox GetBirthdayTextBox()
        {
            return textBoxBirthday;
        }

        public TextBox GetHometownTextBox()
        {
            return textBoxHometown;
        }

        public TextBox GetEducationTextBox()
        {
            return textBoxEducation;
        }

        public TextBox GetWorkTextBox()
        {
            return textBoxWork;
        }

        public PictureBox GetProfilePictureBox()
        {
            return pictureBoxProfile;
        }
    }
}