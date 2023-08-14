using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacebookApp.Interfaces
{
    public interface IPictureCountHandler
    {
        TextBox GetPictureCountTextBox();
        string GetPictureCountByIndex(int i_Index); 
    }
}
