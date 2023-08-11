using FacebookApp.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookApp.Models;
using FacebookApp.Dtos;
using FacebookWrapper.ObjectModel;

namespace FacebookApp.UI.Forms
{
    public partial class FormPages : Form, IComponentHandler, IDataHandler, IListBoxHandler
    {
        private readonly LikedPages r_LikedPages = new LikedPages();
        public Action<string> m_FetchButtonPressed;
        private Login m_Login = Login.Instance;

        public FormPages()
        {
            InitializeComponent();
        }

        private void buttonFetchPages_Click(object sender, EventArgs e)
        {
            m_FetchButtonPressed?.Invoke("PagesForm");
        }

        public ListBox GetListBox()
        {
            return this.listBoxLikedPages;
        }

        public void FetchListBoxData(out List<Dictionary<string, string>> DataList)
        {
            DataList = r_LikedPages.FetchUserLikedPages();

        }


        private void ListBoxLikedPages_SelectedIndexChanged(object sender, EventArgs e)
        {
            string PictureAlbumURL;
            r_LikedPages.GetPictureAlbumURL(out PictureAlbumURL, listBoxLikedPages.SelectedIndex);

            if (PictureAlbumURL != null)
            {
                pictureBoxPage.LoadAsync(PictureAlbumURL);
            }
            else
            {
                pictureBoxPage.Image = pictureBoxPage.ErrorImage;
            }
        }
    }
}