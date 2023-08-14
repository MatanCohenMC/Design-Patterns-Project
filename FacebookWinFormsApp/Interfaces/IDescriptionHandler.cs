using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacebookApp.Interfaces
{
    public interface IDescriptionHandler
    {
        TextBox GetDescriptionTextBox();
        string GetDescriptionByIndex(int i_Index);

    }
}
