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
        private readonly string r_FormName = "GroupsForm";
        public Action<string> m_FetchButtonPressed;
        public Action<string> m_SelectedIndexChanged;

        public GroupsForm()
        {
            InitializeComponent();
        }

        private void fetch_groups_button_Click(object sender, EventArgs e)
        {
            m_FetchButtonPressed?.Invoke("GroupsForm");
        }
        private void listBoxGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            m_SelectedIndexChanged?.Invoke(r_FormName);
        }

        public ListBox GetListBox()
        {
            return listBoxGroup;
        }

        public void FetchListBoxData(out List<Dictionary<string, string>> DataList)
        {
            DataList = new List<Dictionary<string, string>>();
        }
    }
}