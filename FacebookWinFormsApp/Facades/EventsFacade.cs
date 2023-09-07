using System;
using System.Threading;
using FacebookApp.Models;
using FacebookWrapper.ObjectModel;

namespace FacebookApp.Facades
{
    public class EventsFacade
    {
        private readonly Events r_Events;
        private FacebookObjectCollection<Event> m_Events;
        public event Action EventsUpdated;

        public EventsFacade()
        {
            r_Events = new Events();
        }

        public FacebookObjectCollection<Event> Events
        {
            get
            {
                return m_Events;
            }
        }

        public void UpdateEvents()
        {
            new Thread(
                () =>
                    {
                    m_Events = r_Events.GetEvents();
                    EventsUpdated?.Invoke();
                }).Start();
        }
    }
}