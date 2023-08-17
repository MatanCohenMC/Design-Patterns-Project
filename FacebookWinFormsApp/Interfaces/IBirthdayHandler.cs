using System.Windows.Forms;

namespace FacebookApp.Interfaces
{
    public interface IBirthdayHandler
    {
        TextBox GetBirthdayTextBox();

        string GetBirthdayByIndex(int i_Index);
    }
}