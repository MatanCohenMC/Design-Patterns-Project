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
        private Login login = Login.Instance;
        private readonly User r_User;

        public Posts()
        {
            r_User = login.LoggedInUser;
        }

        public List<DataDto> FetchUserPosts()
        {
            List<string> postsMessages = new List<string>();

            foreach (Post post in r_User.Posts)
            {
                if (post.Message != null)
                {
                    postsMessages.Add(post.Message);
                }
                else if (post.Caption != null)
                {
                    postsMessages.Add(post.Caption);
                }
                else
                {
                    postsMessages.Add(string.Format("[{0}]", post.Type));
                }
            }

            if (postsMessages.Count == 0)
            {
                postsMessages.Add("No Posts to retrieve :(");
            }

            return new List<DataDto>();
        }
    }
}