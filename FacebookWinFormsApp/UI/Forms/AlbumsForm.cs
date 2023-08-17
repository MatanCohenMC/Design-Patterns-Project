using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FacebookApp.Interfaces;
using FacebookApp.Models;

namespace FacebookApp.UI.Forms
{
    public partial class AlbumsForm : Form,
                                      IComponentHandler,
                                      IDataHandler,
                                      IPictureHandler,
                                      ILocationHandler,
                                      IPictureCountHandler,
                                      IUpdatedTimeHandler,
                                      ISetFetchAction,
                                      ISetSelectedIndexAction,
                                      IPictureByIndexHandler
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

        public ListBox GetListBox()
        {
            return listBoxAlbums;
        }

        public void FetchListBoxData(out List<Dictionary<string, string>> i_DataList)
        {
            i_DataList = r_Albums.FetchUserAlbums();
        }

        public TextBox GetLocationTextBox()
        {
            return textBoxLocation;
        }

        public string GetLocationByIndex(int i_Index)
        {
            return r_Albums.GetLocation(i_Index);
        }

        public string GetPictureUrlByIndex(int i_Index)
        {
            return r_Albums.GetPictureUrl(i_Index);
        }

        public TextBox GetPictureCountTextBox()
        {
            return textBoxPictureCount;
        }

        public string GetPictureCountByIndex(int i_Index)
        {
            return r_Albums.GetPictureCount(i_Index);
        }

        public PictureBox GetPictureBox()
        {
            return pictureBoxAlbum;
        }

        public void SetFetchAction(Action<eFormName> i_Action)
        {
            m_FetchButtonPressed += i_Action;
        }

        public void SetSelectedIndexAction(Action<eFormName> i_Action)
        {
            m_SelectedIndexChanged += i_Action;
        }

        public TextBox GetUpdatedTimeTextBox()
        {
            return textBoxUpdatedTime;
        }

        public string GetUpdatedTimeByIndex(int i_Index)
        {
            return r_Albums.GetUpdatedTime(i_Index);
        }

        private void fetch_albums_button_Click(object i_Sender, EventArgs i_EventArgs)
        {
            m_FetchButtonPressed?.Invoke(r_FormName);
        }

        private void listBoxAlbums_SelectedIndexChanged(object i_Sender, EventArgs i_EventArgs)
        {
            m_SelectedIndexChanged?.Invoke(r_FormName);
        }
    }
}