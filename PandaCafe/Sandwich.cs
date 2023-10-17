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
    public partial class Sandwich : Form
    {
        public Sandwich()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                GlobalVariables.bill += 1.30;
            }
            if (checkBox2.Checked)
            {
                GlobalVariables.bill += 1.50;
            }
            if (checkBox3.Checked)
            {
                GlobalVariables.bill += 1.50;
            }
            if (checkBox4.Checked)
            {
                GlobalVariables.bill += 1.75;
            }
            if (checkBox5.Checked)
            {
                GlobalVariables.bill += 2.50;
            }
            if (checkBox6.Checked)
            {
                GlobalVariables.bill += 2.75;
            }
            Cakes form4 = new Cakes();
            form4.Show();
            this.Hide();

        }

        private void Sandwich_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
