using System;
using System.Windows.Forms;
using FacebookApp.Facades;

namespace FacebookApp.UI.Forms
{
    public partial class AlbumsForm : Form
    {
        private readonly AlbumsFacade r_AlbumsFacade;

        public AlbumsForm()
        {
            InitializeComponent();
            r_AlbumsFacade = new AlbumsFacade();
            r_AlbumsFacade.AlbumUpdated += setAlbumsFacade;
        }

        private void buttonFetchAlbums_Click(object i_Sender, EventArgs i_EventArgs)
        {
            labelLoading.Visible = true;
            r_AlbumsFacade.UpdateAlbums();
        }

        private void setAlbumsFacade()
        {
            if (InvokeRequired)
            {
                Invoke((Action)setAlbumsFacade);
                return;
            }

            albumBindingSource.DataSource = r_AlbumsFacade.Albums;
            labelLoading.Visible = false;
        }
    }
}