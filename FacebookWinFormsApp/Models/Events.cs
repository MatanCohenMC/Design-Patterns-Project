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

        public FacebookObjectCollection<Event> GetEventsByLocation(string i_Location)
        {
            FacebookObjectCollection<Event> events = r_Login.LoggedInUser.Events;
            FacebookObjectCollection<Event> eventsByLocation = new FacebookObjectCollection<Event>();

            foreach (Event fbEvent in events)
            {
                if (fbEvent.Name != null && fbEvent.Location == i_Location)
                {
                    eventsByLocation.Add(fbEvent);
                }
            }

            return eventsByLocation;
        }
    }
}