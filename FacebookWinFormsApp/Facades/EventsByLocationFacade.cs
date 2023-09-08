using System;
using System.Threading;
using FacebookApp.Models;
using FacebookWrapper.ObjectModel;

namespace FacebookApp.Facades
{
    public class EventsByLocationFacade
    {
        private readonly Events r_Events;

        public event Action EventsByLocationUpdated;

        public EventsByLocationFacade()
        {
            r_Events = new Events();
        }

        public FacebookObjectCollection<Event> EventsByLocation { get; private set; }

        public void UpdateEventsByLocation(string i_Location)
        {
            new Thread(() =>
                {
                    EventsByLocation = r_Events.GetEventsByLocation(i_Location);
                    EventsByLocationUpdated?.Invoke();
                }).Start();
        }
    }
}