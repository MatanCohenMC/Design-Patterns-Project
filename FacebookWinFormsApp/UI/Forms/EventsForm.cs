using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookApp.Models;
using FacebookApp.Interfaces;


namespace FacebookApp.UI.Forms
{
    public partial class EventsForm : Form, IComponentHandler, IDataHandler
    {
        private readonly Events m_Events = new Events();
        public Action<string> m_FetchButtonPressed;
        public EventsForm()
        {
            InitializeComponent();
        }

        private void listBoxPages_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Pagelabel_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxPage_Click(object sender, EventArgs e)
        {
            m_FetchButtonPressed?.Invoke("EventsForm");
        }

        private void buttonFetchEvents_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        public ListBox GetListBox()
        {
            return this.listBoxEvents;
        }

        public IEnumerable<string> FetchListBoxData()
        {
            return m_Events.FetchUserEvents();
        }
    }
}