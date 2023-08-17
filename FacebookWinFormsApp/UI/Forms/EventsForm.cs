using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FacebookApp.Interfaces;
using FacebookApp.Models;

namespace FacebookApp.UI.Forms
{
    public partial class EventsForm : Form,
                                      IComponentHandler,
                                      IDataHandler,
                                      ILocationHandler,
                                      IDescriptionHandler,
                                      IDateHandler,
                                      IPictureHandler,
                                      ISetFetchAction,
                                      ISetSelectedIndexAction,
                                      IPictureByIndexHandler
    {
        private readonly Events r_Events = new Events();
        private readonly eFormName r_FormName = eFormName.EventsForm;
        public Action<eFormName> m_FetchButtonPressed;
        public Action<eFormName> m_SelectedIndexChanged;

        public EventsForm()
        {
            InitializeComponent();
        }

        public ListBox GetListBox()
        {
            return listBoxEvents;
        }

        public void FetchListBoxData(out List<Dictionary<string, string>> i_DataList)
        {
            i_DataList = r_Events.FetchUserEvents();
        }

        public TextBox GetDateTextBox()
        {
            return textBoxDate;
        }

        public string GetDateByIndex(int i_Index)
        {
            return r_Events.GetDate(i_Index);
        }

        public TextBox GetDescriptionTextBox()
        {
            return textBoxDescription;
        }

        public string GetDescriptionByIndex(int i_Index)
        {
            return r_Events.GetDescription(i_Index);
        }

        public TextBox GetLocationTextBox()
        {
            return textBoxLocation;
        }

        public string GetLocationByIndex(int i_Index)
        {
            return r_Events.GetLocation(i_Index);
        }

        public string GetPictureUrlByIndex(int i_Index)
        {
            return r_Events.GetPictureUrl(i_Index);
        }

        public PictureBox GetPictureBox()
        {
            return pictureBoxEvent;
        }

        public void SetFetchAction(Action<eFormName> i_Action)
        {
            m_FetchButtonPressed += i_Action;
        }

        public void SetSelectedIndexAction(Action<eFormName> i_Action)
        {
            m_SelectedIndexChanged += i_Action;
        }

        private void listBoxPages_SelectedIndexChanged(object i_Sender, EventArgs i_EventArgs)
        {
            m_SelectedIndexChanged?.Invoke(r_FormName);
        }

        private void buttonFetchEvents_Click(object i_Sender, EventArgs i_EventArgs)
        {
            m_FetchButtonPressed?.Invoke(r_FormName);
        }
    }
}