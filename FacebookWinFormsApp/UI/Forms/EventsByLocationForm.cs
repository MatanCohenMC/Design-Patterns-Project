using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FacebookApp.Interfaces;
using FacebookApp.Models;

namespace FacebookApp.UI.Forms
{
    public partial class EventsByLocationForm : Form
    {
        private readonly Events r_Events = new Events();

        public EventsByLocationForm()
        {
            InitializeComponent();
        }

        private void buttonFetchEvents_Click(object i_Sender, EventArgs i_EventArgs)
        {
            fetchEventsByLocation();
        }

        private void fetchEventsByLocation()
        {
            string location = textBoxLocation.Text;

            if(location != string.Empty)
            {
                eventBindingSource.DataSource = r_Events.GetEventsByLocation(location);
            }
        }
    }
}