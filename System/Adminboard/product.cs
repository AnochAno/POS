using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Bson;
using MongoDB.Driver;


namespace System.Adminboard
{
    public partial class product : Form
    {
        static MongoClient client = new MongoClient();
        static IMongoDatabase database = client.GetDatabase("smartCanteenDB");
        static IMongoCollection<Product> collection = database.GetCollection<Product>("product");
        public product()
        {
            InitializeComponent();
            ReadAllDocument();
        }

        public void ReadAllDocument()
        {
            List<Product> list = collection.AsQueryable().ToList<Product>();
            grdproduct.DataSource = list;

            if (grdproduct.Rows.Count > 0 )
            {
                txtid.Text = grdproduct.Rows[0].Cells[0].Value.ToString();
                txtpname.Text = grdproduct.Rows[0].Cells[1].Value.ToString();
                txtprice.Text = grdproduct.Rows[0].Cells[2].Value.ToString();
                txtdiscount.Text = grdproduct.Rows[0].Cells[3].Value.ToString();
                txtstock.Text = grdproduct.Rows[0].Cells[4].Value.ToString();
            }
            else
            {
                txtid.Text = string.Empty;
                txtpname.Text = string.Empty;
                txtprice.Text = string.Empty;
                txtdiscount.Text = string.Empty;
                txtstock.Text = string.Empty;
            }
        }

        private void grdproduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtid.Text = grdproduct.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtpname.Text = grdproduct.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtprice.Text = grdproduct.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtdiscount.Text = grdproduct.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtstock.Text = grdproduct.Rows[e.RowIndex].Cells[4].Value.ToString();

            ReadAllDocument();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            Product product = new Product(txtpname.Text, double.Parse(txtprice.Text), double.Parse(txtdiscount.Text), double.Parse(txtstock.Text));
            collection.InsertOneAsync(product);
            ReadAllDocument();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            var updateDef = Builders<Product>.Update.Set("name", txtpname.Text).Set("price", txtprice.Text).Set("discount", txtdiscount.Text).Set("stock", txtstock.Text);
            collection.UpdateOneAsync(product => product.Id == ObjectId.Parse(txtid.Text), updateDef);
            ReadAllDocument() ;
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            collection.DeleteOneAsync(product => product.Id == ObjectId.Parse(txtid.Text));
            ReadAllDocument() ;
        }
    }
}
