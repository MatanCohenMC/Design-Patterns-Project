using FacebookApp.Models;
using FacebookWrapper;

namespace FacebookApp.Facades
{
    public class UserProfileFacade
    {
        private readonly UserProfile r_UserProfile;

        public UserProfileFacade()
        {
            r_UserProfile = new UserProfile();
        }

        public LoginResult GetUserProfile()
        {
            return r_UserProfile.GetUserProfile();
        }
    }
}