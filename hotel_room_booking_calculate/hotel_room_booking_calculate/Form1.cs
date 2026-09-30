using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hotel_room_booking_calculate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            try { 
            //Declare variables
        string guestName;
            string roomType;
            int nights;
            double pricePerNight;
            double roomCost;
            double serviceTax;
            double discount;
            double totalAmount;

            // Get values from TextBoxes
            guestName = txtname.Text;
            roomType = txtroomtype.Text;
            nights = int.Parse(txtnmbrnight.Text);
            pricePerNight = double.Parse(txtpricenight.Text);

            // Calculate room cost
            roomCost = nights * pricePerNight;

            // Calculate Service Tax (10%)
            serviceTax = roomCost * 0.10;

            // Calculate Discount (5%)
            discount = roomCost * 0.05;

            // Calculate Total Amount
            totalAmount = (roomCost*2 )+ serviceTax - discount;

                // Display Service Tax
                lblSrviceTex.Text = "$" + serviceTax.ToString("0.00");

            // Display Discount
            lblDiscount.Text = "$" + discount.ToString("0.00");

            // Display Total Amount
            lblTotalAmount.Text = "$" + totalAmount.ToString("0.00");
        }
    catch (Exception x)
    {
        // Display error message
        MessageBox.Show(x.Message);
    }
}
    }
}
