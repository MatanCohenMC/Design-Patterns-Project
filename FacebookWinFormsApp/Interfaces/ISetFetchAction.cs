using System;
using FacebookApp.Models;

namespace FacebookApp.Interfaces
{
    public interface ISetFetchAction
    {
        void SetFetchAction(Action<eFormName> i_Action);
    }
}