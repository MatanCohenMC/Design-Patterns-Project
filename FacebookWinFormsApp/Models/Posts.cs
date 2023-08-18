using System;
using System.Collections.Generic;
using System.Linq;
using FacebookWrapper.ObjectModel;

namespace FacebookApp.Models
{
    public class Posts
    {
        private readonly Login r_Login = Login.Instance;

        public Posts()
        {
            DataList = new List<Dictionary<string, string>>();
        }

        public List<Dictionary<string, string>> DataList { get; private set; }

        public List<Dictionary<string, string>> FetchUserPosts()
        {
            DataList?.Clear();
            List<Dictionary<string, string>> dataList = new List<Dictionary<string, string>>();

            foreach(Post post in r_Login.LoggedInUser.Posts)
            {
                if(post != null)
                {
                    Dictionary<string, string> postDictionary = new Dictionary<string, string>();

                    postDictionary["Date"] = post.CreatedTime.ToString();
                    postDictionary["ListBoxText"] = post.Message;
                    postDictionary["Caption"] = post.Caption;
                    postDictionary["Picture"] = post.PictureURL;
                    postDictionary["Location"] = post.Place?.Name;
                    dataList.Add(postDictionary);
                }
            }

            DataList = dataList;
            return dataList;
        }

        public string GetPictureUrl(int i_SelectedIndex)
        {
            return DataList[i_SelectedIndex]["Picture"];
        }

        public string GetLocation(int i_SelectedIndex)
        {
            return DataList[i_SelectedIndex]["Location"];
        }

        public string GetDate(int i_SelectedIndex)
        {
            return DataList[i_SelectedIndex]["Date"];
        }

        public string GetCaption(int i_SelectedIndex)
        {
            return DataList[i_SelectedIndex]["Caption"];
        }

        public ICollection<Comment> GetComments(int i_SelectedIndex)
        {
            return r_Login.LoggedInUser.Posts[i_SelectedIndex].Comments;
        }

        public List<Dictionary<string, string>> FetchUserPostsByDateRange(
            DateTime i_DateTimeFrom,
            DateTime i_DateTimeTo)
        {
            List<Dictionary<string, string>> dataList = FetchUserPosts();

            foreach(Dictionary<string, string> postDictionary in dataList.ToList())
            {
                DateTime postDateTime = DateTime.Parse(postDictionary["Date"]);

                if(postDateTime < i_DateTimeFrom || postDateTime > i_DateTimeTo)
                {
                    dataList.Remove(postDictionary);
                }
            }

            return dataList;
        }

        public void GetRandomPost(out string o_PictureUrl, out string o_Date, out string o_Location, out string o_Text)
        {
            Random random = new Random();
            int randomIndex = random.Next(0, DataList.Count);
            o_PictureUrl = string.Empty;
            o_Date = string.Empty;
            o_Location = string.Empty;
            o_Text = string.Empty;

            if(DataList.Count == 0)
            {
                DataList = FetchUserPosts();
            }

            if(DataList.Count > 0)
            {
                o_PictureUrl = DataList[randomIndex].TryGetValue("Picture", out var pictureUrl)
                                   ? pictureUrl
                                   : string.Empty;
                o_Date = DataList[randomIndex].TryGetValue("Date", out var date) ? date : string.Empty;
                o_Location = DataList[randomIndex].TryGetValue("Location", out var location) ? location : string.Empty;
                o_Text = DataList[randomIndex].TryGetValue("ListBoxText", out var text) ? text : string.Empty;
            }
        }
    }
}