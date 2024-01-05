using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Xml.Linq;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using MongoDB.Bson;

namespace Food_Order_App.UI
{
     class user
    {
        [BsonId]
        public ObjectId Id { get; set; }    
        

        [BsonElement("name")]
        public string Name { get; set; }

        [BsonElement("password")]
        public string Password { get; set; }

        [BsonElement("blance")] 
        public Double Blance { get; set; }

        [BsonElement ("phone")]
        public string Phone{ get; set;}

        [BsonElement("email")]
        public string Email { get; set; }



        public user( String name, String password, Double blance, String phone, string email)
        {
            
            Name = name;
            Password = password;
            Blance = blance;
            Phone = phone;
            Email = email;




        }

    }


   
}
