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
using FacebookApp.Models;
using FacebookApp.Interfaces;
using FacebookWrapper.ObjectModel;
using CefSharp.ModelBinding;


namespace FacebookApp.UI.Forms
{
    public partial class AlbumsForm : Form, IComponentHandler, IDataHandler, IPictureHandler, ILocationHandler, IPictureCountHandler, IUpdatedTimeHandler, ISetFetchAction, ISetSelectedIndexAction
    {
        private readonly Albums r_Albums = new Albums();
        //private readonly string r_FormName = "AlbumsForm";
        private readonly eFormName r_FormName = eFormName.AlbumForm;
        public Action<eFormName> m_FetchButtonPressed;
        public Action<eFormName> m_SelectedIndexChanged;

        public AlbumsForm()
        {
            InitializeComponent();
        }

        private void fetch_albums_button_Click(object sender, EventArgs e)
        {
            m_FetchButtonPressed?.Invoke(r_FormName);
        }

        public void FetchListBoxData(out List<Dictionary<string, string>> DataList)
        {
            DataList = r_Albums.FetchUserAlbums();
        }

        private void listBoxAlbums_SelectedIndexChanged(object sender, EventArgs e)
        {
            m_SelectedIndexChanged?.Invoke(r_FormName);
        }

        public ListBox GetListBox()
        {
            return listBoxAlbums;
        }

        public PictureBox GetPictureBox()
        {
            return pictureBoxAlbum; 
        }

        public string GetPictureUrlByIndex(int i_Index)
        {
            return r_Albums.GetPictureUrl(i_Index);
        }

        public TextBox GetLocationTextBox()
        {
            return textBoxLocation;
        }

        public string GetLocationByIndex(int i_Index)
        {
            return r_Albums.GetLocation(i_Index);
        }

        public TextBox GetUpdatedTimeTextBox()
        {
            return textBoxUpdatedTime;
        }

        public string GetUpdatedTimeByIndex(int i_Index)
        {
            return r_Albums.GetUpdatedTime(i_Index);
        }

        public TextBox GetPictureCountTextBox()
        {
            return textBoxPictureCount;
        }

        public string GetPictureCountByIndex(int i_Index)
        {
            return r_Albums.GetPictureCount(i_Index);
        }

        public void SetFetchAction(Action<eFormName> action)
        {
            m_FetchButtonPressed += action;
        }

        public void SetSelectedIndexAction(Action<eFormName> action)
        {
            m_SelectedIndexChanged += action;
        }
    }
} 