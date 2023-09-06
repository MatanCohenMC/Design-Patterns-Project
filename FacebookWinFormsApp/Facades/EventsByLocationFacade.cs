using System.Threading;
using FacebookApp.Models;
using FacebookWrapper.ObjectModel;

namespace FacebookApp.Facades
{
    public class EventsByLocationFacade
    {
        private readonly Events r_Events;
        private FacebookObjectCollection<Event> m_Events;
        public EventsByLocationFacade(){
            r_Events = new Events();
        }

        public FacebookObjectCollection<Event> Events
        {
            get
            {
                m_Events = r_Events.GetEvents();
                return m_Events;
            }
        }

        private UpdateEventsByLocation(string i_Location)
        {
            new Thread(() => m_Events = r_Events.GetEventsByLocation(i_Location)).Start();
        }

        
    }
}