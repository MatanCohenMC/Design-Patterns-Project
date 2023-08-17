using System.Windows.Forms;

namespace FacebookApp.Interfaces
{
    public interface IFullNameHandler
    {
        TextBox GetFullNameTextBox();

        string GetFullNameByIndex(int i_Index);
    }
}