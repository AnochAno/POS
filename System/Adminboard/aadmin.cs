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
    public partial class aadmin : Form
    {
        static MongoClient client = new MongoClient();
        static IMongoDatabase database = client.GetDatabase("smartCanteenDB");
        static IMongoCollection<Admin> collection = database.GetCollection<Admin>("admin");


        public aadmin()
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
                txtadname.Text = grdadmin.Rows[0].Cells[1].Value.ToString();
                txtademail.Text = grdadmin.Rows[0].Cells[2].Value.ToString();
                txtadphone.Text = grdadmin.Rows[0].Cells[3].Value.ToString();
                txtadpass.Text = grdadmin.Rows[0].Cells[4].Value.ToString();
                txtbal.Text = grdadmin.Rows[0].Cells[5].Value.ToString();
            }
            else
            {
                txtid.Text = string.Empty;
                txtadname.Text = string.Empty;
                txtademail.Text = string.Empty;
                txtadphone.Text = string.Empty;
                txtadpass.Text = string.Empty;
                txtbal.Text = string.Empty;
            }

            
        }

        private void grdadmin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtid.Text = grdadmin.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtadname.Text = grdadmin.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtademail.Text = grdadmin.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtadphone.Text = grdadmin.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtadpass.Text = grdadmin.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtbal.Text = grdadmin.Rows[e.RowIndex].Cells[5].Value.ToString();

            ReadAllDocuments();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin(txtadname.Text, txtademail.Text, txtadphone.Text, txtadpass.Text, Double.Parse(txtbal.Text));
            collection.InsertOneAsync(admin);
            ReadAllDocuments();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            var updateDef = Builders<Admin>.Update.Set("name", txtadname.Text).Set("email", txtademail.Text).Set("phoneNo", txtadphone.Text).Set("password", txtadpass.Text).Set("balance", txtbal.Text);
            collection.UpdateOneAsync(admin => admin.Id == ObjectId.Parse(txtid.Text), updateDef);
            ReadAllDocuments();
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            collection.DeleteOneAsync(admin => admin.Id == ObjectId.Parse(txtid.Text));
            ReadAllDocuments();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
