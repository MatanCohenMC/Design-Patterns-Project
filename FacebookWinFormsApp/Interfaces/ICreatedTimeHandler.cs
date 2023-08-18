using System.Windows.Forms;

namespace FacebookApp.Interfaces
{
    public interface ICreatedTimeHandler
    {
        TextBox GetCreatedTimeTextBox();

        string GetCreatedTimeByIndex(int i_Index);
    }
}