using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hotel_room_bookin1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            try
            {
                string guestName = txtGuestName.Text;
                int age, nights, guests;
                double roomRate = 0;
                double basicCost, discount = 0;
                double breakfastCost = 0;
                double serviceCharge = 0;
                double seniorDiscount = 0;
                double subtotal, finalCost;
                string roomType = "";
                int maxGuests = 0;

                if (guestName == "")
                {
                    MessageBox.Show("Enter guest name.");
                    txtGuestName.Focus();
                    return;
                }

                if (!int.TryParse(txtGuestAge.Text, out age))
                {
                    MessageBox.Show("Enter a valid age.");
                    return;
                }

                if (!int.TryParse(txtNights.Text, out nights))
                {
                    MessageBox.Show("Enter valid nights.");
                    return;
                }

                if (!int.TryParse(txtGuests.Text, out guests))
                {
                    MessageBox.Show("Enter valid number of guests.");
                    return;
                }

                if (age < 18 || age > 90)
                {
                    MessageBox.Show("Age must be between 18 and 90.");
                    return;
                }

                if (nights < 1 || nights > 30)
                {
                    MessageBox.Show("Nights must be between 1 and 30.");
                    return;
                }

                if (guests < 1 || guests > 6)
                {
                    MessageBox.Show("Guests must be between 1 and 6.");
                    return;
                }

                if (rdoStandard.Checked)
                {
                    roomType = "Standard";
                    roomRate = 50;
                    maxGuests = 2;
                }
                else if (rdoNormal.Checked)
                {
                    roomType = "Normal";
                    roomRate = 80;
                    maxGuests = 4;
                }
                else if (rdoHight.Checked)
                {
                    roomType = "High";
                    roomRate = 130;
                    maxGuests = 6;
                }
                else
                {
                    MessageBox.Show("Select a room type.");
                    return;
                }

                if (guests > maxGuests)
                {
                    listBox1.Text =
                        "BOOKING REJECTED\n" +
                        "------------------------------\n" +
                        "Guest Name: " + guestName + "\n" +
                        "Room Type: " + roomType + "\n" +
                        "Number of Guests: " + guests + "\n" +
                        "Maximum Capacity: " + maxGuests + "\n" +
                        "Reason: Room capacity exceeded.";
                    return;
                }

                basicCost = roomRate * nights;

                if (nights >= 10)
                {
                    discount = basicCost * 0.12;
                }
                else if (nights >= 5)
                {
                    discount = basicCost * 0.05;
                }

                if (age >= 60)
                {
                    seniorDiscount = basicCost * 0.05;
                }

                if (chkBreakfast.Checked)
                {
                    breakfastCost = 10 * guests * nights;
                }

                subtotal = basicCost - discount
                           - seniorDiscount + breakfastCost;

                if (guests > 4)
                {
                    serviceCharge = subtotal * 0.05;
                }

                finalCost = subtotal + serviceCharge;

                listBox1.Items.Clear();

                listBox1.Items.Add("HOTEL ROOM BOOKING DETAILS");
                listBox1.Items.Add("------------------------------");
                listBox1.Items.Add("Booking Status: APPROVED");
                listBox1.Items.Add("Guest Name: " + guestName);
                listBox1.Items.Add("Guest Age: " + age);
                listBox1.Items.Add("Room Type: " + roomType);
                listBox1.Items.Add("Room Rate: $" + roomRate.ToString("0.00"));
                listBox1.Items.Add("Number of Nights: " + nights);
                listBox1.Items.Add("Number of Guests: " + guests);
                listBox1.Items.Add("Breakfast: " + (chkBreakfast.Checked ? "Yes" : "No"));

                listBox1.Items.Add("------------------------------");
                listBox1.Items.Add("Basic Cost: $" + basicCost.ToString("0.00"));
                listBox1.Items.Add("Night Discount: $" + discount.ToString("0.00"));
                listBox1.Items.Add("Senior Discount: $" + seniorDiscount.ToString("0.00"));
                listBox1.Items.Add("Breakfast Cost: $" + breakfastCost.ToString("0.00"));
                listBox1.Items.Add("Service Charge: $" + serviceCharge.ToString("0.00"));

                listBox1.Items.Add("------------------------------");
                listBox1.Items.Add("Subtotal: $" + subtotal.ToString("0.00"));
                listBox1.Items.Add("FINAL COST: $" + finalCost.ToString("0.00"));
                listBox1.Items.Add("------------------------------");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            txtGuestName.Clear();
            txtGuestAge.Clear();
            txtNights.Clear();
            txtGuests.Clear();

            rdoStandard.Checked = false;
            rdoNormal.Checked = false;
            rdoHight.Checked = false;

            chkBreakfast.Checked = false;

            listBox1.Items.Clear();

            txtGuestName.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }
    

