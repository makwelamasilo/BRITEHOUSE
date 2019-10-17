using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BRITEHOUSE.Data
{
    public class britehouseDBContext
    {
        public IMongoDatabase database;

        public britehouseDBContext()
        {
            var mongo = new MongoClient("mongodb://Makwela:britehousePass@localhost:27017/britehouseDB");
            database = mongo.GetDatabase("britehouseDB");
        }
    }
}
