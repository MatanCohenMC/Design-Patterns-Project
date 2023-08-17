using System.Windows.Forms;

namespace FacebookApp.Interfaces
{
    public interface IPictureCountHandler
    {
        TextBox GetPictureCountTextBox();

        string GetPictureCountByIndex(int i_Index);
    }
}