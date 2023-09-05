using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace FacebookApp.Models
{
    public class Events
    {
        private readonly Login r_Login = Login.Instance;

        public List<Dictionary<string, string>> DataList { get; private set; }

        public List<Dictionary<string, string>> FetchUserEvents()
        {
            List<Dictionary<string, string>> dataList = new List<Dictionary<string, string>>();

            if(r_Login.LoggedInUser.Events.Count > 0)
            {
                foreach(Event fbEvent in r_Login.LoggedInUser.Events)
                {
                    if(fbEvent.Name != null)
                    {
                        Dictionary<string, string> eventDictionary = new Dictionary<string, string>();

                        eventDictionary["ListBoxText"] = fbEvent.Name;
                        eventDictionary["Location"] = fbEvent.Location;
                        eventDictionary["Description"] = fbEvent.Description;
                        eventDictionary["Date"] = fbEvent.StartTime.ToString();
                        eventDictionary["Picture"] = fbEvent.PictureNormalURL;
                        dataList.Add(eventDictionary);
                    }
                }
            }

            DataList = dataList;
            return dataList;
        }

        public FacebookObjectCollection<Event> GetEvents()
        {
            return r_Login.LoggedInUser.Events;
        }

        public List<Dictionary<string, string>> FetchUserEventsByLocation(string i_Location)
        {
            List<Dictionary<string, string>> dataList = FetchUserEvents();

            foreach(Dictionary<string, string> eventDictionary in dataList)
            {
                if(eventDictionary["Location"] != i_Location)
                {
                    dataList.Remove(eventDictionary);
                }
            }

            return dataList;
        }

        public string GetDescription(int i_SelectedIndex)
        {
            string description = null;

            if(DataList.Count > 0)
            {
                description = DataList[i_SelectedIndex]["Description"];
            }

            return description;
        }

        public string GetDate(int i_SelectedIndex)
        {
            string date = null;

            if(DataList.Count > 0)
            {
                date = DataList[i_SelectedIndex]["Date"];
            }

            return date;
        }

        public string GetPictureUrl(int i_SelectedIndex)
        {
            string pictureUrl = null;

            if(DataList.Count > 0)
            {
                pictureUrl = DataList[i_SelectedIndex]["Picture"];
            }

            return pictureUrl;
        }
    }
}