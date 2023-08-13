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

        private void fetch_albums_button_Click(object sender, EventArgs e)
        {
            m_FetchButtonPressed?.Invoke("AlbumsForm");
        }

        public ListBox GetListBox()
        {
            return listBoxAlbums;
        }

        public void FetchListBoxData(out List<Dictionary<string, string>> DataList)
        {
            DataList = r_Albums.FetchUserAlbums();
        }

        private void listBoxAlbums_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetAlbumPicture();
            setAlbumLocation();
            setDescription();
            setGetUpdatedTime();
            setPictureCount();
        }

        private void setPictureCount()
        {
            string albumPictureCount;

            r_Albums.GetPictureCount(out albumPictureCount, listBoxAlbums.SelectedIndex);
            if (albumPictureCount != null && albumPictureCount != String.Empty)
            {
                textBoxPictureAmount.Text = albumPictureCount;
            }
            else
            {
                textBoxPictureAmount.Text = "0";
            }
        }

        private void setGetUpdatedTime()
        {
            string albumUpdatedTime;

            r_Albums.GetUpdatedTime(out albumUpdatedTime, listBoxAlbums.SelectedIndex);
            textBoxUpdatedTime.Text = !string.IsNullOrEmpty(albumUpdatedTime) ? albumUpdatedTime : "No updated time mentioned.";
        }

        private void SetAlbumPicture()
        {
            FormUtility.SetPicture(listBoxAlbums, pictureBoxAlbum, index => r_Albums.GetPictureURL(index));
        }

        private void setDescription()
        {
            string albumDescription;

            r_Albums.GetDescription(out albumDescription, listBoxAlbums.SelectedIndex);
            textBoxDescription.Text = albumDescription ?? "No description mentioned.";
        }

        private void setAlbumLocation()
        {
            FormUtility.SetLocation(listBoxAlbums, textBoxLocation, index => r_Albums.GetLocation(index));
        }
    }
}