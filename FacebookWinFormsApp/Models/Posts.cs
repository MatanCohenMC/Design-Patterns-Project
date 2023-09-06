using System;
using System.Collections.Generic;
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
                o_PictureUrl = DataList[randomIndex].TryGetValue("Picture", out var pictureUrl) ? pictureUrl : string.Empty;
                o_Date = DataList[randomIndex].TryGetValue("Date", out var date) ? date : string.Empty;
                o_Location = DataList[randomIndex].TryGetValue("Location", out var location) ? location : string.Empty;
                o_Text = DataList[randomIndex].TryGetValue("ListBoxText", out var text) ? text : string.Empty;
            }
        }

        public FacebookObjectCollection<Post> GetPosts()
        {
            return r_Login.LoggedInUser.Posts;
        }
    }
}