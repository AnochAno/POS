using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace System
{
    internal class Product
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("name")]
        public string Name { get; set; }

        [BsonElement("price")]
        public double Price { get; set; }

        [BsonElement("discount")]
        public double Discount { get; set;}

        [BsonElement("stock")]
        public double Stock { get; set;}

        public Product(string name, double price, double discount, double stock)
        {
            Name = name;
            Price = price;
            Discount = discount;
            Stock = stock; 
        }

    }
}
