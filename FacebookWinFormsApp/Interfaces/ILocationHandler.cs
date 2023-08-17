using System.Windows.Forms;

namespace FacebookApp.Interfaces
{
    public interface ILocationHandler
    {
        TextBox GetLocationTextBox();

        string GetLocationByIndex(int i_Index);
    }
}