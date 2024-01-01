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
    public partial class userlogin : Form
    {
        public userlogin()
        {
            InitializeComponent();
        }

        public void clear()
        {
            txtusername.Clear();
            txtpass.Clear();
            txtusername.Focus();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btncan_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void showpass_CheckedChanged(object sender, EventArgs e)
        {
            txtpass.UseSystemPasswordChar = !showpass.Checked;
        }
    }
}
