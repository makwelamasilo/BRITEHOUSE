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
    public class ReturnsRepository
    {
        private britehouseDBContext dbContext;
        private IMongoCollection<Returns> returnsCollection;

        public ReturnsRepository()
        {
            dbContext = new britehouseDBContext();
            returnsCollection = dbContext.database.GetCollection<Returns>("returns");
        }

        public void CreateReturn(Returns returns)
        {
            returnsCollection.InsertOne(returns);
        }

        public void DeleteReturn(string id)
        {
            returnsCollection.DeleteOne(Builders<Returns>.Filter.Eq("_id", ObjectId.Parse(id)));
        }

        public void UpdateReturn(Returns returns)
        {
            returnsCollection.UpdateOne(Builders<Returns>.Filter
                .Eq("_id", returns._id), Builders<Returns>
                .Update
                .Set("Returned", returns.Returned)
                .Set("Order_ID", returns.Order_ID)
                .Set("Region", returns.Region));
        }

        public Returns GetReturns(string id)
        {
            var returns_id = new ObjectId(id);
            return returnsCollection.AsQueryable<Returns>().SingleOrDefault(x => x._id == returns_id);
        }

        public IPagedList<Returns> GetReturnsList(int? page_Num)
        {
            return returnsCollection.AsQueryable<Returns>().ToPagedList(page_Num ?? 1, 10);
        }

        public IEnumerable<Returns> GetAllReturns()
        {
            return returnsCollection.AsQueryable<Returns>().ToList();
        }
    }
}
