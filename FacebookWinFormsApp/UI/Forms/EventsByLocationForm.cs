using FacebookApp.Facades;
using System;
using System.Windows.Forms;

namespace FacebookApp.UI.Forms
{
    public partial class EventsByLocationForm : Form
    {
        private readonly EventsByLocationFacade r_EventsByLocation;

        public EventsByLocationForm()
        {
            InitializeComponent();
            r_EventsByLocation = new EventsByLocationFacade();
            r_EventsByLocation.EventsByLocationUpdated += setEventsByLocation;
        }

        private void buttonFetchEvents_Click(object i_Sender, EventArgs i_EventArgs)
        {
            labelLoading.Visible = true;
            r_EventsByLocation.UpdateEventsByLocation(textBoxLocation.Text);
        }

        private void setEventsByLocation()
        {
            if (InvokeRequired)
            {
                Invoke((Action)setEventsByLocation);
                return;
            }

            eventBindingSource.DataSource = r_EventsByLocation.EventsByLocation;
            labelLoading.Visible = false;
        }
    }
}