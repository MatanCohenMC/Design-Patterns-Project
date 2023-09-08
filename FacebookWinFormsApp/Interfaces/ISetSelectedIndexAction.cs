using FacebookApp.Models;
using System;

namespace FacebookApp.Interfaces
{
    public interface ISetSelectedIndexAction
    {
        void SetSelectedIndexAction(Action<eFormName> i_Action);
    }
}