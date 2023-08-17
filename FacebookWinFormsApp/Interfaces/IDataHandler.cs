using System.Collections.Generic;

namespace FacebookApp.Interfaces
{
    public interface IDataHandler
    {
        void FetchListBoxData(out List<Dictionary<string, string>> i_DataList);
    }
}