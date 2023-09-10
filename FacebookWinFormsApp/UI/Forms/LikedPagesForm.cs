using System;
using System.Windows.Forms;
using FacebookApp.Facades;

namespace FacebookApp.UI.Forms
{
    public partial class LikedPagesForm : Form
    {
        private readonly LikedPagesFacade r_LikedPagesFacade;

        public LikedPagesForm()
        {
            InitializeComponent();
            r_LikedPagesFacade = new LikedPagesFacade();
            r_LikedPagesFacade.LikedPagesUpdated += setLikedPagesFacade;
        }

        private void buttonFetchPages_Click(object i_Sender, EventArgs i_EventArgs)
        {
            labelLoading.Visible = true;
            r_LikedPagesFacade.UpdateLikedPages();
        }

        private void setLikedPagesFacade()
        {
            if (InvokeRequired)
            {
                Invoke((Action)setLikedPagesFacade);
                return;
            }

            pageBindingSource.DataSource = r_LikedPagesFacade.LikedPages;
            labelLoading.Visible = false;
        }

        private void descriptionTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}