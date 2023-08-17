using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FacebookApp.Interfaces;
using FacebookApp.Models;

namespace FacebookApp.UI.Forms
{
    public partial class LikedPagesForm : Form,
                                          IComponentHandler,
                                          IDataHandler,
                                          IPictureHandler,
                                          IDescriptionHandler,
                                          ISetFetchAction,
                                          ISetSelectedIndexAction,
                                          IPictureByIndexHandler
    {
        //private readonly string r_FormName = "LikedPagesForm";
        private readonly eFormName r_FormName = eFormName.LikedPagesForm;
        private readonly LikedPages r_LikedPages = new LikedPages();
        public Action<eFormName> m_FetchButtonPressed;
        public Action<eFormName> m_SelectedIndexChanged;

        public LikedPagesForm()
        {
            InitializeComponent();
        }

        public ListBox GetListBox()
        {
            return this.listBoxLikedPages;
        }

        public void FetchListBoxData(out List<Dictionary<string, string>> i_DataList)
        {
            i_DataList = r_LikedPages.FetchUserLikedPages();
        }

        public TextBox GetDescriptionTextBox()
        {
            return textBoxDescription;
        }

        public string GetDescriptionByIndex(int i_Index)
        {
            return r_LikedPages.GetDescription(i_Index);
        }

        public string GetPictureUrlByIndex(int i_Index)
        {
            return r_LikedPages.GetPictureUrl(i_Index);
        }

        public PictureBox GetPictureBox()
        {
            return pictureBoxLikedPage;
        }

        public void SetFetchAction(Action<eFormName> i_Action)
        {
            m_FetchButtonPressed += i_Action;
        }

        public void SetSelectedIndexAction(Action<eFormName> i_Action)
        {
            m_SelectedIndexChanged += i_Action;
        }

        private void buttonFetchPages_Click(object i_Sender, EventArgs i_EventArgs)
        {
            m_FetchButtonPressed?.Invoke(r_FormName);
        }

        private void listBoxLikedPages_SelectedIndexChanged(object i_Sender, EventArgs i_EventArgs)
        {
            m_SelectedIndexChanged?.Invoke(r_FormName);
        }
    }
}