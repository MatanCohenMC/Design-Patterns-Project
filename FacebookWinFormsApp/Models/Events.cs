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

        public List<Dictionary<string, string>> FetchUserEvents()
        {
            List<Dictionary<string, string>> dataList = new List<Dictionary<string, string>>();

            foreach (Event fbEvent in r_Login.LoggedInUser.Events)
            {
                Dictionary<string, string> postDictionary = new Dictionary<string, string>();

                if (fbEvent.Name != null)
                {
                    postDictionary["ListBoxText"] = fbEvent.Name;
                    postDictionary["Location"] = fbEvent.Location;
                    postDictionary["Description"] = fbEvent.Description;
                    postDictionary["Date"] = fbEvent.StartTime.ToString();
                }

                dataList.Add(postDictionary);
            }

            if (dataList.Count == 0)
            {
                Dictionary<string, string> noEventsDictionary = new Dictionary<string, string>();
                noEventsDictionary["ListBoxText"] = "No Events to retrieve.";
                dataList.Add(noEventsDictionary);
            }

            return dataList;
        }
    }
}