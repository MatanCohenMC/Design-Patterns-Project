using FacebookWrapper.ObjectModel;

namespace FacebookApp.Models
{
    public class Groups
    {
        private readonly Login r_Login = Login.Instance;

        public FacebookObjectCollection<Group> GetGroups()
        {
            return r_Login.LoggedInUser.Groups;
        }
    }
}