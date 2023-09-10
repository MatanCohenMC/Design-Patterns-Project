using System;
using System.Threading;
using FacebookApp.Models;
using FacebookWrapper.ObjectModel;

namespace FacebookApp.Facades
{
    public class EventsFacade
    {
        private readonly Events r_Events;

        public event Action EventsUpdated;

        public EventsFacade()
        {
            r_Events = new Events();
        }

        public FacebookObjectCollection<Event> Events { get; private set; }

        public void UpdateEvents()
        {
            new Thread(
                () =>
                    {
                        Events = r_Events.GetEvents();
                        EventsUpdated?.Invoke();
                    }).Start();
        }
    }
}