using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookApp.Dtos;
using FacebookApp.Models;
using FacebookApp.Interfaces;
using FacebookWrapper.ObjectModel;


namespace FacebookApp.UI.Forms
{
    public partial class AlbumsForm : Form, IComponentHandler, IDataHandler, IListBoxHandler
    {
        private readonly Albums r_Albums = new Albums();
        public Action<string> m_FetchButtonPressed;
        private Login m_Login = Login.Instance;

        public AlbumsForm()
        {
            InitializeComponent();
        }

        private void pictureBoxAlbum_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void fetch_albums_button_Click(object sender, EventArgs e)
        {
            m_FetchButtonPressed?.Invoke("AlbumsForm");
        }

        public ListBox GetListBox()
        {
            return this.listBoxAlbums;
        }

        public void FetchListBoxData(out List<Dictionary<string, string>> DataList)
        {
            DataList = r_Albums.FetchUserAlbums();
        }

        private void listBoxAlbums_SelectedIndexChanged(object sender, EventArgs e)
        {
            string PictureAlbumURL;
            r_Albums.GetPictureAlbumURL(out PictureAlbumURL, listBoxAlbums.SelectedIndex);

            if (PictureAlbumURL != null)
            {
                pictureBoxAlbum.LoadAsync(PictureAlbumURL);
            }
            else
            {
                pictureBoxAlbum.Image = pictureBoxAlbum.ErrorImage;
            }
        }
    }
}