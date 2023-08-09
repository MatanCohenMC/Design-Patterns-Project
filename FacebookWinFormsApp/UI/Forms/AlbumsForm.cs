﻿using System;
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


namespace FacebookApp.UI.Forms
{
    public partial class AlbumsForm : Form, IComponentHandler, IDataHandler
    {
        private readonly Albums r_Albums = new Albums();
        public Action<string> m_FetchButtonPressed;

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

        public void FetchListBoxData(out List<string> listOfFormProperties, out List<DataDto> DataDtos)
        {
            DataDtos = r_Albums.FetchUserAlbums();

            listOfFormProperties = (List<string>)DataDtos.SelectMany(dto => dto.Data.Keys).Distinct().ToList();

        }
    }
}