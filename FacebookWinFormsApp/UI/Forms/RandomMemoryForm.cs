using FacebookApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookApp.Interfaces;

namespace FacebookApp.UI.Forms
{
    public partial class RandomMemoryForm : Form, IPictureHandler, IRandomPictureHandler, ISetFetchAction, ISetTextBoxHandler
    {
        private readonly Albums r_Albums = new Albums();
        //private readonly string r_FormName = "PostsByDateRangeForm";
        private readonly eFormName r_FormName = eFormName.RandomMemoryForm;
        public Action<eFormName> m_FetchButtonPressed;

        public RandomMemoryForm()
        {
            InitializeComponent();
        }

        private void buttonFetchMemory_Click(object sender, EventArgs e)
        {
            m_FetchButtonPressed?.Invoke(r_FormName);
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public PictureBox GetPictureBox()
        {
            return pictureBoxMemory;
        }

        public void GetRandomPictureUrl(out string o_pictureUrl, out string o_pictureUpdatedTime)
        {
            r_Albums.GetRandomPictureUrl(out o_pictureUrl,out  o_pictureUpdatedTime);
        }

        public void SetFetchAction(Action<eFormName> action)
        {
            m_FetchButtonPressed += action;
        }

        public void SetTextBox(string i_StringToSet)
        {
            this.textBoxDateCreated.Text = i_StringToSet;
        }
    }
}
