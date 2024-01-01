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

namespace Food_Order_App.Admin_Borad
{
    public partial class AdminRegistration : Form
    {
        static MongoClient client = new MongoClient();
        static IMongoDatabase database = client.GetDatabase("food_order_DB");
        static IMongoCollection<Admin> collection = database.GetCollection<Admin>("admin");
        public AdminRegistration()
        {
            InitializeComponent();
            ReadAllDocuments();
        }

        public void ReadAllDocuments()
        {
            List<Admin> list = collection.AsQueryable().ToList<Admin>();
            grdadmin.DataSource = list;

            if (grdadmin.Rows.Count > 0)
            {
                txtid.Text = grdadmin.Rows[0].Cells[0].Value.ToString();
                txtname.Text = grdadmin.Rows[0].Cells[1].Value.ToString();
                txtadd.Text = grdadmin.Rows[0].Cells[2].Value.ToString();
                txtemail.Text = grdadmin.Rows[0].Cells[3].Value.ToString();
                txtcon.Text = grdadmin.Rows[0].Cells[4].Value.ToString();
                txtuser.Text = grdadmin.Rows[0].Cells[5].Value.ToString();
                txtpass.Text = grdadmin.Rows[0].Cells[6].Value.ToString();
                
            }
            else
            {
                txtid.Text = string.Empty;
                txtname.Text = string.Empty;
                txtadd.Text = string.Empty;
                txtemail.Text = string.Empty;
                txtcon.Text = string.Empty;
                txtuser.Text = string.Empty;
                txtpass.Text = string.Empty;
                
            }


        }

        private void grdadmin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtid.Text = grdadmin.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtname.Text = grdadmin.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtadd.Text = grdadmin.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtemail.Text = grdadmin.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtcon.Text = grdadmin.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtuser.Text = grdadmin.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtpass.Text = grdadmin.Rows[e.RowIndex].Cells[6].Value.ToString();
            

            ReadAllDocuments();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin(txtname.Text, txtadd.Text, txtemail.Text, txtcon.Text, txtuser.Text, txtpass.Text);
            collection.InsertOneAsync(admin);
            ReadAllDocuments();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            var updateDef = Builders<Admin>.Update.Set("name", txtname.Text).Set("address", txtadd.Text).Set("email", txtemail.Text).Set("contact", txtcon.Text).Set("username", txtuser.Text).Set("password", txtpass.Text);
            collection.UpdateOneAsync(admin => admin.Id == ObjectId.Parse(txtid.Text), updateDef);
            ReadAllDocuments();
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            collection.DeleteOneAsync(admin => admin.Id == ObjectId.Parse(txtid.Text));
            ReadAllDocuments();
        }
    }
}
