using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacebookApp.Models
{
    public static class FormUtility
    {
        public static void SetLocation(ListBox listBox, TextBox textBox, Func<int, string> getLocation)
        {
            string location = getLocation(listBox.SelectedIndex);
            textBox.Text = location ?? "No Location mentioned.";
        }

        public static void SetPicture(ListBox listBox, PictureBox pictureBox, Func<int, string> getPictureUrl)
        {
            string pictureUrl = getPictureUrl(listBox.SelectedIndex);

            if (pictureUrl != null)
            {
                pictureBox.LoadAsync(pictureUrl);
            }
            else
            {
                pictureBox.Image = pictureBox.ErrorImage;
            }
        }
    }
}
