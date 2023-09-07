using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FacebookApp.Facades;
using FacebookApp.Interfaces;
using FacebookApp.Models;

namespace FacebookApp.UI.Forms
{
    public partial class AlbumsForm : Form
    {
        private readonly AlbumsFacade r_Albums;

        public AlbumsForm()
        {
            InitializeComponent();
            r_Albums = new AlbumsFacade();
            r_Albums.AlbumUpdated += setAlbums;
        }

        private void buttonFetchAlbums_Click(object i_Sender, EventArgs i_EventArgs)
        {
            labelLoading.Visible = true;
            r_Albums.UpdateAlbums();
        }

        private void setAlbums()
        {
            if (InvokeRequired)
            {
                Invoke((Action)setAlbums);
                return;
            }

            albumBindingSource.DataSource = r_Albums.Albums;
            labelLoading.Visible = false;
        }

        private void locationLabel_Click(object sender, EventArgs e)
        {

        }

        private void countLabel_Click(object sender, EventArgs e)
        {

        }

        private void countTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}