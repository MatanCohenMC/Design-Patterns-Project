using FacebookApp.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookApp.Models;
using FacebookApp.Dtos;
using FacebookWrapper.ObjectModel;

namespace FacebookApp.UI.Forms
{
    public partial class LikedPagesForm : Form, IComponentHandler, IDataHandler, IPictureHandler, IDescriptionHandler
    {
        private readonly LikedPages r_LikedPages = new LikedPages();
        public Action<string> m_FetchButtonPressed;
        public Action<string> m_SelectedIndexChanged;
        private readonly string r_FormName = "LikedPagesForm";

        public LikedPagesForm()
        {
            InitializeComponent();
        }

        private void buttonFetchPages_Click(object sender, EventArgs e)
        {
            m_FetchButtonPressed?.Invoke(r_FormName);
        }

        private void listBoxLikedPages_SelectedIndexChanged(object sender, EventArgs e)
        {
            m_SelectedIndexChanged?.Invoke(r_FormName);
        }

        public void FetchListBoxData(out List<Dictionary<string, string>> DataList)
        {
            DataList = r_LikedPages.FetchUserLikedPages();
        }
        public ListBox GetListBox()
        {
            return this.listBoxLikedPages;
        }

        public PictureBox GetPictureBox()
        {
            return pictureBoxLikedPage;
        }

        public string GetPictureUrlByIndex(int i_Index)
        {
            return r_LikedPages.GetPictureUrl(i_Index);
        }

        public TextBox GetDescriptionTextBox()
        {
            return textBoxDescription;
        }

        public string GetDescriptionByIndex(int i_Index)
        {
            return r_LikedPages.GetDescription(i_Index);
        }

    }
}