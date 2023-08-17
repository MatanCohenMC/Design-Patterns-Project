using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacebookApp.Interfaces
{
    public interface IBirthdayHandler
    {
        TextBox GetBirthdayTextBox();
        string GetBirthdayByIndex(int i_Index);
    }
}
