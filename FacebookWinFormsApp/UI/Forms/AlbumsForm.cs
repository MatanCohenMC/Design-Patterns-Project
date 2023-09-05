using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FacebookApp.Interfaces;
using FacebookApp.Models;

namespace FacebookApp.UI.Forms
{
    public partial class AlbumsForm : Form
    {
        private readonly Albums r_Albums = new Albums();

        public AlbumsForm()
        {
            InitializeComponent();
        }

        private void buttonFetchAlbums_Click(object i_Sender, EventArgs i_EventArgs)
        {
            fetchAlbums();
        }

        private void fetchAlbums()
        {
            albumBindingSource.DataSource = r_Albums.GetAlbums();
        }
    }
}