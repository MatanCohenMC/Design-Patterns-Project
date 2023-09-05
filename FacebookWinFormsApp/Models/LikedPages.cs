using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace FacebookApp.Models
{
    public class LikedPages
    {
        private readonly Login r_Login = Login.Instance;

        public FacebookObjectCollection<Page> GetLikedPages()
        {
            return r_Login.LoggedInUser.LikedPages;
        }
    }
}