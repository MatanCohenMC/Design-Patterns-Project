using FacebookWrapper;

namespace FacebookApp.Models
{
    public class UserProfile
    {
        private readonly Login r_Login = Login.Instance;

        public LoginResult GetUserProfile()
        {
            return r_Login.LoginResult;
        }
    }
}