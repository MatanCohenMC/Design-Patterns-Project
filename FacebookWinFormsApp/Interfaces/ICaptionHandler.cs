using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacebookApp.Interfaces
{
    internal interface ICaptionHandler
    {
        TextBox GetCaptionTextBox();
        string GetCaptionByIndex(int i_Index);
    }
}
