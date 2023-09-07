using System;
using System.Collections.Generic;
using System.Threading;
using FacebookApp.Models;
using FacebookWrapper.ObjectModel;

namespace FacebookApp.Facades
{
    public class GroupsFacade
    {
        private readonly Groups r_Groups;

        public event Action GroupsUpdated;

        public GroupsFacade()
        {
            r_Groups = new Groups();
        }
        public FacebookObjectCollection<Group> Groups { get; private set; }

        public void updateGroups()
        {
            new Thread(
                () =>
                    {
                Groups = r_Groups.GetGroups();
                GroupsUpdated?.Invoke();
            }).Start();
        }

    }
}