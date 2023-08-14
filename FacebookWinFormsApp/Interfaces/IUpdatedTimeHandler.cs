using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacebookApp.Interfaces
{
    public interface IUpdatedTimeHandler
    {
        TextBox GetUpdatedTimeTextBox();
        string GetUpdatedTimeByIndex(int i_Index);
    }
}
