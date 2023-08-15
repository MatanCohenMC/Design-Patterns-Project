using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacebookApp.Interfaces
{
    internal interface ICommentsHandler
    {
        ListBox GetCommentsListBox();
        ICollection<Comment> GetCommentsByIndex(int i_Index);
    }
}
