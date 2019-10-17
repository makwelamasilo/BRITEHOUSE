using BRITEHOUSE.Models;
using PagedList.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BRITEHOUSE.Repository
{
    interface IReturnsRepo
    {
        void CreateReturn(Returns returns);
        void DeleteReturn(string id);
        void UpdateReturn(Returns returns);
        Returns GetReturns(string id);
        IPagedList<Returns> GetReturnsList(int? page_Num);
        IEnumerable<Returns> GetAllReturns();
    }
}
