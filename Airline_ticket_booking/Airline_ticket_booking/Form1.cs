using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airline_ticket_booking
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                string passengerName = txtPassengerName.Text;
                int age = 0;
                int numberOfTickets = 0;
                double baggageWeight = 0;

                double ticketPrice = 0;
                double basicTicketCost, ticketDiscount = 0;
                double ageDiscount = 0, insuranceCost = 0;
                double totalDiscount, finalCost;

                bool bookingApproved = true;

                rtbBookingDetails.Items.Clear();

                // Validate passenger name
                if (passengerName == "")
                {
                    MessageBox.Show("Please enter passenger name.");
                    bookingApproved = false;
                }

                // Validate age
                else if (!int.TryParse(txtPassengerAge.Text, out age))
                {
                    MessageBox.Show("Please enter a valid passenger age.");
                    bookingApproved = false;
                }
                else if (age < 1 || age > 100)
                {
                    MessageBox.Show("Age must be between 1 and 100.");
                    bookingApproved = false;
                }

                // Validate number of tickets
                else if (!int.TryParse(txtNumberOfTickets.Text, out numberOfTickets))
                {
                    MessageBox.Show("Please enter a valid number of tickets.");
                    bookingApproved = false;
                }
                else if (numberOfTickets < 1 || numberOfTickets > 5)
                {
                    MessageBox.Show("Tickets must be between 1 and 5.");
                    bookingApproved = false;
                }

                // Validate baggage weight
                else if (!double.TryParse(txtBaggageWeight.Text, out baggageWeight))
                {
                    MessageBox.Show("Please enter a valid baggage weight.");
                    bookingApproved = false;
                }
                else if (baggageWeight < 0 || baggageWeight > 50)
                {
                    MessageBox.Show("Baggage weight must be between 0 and 50 kg.");
                    bookingApproved = false;
                }

                // Validate travel class
                else if (!rdoFirstClass.Checked &&
                         !rdoNormalClass.Checked &&
                         !rdoBusinessClass.Checked)
                {
                    MessageBox.Show("Please select a travel class.");
                    bookingApproved = false;
                }

                // Reject First Class for children below 12
                else if (age < 12 && rdoFirstClass.Checked)
                {
                    MessageBox.Show("Passengers below 12 cannot book First Class.");
                    bookingApproved = false;
                }

                if (bookingApproved == false)
                {
                    return;
                }

                // Ticket price
                if (rdoFirstClass.Checked)
                {
                    ticketPrice = 300;
                }
                else if (rdoNormalClass.Checked)
                {
                    ticketPrice = 100;
                }
                else if (rdoBusinessClass.Checked)
                {
                    ticketPrice = 200;
                }

                // Basic ticket cost
                basicTicketCost = ticketPrice * numberOfTickets;

                // Ticket quantity discount
                if (numberOfTickets >= 3 && numberOfTickets <= 4)
                {
                    ticketDiscount = basicTicketCost * 0.05;
                }
                else if (numberOfTickets == 5)
                {
                    ticketDiscount = basicTicketCost * 0.10;
                }

                // Child or senior discount
                double discountedCost = basicTicketCost - ticketDiscount;

                if (age < 12)
                {
                    ageDiscount = discountedCost * 0.20;
                }
                else if (age >= 60)
                {
                    ageDiscount = discountedCost * 0.10;
                }

                // Travel insurance
                if (chkInsurance.Checked)
                {
                    insuranceCost = 25 * numberOfTickets;
                }

                // Final cost
                totalDiscount = ticketDiscount + ageDiscount;
                finalCost = basicTicketCost - totalDiscount + insuranceCost;

                // Display booking details
                rtbBookingDetails.Items.Clear();

                rtbBookingDetails.Items.Add("AIRLINE TICKET BOOKING DETAILS");
                rtbBookingDetails.Items.Add("------------------------------");
                rtbBookingDetails.Items.Add("Passenger Name: " + passengerName);
                rtbBookingDetails.Items.Add("Passenger Age: " + age);
                rtbBookingDetails.Items.Add("Number of Tickets: " + numberOfTickets);
                rtbBookingDetails.Items.Add("Baggage Weight: " + baggageWeight + " kg");
                rtbBookingDetails.Items.Add("Ticket Price: $" + ticketPrice);
                rtbBookingDetails.Items.Add("Basic Cost: $" + basicTicketCost);
                rtbBookingDetails.Items.Add("Ticket Discount: $" + ticketDiscount);
                rtbBookingDetails.Items.Add("Age Discount: $" + ageDiscount);
                rtbBookingDetails.Items.Add("Insurance: $" + insuranceCost);
                rtbBookingDetails.Items.Add("Final Cost: $" + finalCost);
                rtbBookingDetails.Items.Add("Booking Approved: Yes");
            }
            catch (Exception x)
            {
                MessageBox.Show("An error occurated :" + x.Message, "error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            txtPassengerName.Clear();
            txtPassengerAge.Clear();
            txtNumberOfTickets.Clear();
            txtBaggageWeight.Clear();

            rdoFirstClass.Checked = false;
            rdoNormalClass.Checked = false;
            rdoBusinessClass.Checked = false;

            chkInsurance.Checked = false;

            rtbBookingDetails.Items.Clear();

            txtPassengerName.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            DialogResult result = MessageBox.Show(
                "Are you sure you want to exit?",
                "Exit Application",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
    }
    
    

    

