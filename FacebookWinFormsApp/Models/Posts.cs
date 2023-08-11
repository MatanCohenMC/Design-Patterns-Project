using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookApp.Dtos;

namespace FacebookApp.Models
{
    public class Posts
    {
        private readonly Login r_Login = Login.Instance;
        
        public List<Dictionary<string, string>> FetchUserPosts()
        {
            List<Dictionary<string, string>> dataList = new List<Dictionary<string, string>>();

            foreach (Post post in r_Login.LoggedInUser.Posts)
            {
                Dictionary<string, string> postDictionary = new Dictionary<string, string>();

                if (post.Message != null)
                {
                    postDictionary["ListBoxText"] = post.Message;
                    postDictionary["Comment"] = post.Comments.ToString();
                    postDictionary["Caption"] = post.Caption;
                    postDictionary["CreatedTime"] = post.CreatedTime.ToString();
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
                noPostsDictionary["ListBoxText"] = "No Posts to retrieve :(";
                dataList.Add(noPostsDictionary);
            }

            return dataList;
        }
    }
}