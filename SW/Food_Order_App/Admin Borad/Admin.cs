using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Food_Order_App.Admin_Borad
{
    internal class Admin
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("name")]
        public string Name { get; set; }

        [BsonElement("address")]
        public string Address { get; set; }

        [BsonElement("email")]
        public string Email { get; set; }

        [BsonElement("contact")]
        public string Contact { get; set; }

        [BsonElement("username")]
        public string Username { get; set; }

        [BsonElement("passsword")]
        public string Password { get; set; }

       

        public Admin(string name, string address, string email, string contact, string username, string password)
        {
            Name = name;
            Address = address;
            Email = email;
            Contact = contact;
            Username = username;
            Password = password;
            
        }
    }
}
