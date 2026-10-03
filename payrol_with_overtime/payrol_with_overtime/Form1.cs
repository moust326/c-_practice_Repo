using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace payrol_with_overtime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            try {
                double hoursWorked, hourlyPayRate, grossPay;
                // Check validation
                if (txthourworked.Text == "")
                {
                    MessageBox.Show("Please enter hours worked.");
                }
                else
                {
                    if (txthourpayrate.Text == "")
                    {
                        MessageBox.Show("Please enter hourly pay rate.");
                    }
                    else
                    {
                        hoursWorked = double.Parse(txthourworked.Text);
                        hourlyPayRate = double.Parse(txthourpayrate.Text);

                        // Check negative values
                        if (hoursWorked < 0 || hourlyPayRate < 0)
                        {
                            MessageBox.Show("Please enter positive numbers.");
                        }
                        else
                        {
                            // Overtime calculation
                            if (hoursWorked <= 40)
                            {
                                grossPay = hoursWorked * hourlyPayRate;
                            }
                            else
                            {
                                grossPay = (40 * hourlyPayRate) +
                                           ((hoursWorked - 40) * hourlyPayRate * 1.5);
                            }

                            lblgrosspay.Text = grossPay.ToString("C2");
                        }
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
            txthourworked.Clear();
            txthourpayrate.Clear();
            lblgrosspay.Text = "";
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
