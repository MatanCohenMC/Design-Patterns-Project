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

        Login() { }
        private static readonly object lock = new object ();
        private static Login s_Instance = null;
        public static Login s_Instance
        {
            get
            {
                if (s_Instance == null)
                {
                    lock (lock)
                    {
                        if (s_Instance == null)
                        {
                            s_Instance = new Login();
                        }
                    }
                }
                return s_Instance;
            }
        }



        //private static Login s_Instance = null;
        public LoginResult LoginResult { get; private set; }

        public User LoggedInUser { get; private set; }

        //private FacebookWrapper.LoginResult m_LoginResult;

        //public static Login Instance
        //{
        //    get
        //    {
        //        if (s_Instance == null)
        //        {
        //            s_Instance = new Login();
        //        }

        //        return s_Instance;
        //    }
        //}

        public void LoginToApp(string i_AppID)
        {
            LoginResult = FacebookService.Login(i_AppID,
                "email", "public_profile", "user_age_range", "user_birthday",
                "user_events", "user_friends", "user_gender", "user_hometown", "user_likes",
                "user_link", "user_location", "user_photos", "user_posts", "user_videos");
            
            if (!string.IsNullOrEmpty(LoginResult.AccessToken))
            {
                LoggedInUser = LoginResult.LoggedInUser;
            }
        }

        public bool IsLoggedIn()
        {
            bool isLoggedIn = string.IsNullOrEmpty(LoginResult.ErrorMessage);
            return isLoggedIn;
        }
    }
}