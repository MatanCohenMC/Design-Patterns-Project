using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookApp.Models
{
    public class UserProfile
    {
        private readonly Login r_Login = Login.Instance;
        public Dictionary<string, string> m_DataList { get; private set; }


        public Dictionary<string, string> FetchUserProfileData()
        {
            Dictionary<string, string> dataDictionary= new Dictionary<string, string>();

            dataDictionary["FullName"] = r_Login.LoggedInUser.FirstName;

            return dataDictionary;
        }
    }
}
