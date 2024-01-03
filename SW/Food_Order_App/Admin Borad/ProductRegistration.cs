using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using MongoDB.Bson;
using MongoDB.Driver;


namespace Food_Order_App.Admin_Borad
{
    public partial class ProductRegistration : Form
    {
        static MongoClient client = new MongoClient();
        static IMongoDatabase database = client.GetDatabase("food_order_DB");
        static IMongoCollection<Product> collection = database.GetCollection<Product>("product");
        public ProductRegistration()
        {
            InitializeComponent();
            ReadAllDocument();

            grdproduct.CellClick += grdproduct_CellClick;
        }

        public void ReadAllDocument()
        {
            List<Product> list = collection.AsQueryable().ToList<Product>();
            grdproduct.DataSource = list;

            if (grdproduct.Rows.Count > 0)
            {
                txtid.Text = grdproduct.Rows[0].Cells[0].Value.ToString();
                txtname.Text = grdproduct.Rows[0].Cells[1].Value.ToString();
                txtprice.Text = grdproduct.Rows[0].Cells[2].Value.ToString();
                txtdis.Text = grdproduct.Rows[0].Cells[3].Value.ToString();
                txtstock.Text = grdproduct.Rows[0].Cells[4].Value.ToString();
            }
            else
            {
                txtid.Text = string.Empty;
                txtname.Text = string.Empty;
                txtprice.Text = string.Empty;
                txtdis.Text = string.Empty;
                txtstock.Text = string.Empty;
            }
        }

        private void grdproduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtid.Text = grdproduct.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtname.Text = grdproduct.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtprice.Text = grdproduct.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtdis.Text = grdproduct.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtstock.Text = grdproduct.Rows[e.RowIndex].Cells[4].Value.ToString();

            ReadAllDocument();
        }

        private async void btnsave_Click(object sender, EventArgs e)
        {
            Product product = new Product(txtname.Text, double.Parse(txtprice.Text), double.Parse(txtdis.Text), double.Parse(txtstock.Text));
            await collection.InsertOneAsync(product);
            ReadAllDocument();
        }

        private async void btnupdate_Click(object sender, EventArgs e)
        {
            var updateDef = Builders<Product>.Update.Set("name", txtname.Text).Set("price", txtprice.Text).Set("discount", txtdis.Text).Set("stock", txtstock.Text);
            await collection.UpdateOneAsync(product => product.Id == ObjectId.Parse(txtid.Text), updateDef);
            ReadAllDocument();
        }

        private async void btndel_Click(object sender, EventArgs e)
        {
            await collection.DeleteOneAsync(product => product.Id == ObjectId.Parse(txtid.Text));
            ReadAllDocument();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            new DashBorad().Show();
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            txtid.Text = string.Empty;
            txtname.Text = string.Empty;
            txtprice.Text = string.Empty;
            txtdis.Text = string.Empty;
            txtstock.Text = string.Empty;

            txtname.Focus();
        }

        private void grdproduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < grdproduct.Rows.Count)
            {
                // Get the selected cell values
                txtid.Text = grdproduct.Rows[e.RowIndex].Cells["ID"].Value?.ToString() ?? string.Empty;
                txtname.Text = grdproduct.Rows[e.RowIndex].Cells["Name"].Value?.ToString() ?? string.Empty;
                txtprice.Text = grdproduct.Rows[e.RowIndex].Cells["Price"].Value?.ToString() ?? string.Empty;
                txtdis.Text = grdproduct.Rows[e.RowIndex].Cells["Discount"].Value?.ToString() ?? string.Empty;
                txtstock.Text = grdproduct.Rows[e.RowIndex].Cells["Stock"].Value?.ToString() ?? string.Empty;
            }
        }

        private void btnback_Click_1(object sender, EventArgs e)
        {
            new DashBorad().Show();
            this.Hide();
        }
    }
}
