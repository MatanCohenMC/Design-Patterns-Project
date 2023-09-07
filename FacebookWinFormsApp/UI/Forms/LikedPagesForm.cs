using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FacebookApp.Facades;
using FacebookApp.Interfaces;
using FacebookApp.Models;

namespace FacebookApp.UI.Forms
{
    public partial class LikedPagesForm : Form
    {
        private readonly LikedPagesFacade r_LikedPages;


        public LikedPagesForm()
        {
            InitializeComponent();
            r_LikedPages = new LikedPagesFacade();
            r_LikedPages.LikedPagesUpdated += setLikedPages;
        }

        private void buttonFetchPages_Click(object i_Sender, EventArgs i_EventArgs)
        {
            r_LikedPages.UpdateLikedPages();
        }


        private void setLikedPages()
        {
            if(InvokeRequired)
            {
                Invoke((Action)setLikedPages);
                return;
            }

            pageBindingSource.DataSource = r_LikedPages.LikedPages;
        }
    }
}