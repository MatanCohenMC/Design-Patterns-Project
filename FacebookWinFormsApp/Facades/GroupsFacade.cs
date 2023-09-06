using System.Collections.Generic;
using System.Threading;
using FacebookApp.Models;
using FacebookWrapper.ObjectModel;

namespace FacebookApp.Facades
{
    public class GroupsFacade
    {
        private readonly Groups r_Groups;
        private FacebookObjectCollection<Group> m_Groups;

        public GroupsFacade()
        {
            r_Groups = new Groups();
        }
        public FacebookObjectCollection<Group> Groups
        {
            get
            {
                new Thread(() => m_Groups = r_Groups.GetGroups()).Start();

                return m_Groups;
            }
        }

    }
}