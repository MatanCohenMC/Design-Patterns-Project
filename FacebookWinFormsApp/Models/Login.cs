using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using System.Windows.Forms;
using System.ComponentModel;
using System.Data;
using System.Drawing;


namespace FacebookApp.Models
{
    public class Login
    {
        private static Login s_Instance = null;
        public LoginResult m_LoginResult { get; private set; }

        public User m_LoggedInUser { get; private set; }

        //private FacebookWrapper.LoginResult m_LoginResult;

        public static Login Instance
        {
            get
            {
                if (s_Instance == null)
                {
                    s_Instance = new Login();
                }

                return s_Instance;
            }
        }

        public void LoginToApp(string i_AppID)
        {
            m_LoginResult = FacebookService.Login(i_AppID,
                "email", "public_profile", "user_age_range", "user_birthday",
                "user_events", "user_friends", "user_gender", "user_hometown", "user_likes",
                "user_link", "user_location", "user_photos", "user_posts", "user_videos");
            
            if (!string.IsNullOrEmpty(m_LoginResult.AccessToken))
            {
                m_LoggedInUser = m_LoginResult.LoggedInUser;
            }
        }
    }
}