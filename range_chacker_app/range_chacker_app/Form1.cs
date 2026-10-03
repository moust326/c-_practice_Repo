using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace range_chacker_app
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btncheck_Click(object sender, EventArgs e)
        {
            try
            {
                int number;

                if (txtrange.Text == "")
                {
                    MessageBox.Show("Please enter a number.");
                }
                else
                {
                    number = int.Parse(txtrange.Text);

                    if (number >= 1 && number <= 10)
                    {
                       lbldecisioon.Text = "The number is in the range.";
                    }
                    else
                    {
                        lbldecisioon.Text = "The number is outside the range.";
                    }
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);

            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtrange.Clear();
            lbldecisioon.Text = "";
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
