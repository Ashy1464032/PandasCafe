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
    public partial class Coffee : Form
    {
        public Coffee()
        {
            InitializeComponent();
        }

        private void Coffee_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                GlobalVariables.bill += 2.00;
            }
            if (checkBox2.Checked)
            {
                GlobalVariables.bill += 3.00;
            }
            if (checkBox3.Checked)
            {
                GlobalVariables.bill += 2.50;
            }
            if (checkBox4.Checked)
            {
                GlobalVariables.bill += 1.50;
            }

            Sandwich form3 = new Sandwich();
            form3.Show();
            this.Hide();
        }
    }
}
