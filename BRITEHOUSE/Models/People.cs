using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BRITEHOUSE.Models
{
    public class People
    {
        [BsonId]
        public ObjectId Id { get; set; }
        [BsonElement("Person")]
        public string Person { get; set; }
        [BsonElement("Region")]
        public string Region { get; set; }
    }
}
