using System;
using System.Windows.Forms;
using FacebookApp.Facades;

namespace FacebookApp.UI.Forms
{
    public partial class EventsForm : Form
    {
        private readonly EventsFacade r_EventsFacade;

        public EventsForm()
        {
            InitializeComponent();
            r_EventsFacade = new EventsFacade();
            r_EventsFacade.EventsUpdated += setEventsFacade;
        }

        private void buttonFetchEvents_Click(object i_Sender, EventArgs i_EventArgs)
        {
            labelLoading.Visible = true;
            r_EventsFacade.UpdateEvents();
        }

        private void setEventsFacade()
        {
            if (InvokeRequired)
            {
                Invoke((Action)setEventsFacade);
                return;
            }

            eventBindingSource.DataSource = r_EventsFacade.Events;
            labelLoading.Visible = false;
        }

        private void locationLabel_Click(object sender, EventArgs e)
        {

        }
    }
}