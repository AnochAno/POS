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
    public partial class DashBorad : Form
    {
        static MongoClient client = new MongoClient();
        static IMongoDatabase database = client.GetDatabase("food_order_DB");
        static IMongoCollection<Product> collection = database.GetCollection<Product>("product");
        public DashBorad()
        {
            InitializeComponent();

            lblproduct.Text = collection.CountDocuments(FilterDefinition<Product>.Empty).ToString();
        }

        private void btnadmin_Click(object sender, EventArgs e)
        {
            AdminRegistration adminRegistration = new AdminRegistration();
            adminRegistration.Show();

            this.Hide();
        }

        private void btnproduct_Click(object sender, EventArgs e)
        {
            ProductRegistration productRegistration = new ProductRegistration();
            productRegistration.Show();
            this.Hide();
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            AdminLogin adminLogin = new AdminLogin();
            adminLogin.Show();
            this.Hide();
        }

        
    }
}
