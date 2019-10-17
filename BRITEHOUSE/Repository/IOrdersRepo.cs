using BRITEHOUSE.Models;
using PagedList.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BRITEHOUSE.Repository
{
    interface IOrdersRepo
    {
        void CreateOrder(Orders order);
        void DeleteOrder(string id);
        void UpdateOrder(Orders order);
        Orders GetOrders(string id);
        IPagedList<Orders> GetOrdersList(int? page_Num);
        IEnumerable<Orders> GetAllOders();
    }
}
