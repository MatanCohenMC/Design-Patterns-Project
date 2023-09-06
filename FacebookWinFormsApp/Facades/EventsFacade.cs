using System.Threading;
using FacebookApp.Models;
using FacebookWrapper.ObjectModel;

namespace FacebookApp.Facades
{
    public class EventsFacade
    {
        private readonly Events r_Events;
        private FacebookObjectCollection<Event> m_Events;

        public EventsFacade()
        {
            r_Events = new Events();
        }

        public FacebookObjectCollection<Event> Events
        {
            get
            {
                new Thread(() => m_Events = r_Events.GetEvents()).Start();
                return m_Events;
            }
        }
    }
}