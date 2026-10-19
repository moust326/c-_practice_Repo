using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vehicle_rental_management
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
         "Are you sure you want to exit?",
         "Exit Application",
         MessageBoxButtons.YesNo,
         MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            try {

                int age, days, experience;
                double dailyRate = 0;
                double basicCost, discount = 0;
                double insurance = 0, youngSurcharge = 0;
                double finalCost;

                string name = txtname.Text;
                string vehicle = "";

                // Validate customer name
                if (name == "")
                {
                    MessageBox.Show("Please enter customer name.");
                    txtname.Focus();
                    return;
                }

                // Validate age
                if (!int.TryParse(txtage.Text, out age))
                {
                    MessageBox.Show("Enter a valid age.");
                    txtage.Focus();
                    return;
                }

                if (age < 18 || age > 80)
                {
                    MessageBox.Show("Age must be between 18 and 80.");
                    return;
                }

                // Validate rental days
                if (!int.TryParse(txtdays.Text, out days))
                {
                    MessageBox.Show("Enter valid rental days.");
                    txtdays.Focus();
                    return;
                }

                if (days < 1 || days > 30)
                {
                    MessageBox.Show("Rental days must be between 1 and 30.");
                    return;
                }

                // Validate driving experience
                if (!int.TryParse(txtexperience.Text, out experience))
                {
                    MessageBox.Show("Enter valid driving experience.");
                    txtexperience.Focus();
                    return;
                }

                if (experience < 0)
                {
                    MessageBox.Show("Driving experience cannot be negative.");
                    return;
                }

                // Check vehicle type
                if (rdoeconomy.Checked)
                {
                    vehicle = "Economy";
                    dailyRate = 35;
                }
                else if (rdosuv.Checked)
                {
                    vehicle = "SUV";
                    dailyRate = 60;
                }
                else if (rdoluxury.Checked)
                {
                    vehicle = "Luxury";
                    dailyRate = 100;
                }
                else
                {
                    MessageBox.Show("Please select a vehicle type.");
                    return;
                }

                // Check eligibility
                if (age < 21)
                {
                    MessageBox.Show("Customer is not eligible to rent a vehicle.");
                    lstresults.Items.Clear();
                    lstresults.Items.Add("Rental Status: Not Eligible");
                    return;
                }

                if (experience < 1)
                {
                    MessageBox.Show("At least 1 year of driving experience is required.");
                    return;
                }

                if (vehicle == "Luxury" && (age < 25 || experience < 3))
                {
                    MessageBox.Show(
                        "Luxury requires age 25 or above and 3 years of driving experience.");
                    return;
                }

                // Calculate basic rental cost
                basicCost = dailyRate * days;

                // Calculate discount
                if (days >= 14)
                {
                    discount = basicCost * 0.10;
                }
                else if (days >= 7)
                {
                    discount = basicCost * 0.05;
                }

                // Calculate insurance
                if (chkinsurance.Checked)
                {
                    insurance = 15 * days;
                }

                // Young driver surcharge: age 21-24
                if (age >= 21 && age <= 24)
                {
                    youngSurcharge = basicCost * 0.10;
                }

                // Calculate final cost
                finalCost = basicCost - discount + insurance + youngSurcharge;

                // Display results
                lstresults.Items.Clear();
                lstresults.Items.Add("RENTAL DETAILS");
                lstresults.Items.Add("------------------------------");
                lstresults.Items.Add("Customer Name: " + name);
                lstresults.Items.Add("Customer Age: " + age);
                lstresults.Items.Add("Driving Experience: " + experience + " years");
                lstresults.Items.Add("Vehicle Type: " + vehicle);
                lstresults.Items.Add("Daily Rate: $" + dailyRate.ToString("0.00"));
                lstresults.Items.Add("Rental Days: " + days);
                lstresults.Items.Add("Basic Rental Cost: $" + basicCost.ToString("0.00"));
                lstresults.Items.Add("Discount: $" + discount.ToString("0.00"));
                lstresults.Items.Add("Insurance Cost: $" + insurance.ToString("0.00"));
                lstresults.Items.Add("Young Driver Surcharge: $" + youngSurcharge.ToString("0.00"));
                lstresults.Items.Add("Final Rental Cost: $" + finalCost.ToString("0.00"));
                lstresults.Items.Add("------------------------------");
                lstresults.Items.Add("Rental Status: Eligible");

               
            }catch(Exception x)
            {
                MessageBox.Show("An eror occured:" + x.Message);
            }
            }

        private void btnclear_Click(object sender, EventArgs e)
        {
          
            txtname.Clear();
            txtage.Clear();
            txtdays.Clear();
            txtexperience.Clear();

            rdoeconomy.Checked = false;
            rdosuv.Checked = false;
            rdoluxury.Checked = false;

            chkinsurance.Checked = false;

            lstresults.Items.Clear();

            txtname.Focus();
        }

    }
    }
    

