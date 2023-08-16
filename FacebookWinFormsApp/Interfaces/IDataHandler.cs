using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookApp.Interfaces
{
    public interface IDataHandler
    {
        void FetchListBoxData(out List<Dictionary<string, string>> DataList);
    }
}