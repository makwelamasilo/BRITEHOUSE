using BRITEHOUSE.Data;
using BRITEHOUSE.Models;
using MongoDB.Bson;
using MongoDB.Driver;
using PagedList.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BRITEHOUSE.Repository
{
    public class OrdersRepository
    {
        private britehouseDBContext dbContext;
        private IMongoCollection<Orders> ordersCollection;

        public OrdersRepository()
        {
            dbContext = new britehouseDBContext();
            ordersCollection = dbContext.database.GetCollection<Orders>("orders");
        }

        public void CreateOrder(Orders order)
        {
            ordersCollection.InsertOne(order);
        }

        public void DeleteOrder(string id)
        {
            ordersCollection.DeleteOne(Builders<Orders>.Filter.Eq("_id", ObjectId.Parse(id)));
        }

        public void UpdateOrder(Orders order)
        {
            ordersCollection.UpdateOne(Builders<Orders>.Filter
                .Eq("_id", order.Id), Builders<Orders>
                .Update
                .Set("Row ID", order.Row_ID)
                .Set("Order ID", order.Order_ID)
                .Set("Order Date", order.Order_date)
                .Set("Ship Date", order.Ship_date));
        }

        public Orders GetOrders(string id)
        {
            var order_ID = new ObjectId(id);
            return ordersCollection.AsQueryable<Orders>().SingleOrDefault(x => x.Id == order_ID);
        }

        public IPagedList<Orders> GetOrdersList(int? page_Num)
        {
            return ordersCollection.AsQueryable<Orders>().ToPagedList(page_Num ?? 1, 10);
        }

        public IEnumerable<Orders> GetAllOders()
        {
            return ordersCollection.AsQueryable<Orders>().ToList();
        }
    }
}
