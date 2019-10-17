using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BRITEHOUSE.Models
{
    public class Returns
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public ObjectId _id { get; set; }
        [BsonElement("Returned")]
        public string Returned { get; set; }
        [BsonElement("Order ID")]
        public string Order_ID { get; set; }
        [BsonElement("Region")]
        public string Region { get; set; }
    }
}
