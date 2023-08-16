using System;
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
    public partial class EventsForm : Form, IComponentHandler, IDataHandler, ILocationHandler, IDescriptionHandler, IDateHandler, IPictureHandler
    {
        private readonly Events r_Events = new Events();
        //private readonly string r_FormName = "EventsForm";
        private readonly eFormName r_FormName = eFormName.EventsForm;
        public Action<eFormName> m_FetchButtonPressed;
        public Action<eFormName> m_SelectedIndexChanged;

        public EventsForm()
        {
            InitializeComponent();
        }

        private void listBoxPages_SelectedIndexChanged(object sender, EventArgs e)
        {
            m_SelectedIndexChanged?.Invoke(r_FormName);
        }

        private void buttonFetchEvents_Click(object sender, EventArgs e)
        {
            m_FetchButtonPressed?.Invoke(r_FormName);
        }

        public void FetchListBoxData(out List<Dictionary<string, string>> DataList)
        {
            DataList = r_Events.FetchUserEvents();
        }

        public ListBox GetListBox()
        {
            return listBoxEvents;
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

        public TextBox GetDateTextBox()
        {
            return textBoxDate;
        }

        public string GetDateByIndex(int i_Index)
        {
            return r_Events.GetDate(i_Index);
        }

        public PictureBox GetPictureBox()
        {
            return pictureBoxEvent;
        }

        public string GetPictureUrlByIndex(int i_Index)
        {
            return r_Events.GetPictureUrl(i_Index);
        }
    }
}