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

namespace Food_Order_App.UI
{
    public partial class UserI : Form
    {
        double total = 0.0;
        int x = 0;
        public UserI()
        {
            InitializeComponent();
        }
        public void billhead()
        {
            textBox1.Text = "          *********Lunch Food Store**********\r\n" +
                 "                    LFS SMART CANTEEN                  \r\n" +
                 "____________________________________________________\r\n\n" +

                 "\nItem Name|\tQty|\tPrice(Rs)\r\n";

        }
        public bool SpinnerQTYZERO(int qty)
        {
            if (qty == 0)
            {
                MessageBox.Show("Please Increase The ITEM Quantity");
                return false;
            }
            return true;
        }

        private void jCheckBox3_CheckedChanged(object sender, EventArgs e)
        {
            int qty = int.Parse(jSpinner3.Value.ToString());

            if (SpinnerQTYZERO(qty) && jCheckBox3.Checked)
            {

                x++;

                if (x == 1)
                {
                    billhead();
                }

                double price = qty * 200;
                total += price;

                textBox1.Text += x + ". " + label2.Text + "| \t" + qty + "| \t" + price + "|" + "\t\t\t" + "\n";
            }
            else
            {
                jCheckBox3.Checked = false;
            }
        }

        private void jCheckBox4_CheckedChanged(object sender, EventArgs e)
        {
            int qty = int.Parse(jSpinner4.Value.ToString());

            if (SpinnerQTYZERO(qty) && jCheckBox4.Checked)
            {

                x++;

                if (x == 1)
                {
                    billhead();
                }

                double price = qty * 200;
                total += price;

                textBox1.Text += x + ". " + label12.Text + "| \t" + qty + "| \t" + price + "|" + "\t\t\t" + "\n";
            }
            else
            {
                jCheckBox4.Checked = false;
            }
        }

        private void jCheckBox5_CheckedChanged(object sender, EventArgs e)
        {
            int qty = int.Parse(jSpinner5.Value.ToString());

            if (SpinnerQTYZERO(qty) && jCheckBox5.Checked)
            {

                x++;

                if (x == 1)
                {
                    billhead();
                }

                double price = qty * 200;
                total += price;

                textBox1.Text += x + ". " + label18.Text + "| \t" + qty + "| \t" + price + "|" + "\t\t\t" + "\n";
            }
            else
            {
                jCheckBox5.Checked = false;
            }
        }

        private void jCheckBox6_CheckedChanged(object sender, EventArgs e)
        {
            int qty = int.Parse(jSpinner6.Value.ToString());

            if (SpinnerQTYZERO(qty) && jCheckBox6.Checked)
            {

                x++;

                if (x == 1)
                {
                    billhead();
                }

                double price = qty * 200;
                total += price;

                textBox1.Text += x + ". " + label24.Text + "| \t" + qty + "| \t" + price + "|" + "\t\t\t" + "\n";
            }
            else
            {
                jCheckBox6.Checked = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0 );
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
    }
}
