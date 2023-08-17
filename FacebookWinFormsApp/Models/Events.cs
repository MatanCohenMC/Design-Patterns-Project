using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;
using FacebookWrapper.ObjectModel;

namespace FacebookApp.Models
{
    public class Events
    {
        private readonly Login r_Login = Login.Instance;
        public List<Dictionary<string, string>> m_DataList { get; private set; }
        
        public List<Dictionary<string, string>> FetchUserEvents()
        {
            List<Dictionary<string, string>> dataList = new List<Dictionary<string, string>>();

            if(r_Login.LoggedInUser.Events.Count > 0)
            {
                foreach (Event fbEvent in r_Login.LoggedInUser.Events)
                {
                    if (fbEvent.Name != null)
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

            m_DataList = dataList;
            return dataList;
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

        public string GetLocation(int i_SelectedIndex)
        {
            string location = null;
            if (m_DataList.Count > 0)
            {
                location = m_DataList[i_SelectedIndex]["Location"];
            }

            return location;
        }
        public string GetDescription(int i_SelectedIndex)
        {
            string description = null;
            if(m_DataList.Count > 0)
            {
                description = m_DataList[i_SelectedIndex]["Description"];
            }

            return description;
        }
        public string GetDate(int i_SelectedIndex)
        {
            string date = null;
            if (m_DataList.Count > 0)
            {
                date = m_DataList[i_SelectedIndex]["Date"];
            }

            return date;
        }
        public string GetPictureUrl(int i_SelectedIndex)
        {
            string pictureUrl = null;
            if (m_DataList.Count > 0)
            {
                pictureUrl = m_DataList[i_SelectedIndex]["Picture"];
            }

            return pictureUrl;
        }

    }
}