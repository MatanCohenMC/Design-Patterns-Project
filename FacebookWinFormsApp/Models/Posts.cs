using FacebookWrapper.ObjectModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookApp.Models
{
    public class Posts
    {
        private readonly Login r_Login = Login.Instance;
        bool m_IsDataFetched = false;

        public List<Dictionary<string, string>> m_DataList { get; private set; }

        public Posts()
        {
            m_DataList = new List<Dictionary<string, string>>();
        }

        public List<Dictionary<string, string>> FetchUserPosts()
        {
            m_IsDataFetched = false;
            m_DataList?.Clear();
            List<Dictionary<string, string>> dataList = new List<Dictionary<string, string>>();

            foreach (Post post in r_Login.LoggedInUser.Posts)
            {
                if (post != null)
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

            if (dataList.Count == 0)
            {
                Dictionary<string, string> noPostsDictionary = new Dictionary<string, string>();
                noPostsDictionary["ListBoxText"] = "No posts to retrieve.";
                dataList.Add(noPostsDictionary);
            }

            m_DataList = dataList;
            m_IsDataFetched = true;
            return dataList;
        }

         public string GetPictureUrl(int i_SelectedIndex)
        {
            return m_DataList[i_SelectedIndex]["Picture"];
        }

        public string GetLocation(int i_SelectedIndex)
        {
            return m_DataList[i_SelectedIndex]["Location"];
        }

        public string GetDate(int i_SelectedIndex)
        {
            return m_DataList[i_SelectedIndex]["Date"];
        }

        public string GetCaption(int i_SelectedIndex)
        {
            return m_DataList[i_SelectedIndex]["Caption"];
        }

        public ICollection<Comment> GetComments(int i_SelectedIndex)
        {
            return r_Login.LoggedInUser.Posts[i_SelectedIndex].Comments;
        }

        public List<Dictionary<string, string>> FetchUserPostsByDateRange(DateTime i_DateTimeFrom, DateTime i_DateTimeTo)
        {
            List<Dictionary<string, string>> dataList = FetchUserPosts();

            foreach (Dictionary<string, string> postDictionary in dataList.ToList())
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
            if (m_DataList.Count == 0)
            {
                m_DataList = FetchUserPosts();
            }

            if (m_DataList.Count == 0)
            {
                o_PictureUrl = "";
                o_Date = "";
                o_Location = "";
                o_Text = "";
                return;
            }

            Random random = new Random();
            int randomIndex = random.Next(0, m_DataList.Count);

            o_PictureUrl = m_DataList[randomIndex].TryGetValue("Picture", out var pictureUrl) ? pictureUrl : "";
            o_Date = m_DataList[randomIndex].TryGetValue("Date", out var date) ? date : "";
            o_Location = m_DataList[randomIndex].TryGetValue("Location", out var location) ? location : "";
            o_Text = m_DataList[randomIndex].TryGetValue("ListBoxText", out var text) ? text : "";
        }

    }
}