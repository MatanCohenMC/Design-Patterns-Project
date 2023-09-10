using System;
using System.Windows.Forms;
using FacebookApp.Facades;

namespace FacebookApp.UI.Forms
{
    public partial class EventsByLocationForm : Form
    {
        private readonly EventsByLocationFacade r_EventsByLocationFacade;

        public EventsByLocationForm()
        {
            InitializeComponent();
            r_EventsByLocationFacade = new EventsByLocationFacade();
            r_EventsByLocationFacade.EventsByLocationUpdated += setEventsByLocationFacade;
        }

        private void buttonFetchEvents_Click(object i_Sender, EventArgs i_EventArgs)
        {
            labelLoading.Visible = true;
            r_EventsByLocationFacade.UpdateEventsByLocation(textBoxLocation.Text);
        }

        private void setEventsByLocationFacade()
        {
            if (InvokeRequired)
            {
                Invoke((Action)setEventsByLocationFacade);
                return;
            }

            eventBindingSource.DataSource = r_EventsByLocationFacade.EventsByLocation;
            labelLoading.Visible = false;
        }
    }
}