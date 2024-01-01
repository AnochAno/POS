using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace food_order
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            billhead();
        }


        public void billhead()
        {
            textBox1.Text = "         **********************Lunch Food Store**********************\r\n" +
                 "                                 LFS SMART CANTEEN                  \r\n" +
                 "____________________________________________________\r\n\n" +

                 "\nItem Name|\tQty|\tPrice(Rs)\r\n";

        }

        public void time_and_date()
        {
            

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
