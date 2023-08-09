﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookApp.Dtos;
using FacebookApp.Interfaces;
using FacebookApp.Models;

namespace FacebookApp.UI.Forms
{
    public partial class PostsForm : Form, IComponentHandler, IDataHandler
    {
        private readonly Posts m_Posts = new Posts();

        public Action<string> m_FetchButtonPressed;
        public PostsForm()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object i_Sender, EventArgs e)
        {

        }

        private void fetch_posts_button_Click(object i_Sender, EventArgs e)
        {
            m_FetchButtonPressed?.Invoke("PostsForm");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void PostsForm_Load(object sender, EventArgs e)
        {

        }

        public void FetchListBoxData(out List<string> listOfFormProperties, out List<DataDto> DataDtos)
        {
            DataDtos = m_Posts.FetchUserPosts();

            listOfFormProperties = (List<string>)DataDtos
                .SelectMany(dto => dto.Data.Keys)
                .Distinct();

        }

        public ListBox GetListBox()
        {
            return this.listBox1;
        }
    }
}