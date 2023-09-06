using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace FacebookApp.Models
{
    public class Events
    {
        private readonly Login r_Login = Login.Instance;

        public FacebookObjectCollection<Event> GetEvents()
        {
            return r_Login.LoggedInUser.Events;
        }

    }
}