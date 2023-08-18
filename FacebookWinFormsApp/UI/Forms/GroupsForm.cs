using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FacebookApp.Interfaces;
using FacebookApp.Models;

namespace FacebookApp.UI.Forms
{
    public partial class GroupsForm : Form,
                                      IComponentHandler,
                                      IDataHandler,
                                      IDescriptionHandler,
                                      IPictureHandler,
                                      ISetFetchAction,
                                      ISetSelectedIndexAction,
                                      IPictureByIndexHandler
    {
        private readonly eFormName r_FormName = eFormName.GroupsForm;
        private readonly Groups r_Groups = new Groups();
        public Action<eFormName> m_FetchButtonPressed;
        public Action<eFormName> m_SelectedIndexChanged;

        public GroupsForm()
        {
            InitializeComponent();
        }

        public ListBox GetListBox()
        {
            return listBoxGroups;
        }

        public void FetchListBoxData(out List<Dictionary<string, string>> i_DataList)
        {
            i_DataList = r_Groups.FetchUserEvents();
        }

        public TextBox GetDescriptionTextBox()
        {
            return textBoxDescription;
        }

        public string GetDescriptionByIndex(int i_Index)
        {
            return r_Groups.GetDescription(i_Index);
        }

        public string GetPictureUrlByIndex(int i_Index)
        {
            return r_Groups.GetPictureUrl(i_Index);
        }

        public PictureBox GetPictureBox()
        {
            return pictureBoxGroup;
        }

        public void SetFetchAction(Action<eFormName> i_Action)
        {
            m_FetchButtonPressed += i_Action;
        }

        public void SetSelectedIndexAction(Action<eFormName> i_Action)
        {
            m_SelectedIndexChanged += i_Action;
        }

        private void fetch_groups_button_Click(object i_Sender, EventArgs i_EventArgs)
        {
            m_FetchButtonPressed?.Invoke(r_FormName);
        }

        private void listBoxGroups_SelectedIndexChanged(object i_Sender, EventArgs i_EventArgs)
        {
            m_SelectedIndexChanged?.Invoke(r_FormName);
        }
    }
}