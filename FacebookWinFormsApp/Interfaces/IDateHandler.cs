using System.Windows.Forms;

namespace FacebookApp.Interfaces
{
    public interface IDateHandler
    {
        TextBox GetDateTextBox();

        string GetDateByIndex(int i_Index);
    }
}