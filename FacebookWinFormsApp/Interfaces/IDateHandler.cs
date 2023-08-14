using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacebookApp.Interfaces
{
    public interface IDateHandler
    {
        TextBox GetDateTextBox();
        string GetDateByIndex(int i_Index);
    }
}
