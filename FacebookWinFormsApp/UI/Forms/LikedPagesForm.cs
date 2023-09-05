using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FacebookApp.Interfaces;
using FacebookApp.Models;

namespace FacebookApp.UI.Forms
{
    public partial class LikedPagesForm : Form
    {
        private readonly LikedPages r_LikedPages = new LikedPages();

        public LikedPagesForm()
        {
            InitializeComponent();
        }

        private void buttonFetchPages_Click(object i_Sender, EventArgs i_EventArgs)
        {
            fetchLikedPages();
        }

        private void fetchLikedPages()
        {
            pageBindingSource.DataSource = r_LikedPages.GetLikedPages();
        }
    }
}