using System.Windows.Forms;

namespace FacebookApp.Interfaces
{
    public interface IDescriptionHandler
    {
        TextBox GetDescriptionTextBox();

        string GetDescriptionByIndex(int i_Index);
    }
}