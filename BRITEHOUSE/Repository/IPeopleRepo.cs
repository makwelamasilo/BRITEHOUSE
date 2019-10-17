using BRITEHOUSE.Models;
using PagedList.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BRITEHOUSE.Repository
{
    interface IPeopleRepo
    {
        void CreatePeople(People people);
        void DeletePeople(string id);
        void UpdatePeople(People people);
        People GetPeople(string id);
        IPagedList<People> GetPeopleList(int? page_Num);
        IEnumerable<People> GetAllPeople();
    }
}
