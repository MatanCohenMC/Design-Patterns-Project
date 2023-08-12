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
            setPicture();
            SetLocation();
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

            if (albumUpdatedTime != null && albumUpdatedTime != String.Empty)
            {
                textBoxUpdatedTime.Text = albumUpdatedTime;
            }
            else
            {
                textBoxUpdatedTime.Text = "No updated time mentioned.";
            }
        }

        private void SetLocation()
        {
            string albumLocation;
            r_Albums.GetLocation(out albumLocation, listBoxAlbums.SelectedIndex);

            if (albumLocation != null)
            {
                textBoxLocation.Text = albumLocation;
            }
            else
            {
                textBoxLocation.Text = "No Location mentioned.";
            }
        }

        private void setPicture()
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

        private void setDescription()
        {
            string albumDescription;
            r_Albums.GetDiscription(out albumDescription, listBoxAlbums.SelectedIndex);

            if (albumDescription != null)
            {
                textBoxDescription.Text = albumDescription;
            }
            else
            {
                textBoxDescription.Text = "No description mentioned.";
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}