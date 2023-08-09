using FacebookApp.Interfaces;
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

namespace FacebookApp.UI.Forms
{
    public partial class FormPages : Form, IComponentHandler, IDataHandler
    {
        private readonly LikedPages r_Pages = new LikedPages();
        public Action<string> m_FetchButtonPressed;
        public FormPages()
        {
            InitializeComponent();
        }

        private void buttonFetchPages_Click(object sender, EventArgs e)
        {
            m_FetchButtonPressed?.Invoke("PagesForm");
        }

        public ListBox GetListBox()
        {
            return this.listBoxPages;
        }

        public IEnumerable<string> FetchListBoxData()
        {
            return r_Pages.FetchUserPages();
        }
    }
}