using System.Windows.Forms;

namespace FacebookApp.Interfaces
{
    internal interface ICaptionHandler
    {
        TextBox GetCaptionTextBox();

        string GetCaptionByIndex(int i_Index);
    }
}