using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Food_Order_App.Admin_Borad;
using MongoDB.Driver;

namespace Food_Order_App.UI
{
    public partial class userlogin : Form
    {
        static MongoClient MongoClient = new MongoClient();
        static IMongoDatabase db = MongoClient.GetDatabase("food_order_DB");
        static IMongoCollection<user> collection = db.GetCollection<user>("user");

        public userlogin()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            String name = txtuser.Text;
            String password = txtpass.Text;
            var filter = Builders<user>.Filter.Eq("name", name) & Builders<user>.Filter.Eq("password", password);
            var user = collection.Find(filter).FirstOrDefault();

            if (user != null)
            {   
                this.Hide();
                UserI userI = new UserI();
                userI.Show();

                userI.txtname.Text = user.Name;
                userI.txtaccbal.Text = user.Blance.ToString();





                


            }
        }

        public void mongocon()
        {
            

        }
    }
}
