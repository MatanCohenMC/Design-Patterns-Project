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
using FacebookApp.Dtos;

namespace FacebookApp.UI.Forms
{
    public partial class GroupsForm : Form, IComponentHandler, IDataHandler
    {
        private Groups m_Groups = new Groups();
        public Action<string> m_FetchButtonPressed;

        public GroupsForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void fetch_groups_button_Click(object sender, EventArgs e)
        {
            m_FetchButtonPressed?.Invoke("GroupsForm");
        }


        public ListBox GetListBox()
        {
            return this.listBoxGroup;
        }

        public void FetchListBoxData(out List<Dictionary<string, string>> DataList)
        {
            /*DataDtos = m_Groups.FetchUserGroups();
            listOfFormProperties = DataDtos                .SelectMany(dto => dto.Data.Keys)
                .Distinct()
                .ToList();*/

            DataList = new List<Dictionary<string, string>>();
        }
    }
}