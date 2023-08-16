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

            dataDictionary["FullName"] = r_Login.LoggedInUser.Name;
            dataDictionary["Email"] = r_Login.LoggedInUser.Email;
            dataDictionary["Gender"] = r_Login.LoggedInUser.Gender?.ToString();
            dataDictionary["Birthday"] = r_Login.LoggedInUser.Birthday;
            dataDictionary["Hometown"] = r_Login.LoggedInUser.Hometown?.ToString();
            dataDictionary["Education"] = r_Login.LoggedInUser.Educations?.ToString();
            dataDictionary["Work"] = r_Login.LoggedInUser.WorkExperiences?.ToString();
            dataDictionary["Picture"] = r_Login.LoggedInUser.PictureLargeURL;

            m_DataList = dataDictionary;
            return dataDictionary;
        }
        
    }
}
