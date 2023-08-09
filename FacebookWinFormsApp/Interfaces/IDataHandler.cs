using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookApp.Dtos;

namespace FacebookApp.Interfaces
{
    public interface IDataHandler
    {
        void FetchListBoxData(out List<string> listOfFormProperties, out List<DataDto> DataDtos);
    }
}