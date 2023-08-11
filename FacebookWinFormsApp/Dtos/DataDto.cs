using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookApp.Dtos
{
    public class DataDto
    {
        public Dictionary<string, string> Data { get; set; } = new Dictionary<string, string>();

        public DataDto() { }

        public void AddPicture(string i_Picture)
        {
            Data.Add("picture", i_Picture);
        }

        public void AddDescription(string i_Description)
        {
            Data.Add("description", i_Description);
        }

        public void AddLocation(string i_Location)
        {
            Data.Add("location", i_Location);
        }

        public void AddDate(string i_Date)
        {
            Data.Add("date", i_Date);
        }

        public void AddLikes(string i_Likes)
        {
            Data.Add("likes", i_Likes);
        }

        public void AddComments(string i_Comments)
        {
            Data.Add("comments", i_Comments);
        }
    }
}
