using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FacebookApp.Interfaces;
using FacebookApp.Models;

namespace FacebookApp.UI.Forms
{
    public partial class EventsForm : Form
    {
        private readonly Events r_Events = new Events();

        public EventsForm()
        {
            InitializeComponent();
        }

        private void buttonFetchEvents_Click(object i_Sender, EventArgs i_EventArgs)
        {
            fetchEvents();
        }

        private void fetchEvents()
        {
            eventBindingSource.DataSource = r_Events.GetEvents();
        }
    }
}