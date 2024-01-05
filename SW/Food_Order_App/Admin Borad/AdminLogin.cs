using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Food_Order_App.Admin_Borad
{
    public partial class AdminLogin : Form
    {
        static MongoClient client = new MongoClient();
        static IMongoDatabase database = client.GetDatabase("food_order_DB");
        static IMongoCollection<Admin> collection = database.GetCollection<Admin>("admin");
        public AdminLogin()
        {
            InitializeComponent();

            
        }



        private void btnlogin_Click(object sender, EventArgs e)
        {
            string username = txtuser.Text;
            string password = txtpass.Text;

            var filter = Builders<Admin>.Filter.Eq("username", username) & Builders<Admin>.Filter.Eq("password", password);
            var admin = collection.Find(filter).FirstOrDefault();

            if (admin != null)
            {
                DashBorad dashBorad = new DashBorad();
                dashBorad.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Inavalid username or password");
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtpass_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtuser_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
