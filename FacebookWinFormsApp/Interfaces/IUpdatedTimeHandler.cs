using System.Windows.Forms;

namespace FacebookApp.Interfaces
{
    public interface IUpdatedTimeHandler
    {
        TextBox GetUpdatedTimeTextBox();

        string GetUpdatedTimeByIndex(int i_Index);
    }
}