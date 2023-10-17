using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PandaCafe
{
    public partial class Cakes : Form
    {
        public Cakes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                GlobalVariables.bill += 2.00;
            }
            if (checkBox2.Checked)
            {
                GlobalVariables.bill += 2.50;
            }
            if (checkBox3.Checked)
            {
                GlobalVariables.bill += 2.50;
            }
            if (checkBox4.Checked)
            {
                GlobalVariables.bill += 1.50;
            }
            if (checkBox5.Checked)
            {
                GlobalVariables.bill += 2.00;
            }
            String custBillFormat = String.Format("£{0:0.00}", GlobalVariables.bill);
            MessageBox.Show("Your total is: " + custBillFormat, "Your Total");
            Application.Exit();
        }

        private void Cakes_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
