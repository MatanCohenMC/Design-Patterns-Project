using System.Collections.Generic;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace FacebookApp.Interfaces
{
    internal interface ICommentsHandler
    {
        ListBox GetCommentsListBox();

        ICollection<Comment> GetCommentsByIndex(int i_Index);
    }
}