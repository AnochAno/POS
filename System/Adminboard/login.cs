using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Adminboard;


namespace System.Adminboard
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
            //pass.UseSystemPasswordChar = true;
        }

        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-MM7BIH0F;Initial Catalog=System;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            String Username, Password;

            Username = name.Text;
            Password = pass .Text;

            try
            {
                String Save = "SELECT * FROM Admin_Registration WHERE UserName = '" +name.Text+ "' AND Password = '" +pass.Text+ "' ";
                SqlDataAdapter sda = new SqlDataAdapter(Save, conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if(dt.Rows.Count > 0)
                {
                    Username = name.Text;
                    Password = pass .Text;

                    aadmin ad = new aadmin();
                    ad.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("UserName and Password Not Matched");
                    clear();
                }


            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Error in Your Database connection" , "Error " , MessageBoxButtons.OK);
                clear();
            }finally { 
            conn.Close();
            }

        }

        private  void clear()
        {
            pass.Clear();
            name.Clear();
            name.Focus();
        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //pass.UseSystemPasswordChar = !checkBox1.Checked;
        }
    }
}
