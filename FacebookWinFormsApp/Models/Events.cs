using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;
using FacebookApp.Dtos;
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

            foreach (Event fbEvent in r_Login.LoggedInUser.Events)
            {
                Dictionary<string, string> eventDictionary = new Dictionary<string, string>();

                if (fbEvent.Name != null)
                {
                    eventDictionary["ListBoxText"] = fbEvent.Name;
                    eventDictionary["Location"] = fbEvent.Location;
                    eventDictionary["Description"] = fbEvent.Description;
                    eventDictionary["Date"] = fbEvent.StartTime.ToString();
                    eventDictionary["Picture"] = fbEvent.PictureNormalURL;
                    
                }

                dataList.Add(eventDictionary);
            }

            if (dataList.Count == 0)
            {
                Dictionary<string, string> noEventsDictionary = new Dictionary<string, string>();
                noEventsDictionary["ListBoxText"] = "No events to retrieve.";
                dataList.Add(noEventsDictionary);
            }

            m_DataList = dataList;
            return dataList;
        }

        public string GetLocation(int i_SelectedIndex)
        {
            string location = null;
            try
            {
                location = m_DataList[i_SelectedIndex]["Location"];
            }
            catch(Exception e)
            {

            }

            return location;
        }
        public string GetDescription(int i_SelectedIndex)
        {
            return m_DataList[i_SelectedIndex]["Description"];
        }
        public string GetDate(int i_SelectedIndex)
        {
            return m_DataList[i_SelectedIndex]["Date"];
        }
        public string GetPictureUrl(int i_SelectedIndex)
        {
            return m_DataList[i_SelectedIndex]["Picture"];
        }

    }
}