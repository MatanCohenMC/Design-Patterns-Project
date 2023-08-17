using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace FacebookApp.Models
{
    public class Login
    {
        private static readonly object sr_MyLock = new object();
        private static Login s_Instance = null;

        private Login()
        {
        }

        public static Login Instance
        {
            get
            {
                if(s_Instance == null)
                {
                    lock(sr_MyLock)
                    {
                        if(s_Instance == null)
                        {
                            s_Instance = new Login();
                        }
                    }
                }

                return s_Instance;
            }
        }

        public LoginResult LoginResult { get; private set; }

        public User LoggedInUser { get; private set; }

        public void LoginToApp(string i_AppId)
        {
            LoginResult = FacebookService.Login(
                i_AppId,
                "email",
                "public_profile",
                "user_age_range",
                "user_birthday",
                "user_events",
                "user_friends",
                "user_gender",
                "user_hometown",
                "user_likes",
                "user_link",
                "user_location",
                "user_photos",
                "user_posts",
                "user_videos");

            if(!string.IsNullOrEmpty(LoginResult.AccessToken))
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