using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FacebookApp.Interfaces;
using FacebookApp.Models;

namespace FacebookApp.UI.Forms
{
    public partial class EventsByLocationForm : Form,
                                                IComponentHandler,
                                                IDataHandler,
                                                IDescriptionHandler,
                                                IPictureHandler,
                                                IDateHandler,
                                                ISetFetchAction,
                                                ISetSelectedIndexAction,
                                                IPictureByIndexHandler
    {
        private readonly Events r_Events = new Events();
        //private readonly string r_FormName = "EventsForm";
        private readonly eFormName r_FormName = eFormName.EventsByLocationForm;
        public Action<eFormName> m_FetchButtonPressed;
        public Action<eFormName> m_SelectedIndexChanged;


        public EventsByLocationForm()
        {
            InitializeComponent();
        }

        public ListBox GetListBox()
        {
            return listBoxEventsByLocation;
        }

        public void FetchListBoxData(out List<Dictionary<string, string>> i_DataList)
        {
            string location = getEventLocation();
            i_DataList = r_Events.FetchUserEventsByLocation(location);
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

        private void labelEnterLocation_Click(object i_Sender, EventArgs i_EventArgs)
        {
        }

        private void buttonFetchEvents_Click(object i_Sender, EventArgs i_EventArgs)
        {
            m_FetchButtonPressed?.Invoke(r_FormName);
        }

        private string getEventLocation()
        {
            return textBoxLocation?.Text;
        }
    }
}