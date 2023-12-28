using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace System
{
    internal class Admin
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("name")]
        public string Name { get; set; }

        [BsonElement("email")]
        public string Email { get; set; }

        [BsonElement("phoneNo")]
        public string PhoneNo { get; set; }

        [BsonElement("passsword")]
        public string Password { get; set; }

        [BsonElement("balance")]
        public double Balance { get; set; }

        public Admin (string name, string email, string phoneNo, string password, double balance) 
        {
            Name = name;
            Email = email;
            PhoneNo = phoneNo;
            Password = password;
            Balance = balance;
        }



    }
}
