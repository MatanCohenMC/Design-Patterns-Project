using FacebookWrapper.ObjectModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Windows.Forms;
using FacebookApp.Dtos;

namespace FacebookApp.Models
{
    public class Posts
    {
        private readonly Login r_Login = Login.Instance;
        public List<Dictionary<string, string>> m_DataList { get; private set; }


        public List<Dictionary<string, string>> FetchUserPosts()
        {
            List<Dictionary<string, string>> dataList = new List<Dictionary<string, string>>();

            foreach (Post post in r_Login.LoggedInUser.Posts)
            {
                Dictionary<string, string> postDictionary = new Dictionary<string, string>();


                postDictionary["Date"] = post.CreatedTime.ToString();
                if (post.Message != null)
                {
                    postDictionary["ListBoxText"] = post.Message;
                    postDictionary["Caption"] = post.Caption;
                    postDictionary["Picture"] = post.PictureURL;
                    postDictionary["Location"] = post.Place?.Name;
                }
                else
                {
                    postDictionary["Type"] = string.Format("[{0}]", post.Type);
                    
                }

                dataList.Add(postDictionary);
            }

            if (dataList.Count == 0)
            {
                Dictionary<string, string> noPostsDictionary = new Dictionary<string, string>();
                noPostsDictionary["ListBoxText"] = "No posts to retrieve.";
                dataList.Add(noPostsDictionary);
            }

            m_DataList = dataList;
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
            List<Dictionary<string, string>> returnedDataList = new List<Dictionary<string, string>>();

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
    }
}