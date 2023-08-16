using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookApp.Models;

namespace FacebookApp.Interfaces
{
    public interface ISetFetchAction
    {
        void SetFetchAction(Action<eFormName> action);
    }
}
