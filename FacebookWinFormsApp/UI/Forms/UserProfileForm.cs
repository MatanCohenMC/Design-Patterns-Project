using FacebookApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacebookApp.UI.Forms
{
    public partial class UserProfileForm : Form
    {
        private readonly UserProfile r_UserProfile = new UserProfile();
        private readonly string r_FormName = "UserProfileForm";
        public Action m_LoadButtonPressed;
        public Action m_FetchUserProfileData;

        //hello delete this comment
        public UserProfileForm()
        {
            InitializeComponent();
        }

        private void UserProfileForm_Load(object sender, EventArgs e)
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
