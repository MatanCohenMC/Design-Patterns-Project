using FacebookWrapper.ObjectModel;
using System;
using System.Collections;
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
        public List<Dictionary<string, string>> m_DataList { get; private set; }


        public List<Dictionary<string, string>> FetchUserPosts()
        {
            List<Dictionary<string, string>> dataList = new List<Dictionary<string, string>>();

            foreach (Post post in r_Login.LoggedInUser.Posts)
            {
                Dictionary<string, string> postDictionary = new Dictionary<string, string>();

                if (post.Message != null)
                {
                    postDictionary["ListBoxText"] = post.Message;
                    postDictionary["Comments"] = post.Comments.ToString();
                    postDictionary["Caption"] = post.Caption;
                    postDictionary["CreatedTime"] = post.CreatedTime.ToString();
                    postDictionary["Picture"] = post.PictureURL;
                    postDictionary["Place"] = post.Place.Name;
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
                noPostsDictionary["ListBoxText"] = "There are no posts.";
                dataList.Add(noPostsDictionary);
            }

            m_DataList = dataList;
            return dataList;
        }

        public void GetCreatedDate(out string i_PostCreatedDate, int i_SelectedIndex)
        {
            try
            {
                Dictionary<string, string> postData = m_DataList[i_SelectedIndex];
                i_PostCreatedDate = postData["CreatedTime"];
            }
            catch(Exception e)
            {
                MessageBox.Show("Couldn't load the created date.");
                i_PostCreatedDate = "Unknown";
            }
        }

        public void GetComments(out ICollection<Comment> i_PostComments, int i_SelectedIndex)
        {
            try
            {
                i_PostComments = r_Login.LoggedInUser.Posts[i_SelectedIndex].Comments;

            }
            catch (Exception)
            {
                MessageBox.Show("Couldn't load the comments.");
                i_PostComments = null;
            }
        }

        public void GetPictureURL(out string picturePostURL, int selectedIndex)
        {
            try
            {
                Dictionary<string, string> postData = m_DataList[selectedIndex];
                picturePostURL = postData["Picture"];
            }
            catch(Exception)
            {
                MessageBox.Show("Couldn't load the picture.");
                picturePostURL = null;
            }
        }

        public void GetLocation(out string postLocation, int selectedIndex)
        {
            try
            {
                Dictionary<string, string> postData = m_DataList[selectedIndex];
                postLocation = postData["Place"];
            }
            catch(Exception)
            {
                MessageBox.Show("Couldn't load the location.");
                postLocation = "Unknown";
            }
        }

        public void GetTotalLikes(out string totalLikes, int selectedIndex)
        {
            try
            {
                int countOfUsers = 0;

                ICollection<User> usersThatLikedThePost = r_Login.LoggedInUser.Posts[selectedIndex].LikedBy;
                foreach (User user in usersThatLikedThePost)
                {
                    if (user != null)
                    {
                        countOfUsers++;
                    }
                    else
                    {
                        break;
                    }
                }

                totalLikes = countOfUsers.ToString();
            }
            catch(Exception)
            {
                MessageBox.Show("Couldn't load the users that liked the post.");
                totalLikes = "Unknown";
            }
        }

        public void GetCaption(out string i_PostCaption, int i_SelectedIndex)
        {
            try
            {
                Dictionary<string, string> postData = m_DataList[i_SelectedIndex];
                i_PostCaption = postData["Caption"];
            }
            catch (Exception)
            {
                MessageBox.Show("Couldn't load the Caption.");
                i_PostCaption = "Unknown";
            }
        }
    }
}