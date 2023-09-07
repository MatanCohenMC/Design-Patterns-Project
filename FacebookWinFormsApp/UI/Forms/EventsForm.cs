using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FacebookApp.Facades;
using FacebookApp.Interfaces;
using FacebookApp.Models;

namespace FacebookApp.UI.Forms
{
    public partial class EventsForm : Form
    {
        private readonly EventsFacade r_Events;

        public EventsForm()
        {
            InitializeComponent();
            r_Events = new EventsFacade();
            r_Events.EventsUpdated += setEvents;
        }

        private void buttonFetchEvents_Click(object i_Sender, EventArgs i_EventArgs)
        {
            labelLoading.Visible = true;
            r_Events.UpdateEvents();
        }

        private void setEvents()
        {
            if(InvokeRequired)
            {
                Invoke((Action)setEvents);
                return;
            }

            eventBindingSource.DataSource = r_Events.Events;
            labelLoading.Visible = false;
        }

        private void locationLabel_Click(object sender, EventArgs e)
        {

        }
    }
}