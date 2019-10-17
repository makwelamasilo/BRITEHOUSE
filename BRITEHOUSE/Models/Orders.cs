using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BRITEHOUSE.Models
{
    public class Orders
    {
        [BsonId]
        //[BsonElement("Id")]
        public ObjectId Id { get; set; }
        [BsonElement("Row ID")]
        public string Row_ID { get; set; }
        [BsonElement("Order ID")]
        public string Order_ID { get; set; }
        [BsonElement("Order Date")]
        public string Order_date { get; set; }
        [BsonElement("Ship Date")]
        public string Ship_date { get; set; }
        [BsonElement("Ship Mode")]
        public string Ship_mode { get; set; }
        [BsonElement("Customer ID")]
        public string Customer_ID { get; set; }
        [BsonElement("Segment")]
        public string Segment { get; set; }
        [BsonElement("Postal Code")]
        public string Postal_code { get; set; }
        [BsonElement("City")]
        public string City { get; set; }
        [BsonElement("State")]
        public string State { get; set; }
        [BsonElement("Country")]
        public string Country { get; set; }
        [BsonElement("Region")]
        public string Region { get; set; }
        [BsonElement("Market")]
        public string Market { get; set; }
        [BsonElement("Product ID")]
        public string Product_ID { get; set; }
        [BsonElement("Category")]
        public string Category { get; set; }
        [BsonElement("Sub-Category")]
        public string Sub_category { get; set; }
        [BsonElement("Product Name")]
        public string Product_name { get; set; }
        [BsonElement("Sales")]
        public string Sales { get; set; }
        [BsonElement("Quantity")]
        public string Quantity { get; set; }
        [BsonElement("Discount")]
        public string Discount { get; set; }
        [BsonElement("Profit")]
        public string Profit { get; set; }
        [BsonElement("Shipping Cost")]
        public string Shipping_cost { get; set; }
        [BsonElement("Order Priority")]
        public string Order_priority { get; set; }
    }
}
