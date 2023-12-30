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
        

        private void button1_Click(object sender, EventArgs e)
        {
            

           

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
            
        }
    }
}
