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
    public partial class EventsForm : Form, IComponentHandler, IDataHandler, IListBoxHandler
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

        private void buttonFetchEvents_Click(object sender, EventArgs e)
        {
            m_FetchButtonPressed?.Invoke("EventsForm");
        }


        public void FetchListBoxData(out List<Dictionary<string, string>> DataList)
        {
            DataList = m_Events.FetchUserEvents();

            //listOfFormProperties = (List<string>)DataDtos
            //    .SelectMany(dto => dto.Data.Keys)
            //    .Distinct();

        }

        public ListBox GetListBox()
        {
            return this.listBoxEvents;
        }
    }
}