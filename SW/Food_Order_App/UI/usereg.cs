using MongoDB.Bson;
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

namespace Food_Order_App.UI
{
    public partial class usereg : Form
    {
        static MongoClient MongoClient = new MongoClient();
        static IMongoDatabase db = MongoClient.GetDatabase("food_order_DB");
        static IMongoCollection<user> collection = db.GetCollection<user>("user");

        public usereg()
        {
            InitializeComponent();
        }

        public void clear()
        {
            txtid.Clear();
            txtname.Clear();
            txtpass.Clear();
            txtbal.Clear();
            txtpho.Clear();
            txtemail.Clear();
            txtid.Focus();
        }
        public void readalldoc()
        {
            List<user> list = collection.AsQueryable().ToList<user>();
            grduser.DataSource = list;
            txtid.Text = grduser.Rows[0].Cells[0].Value.ToString();
            txtname.Text = grduser.Rows[0].Cells[1].Value.ToString();
            txtpass.Text = grduser.Rows[0].Cells[2].Value.ToString();
            txtbal.Text = grduser.Rows[0].Cells[3].Value.ToString();
            txtemail.Text = grduser.Rows[0].Cells[4].Value.ToString();
            txtpho.Text = grduser.Rows[0].Cells[1].Value.ToString();


        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void btnback_Click(object sender, EventArgs e)
        {

        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            collection.DeleteOneAsync(u => u.Id == ObjectId.Parse(txtid.Text));
            readalldoc();
            clear();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            var update = Builders<user>.Update.Set("name", txtname).Set("password", txtpass.Text).Set("blance",txtpass.Text).Set("phone", txtpho.Text).Set("email", txtemail.Text);
            collection.UpdateOneAsync(u => u.Id == ObjectId.Parse(txtid.Text), update);
            readalldoc();
            clear();

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                user u = new user(txtname.Text, txtpass.Text, double.Parse(txtbal.Text), txtemail.Text, txtpho.Text);
                collection.InsertOneAsync(u);
                MessageBox.Show(" Details Succesfully Added");
                readalldoc();
                clear();
            }
            catch(Exception ex) {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtpass_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtuser_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcon_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtemail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtadd_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void grdadmin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void grduser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtid.Text = grduser.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtname.Text = grduser.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtpass.Text = grduser.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtbal.Text = grduser.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtemail.Text = grduser.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtpho.Text = grduser.Rows[e.RowIndex].Cells[1].Value.ToString();
        }
    }
}
