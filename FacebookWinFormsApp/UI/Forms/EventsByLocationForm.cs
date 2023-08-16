using FacebookApp.Interfaces;
using FacebookApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacebookApp.UI.Forms
{
    public partial class EventsByLocationForm : Form, IComponentHandler, IDataHandler, IDescriptionHandler, IPictureHandler, IDateHandler
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

        private void labelEnterLocation_Click(object sender, EventArgs e)
        {

        }

        private void buttonFetchEvents_Click(object sender, EventArgs e)
        {
            m_FetchButtonPressed?.Invoke(r_FormName);
        }

        public ListBox GetListBox()
        {
            return listBoxEventsByLocation;
        }

        public void FetchListBoxData(out List<Dictionary<string, string>> DataList)
        {
            string location = getEventLocation();
            DataList = r_Events.FetchUserEventsByLocation(location);
        }

        private string getEventLocation()
        {
            string location = textBoxLocation.Text;
            return location;
        }

        public TextBox GetDescriptionTextBox()
        {
            return textBoxDescription;
        }

        public string GetDescriptionByIndex(int i_Index)
        {
            return r_Events.GetDescription(i_Index);
        }

        public PictureBox GetPictureBox()
        {
            return pictureBoxEvent;
        }

        public string GetPictureUrlByIndex(int i_Index)
        {
            return r_Events.GetPictureUrl(i_Index);
        }

        public TextBox GetDateTextBox()
        {
            return textBoxDate;
        }

        public string GetDateByIndex(int i_Index)
        {
            return r_Events.GetDate(i_Index);
        }
    }
}
