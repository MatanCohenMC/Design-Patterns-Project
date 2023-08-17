using System;
using FacebookApp.Models;

namespace FacebookApp.Interfaces
{
    public interface ISetSelectedIndexAction
    {
        void SetSelectedIndexAction(Action<eFormName> i_Action);
    }
}