using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace today_assignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            string name, course, regidtrationStatu;
            int id, validate, age, numberOfCourse;
            double courseRegistrationFee, courseDiscount;
            double price, total;
            try
            {
                if (int.TryParse(txtid.Text, out validate))
                {
                    if (int.TryParse(txtage.Text, out validate))
                    {
                        id = int.Parse(txtid.Text);
                        name = txtname.Text;
                        age = int.Parse(txtage.Text);
                        price = double.Parse(txtprice.Text);
                        numberOfCourse = int.Parse(txtnumberofcourse.Text);

                        if (id > 0)
                        {
                            if (name != null)
                            {



                                if (age > 0)
                                {
                                    if (age > 16 && age < 60)
                                    {
                                        if (numberOfCourse > 0)

                                        {
                                            double basic_regester = numberOfCourse * price;
                                            Double discount = 0;

                                            if (numberOfCourse > 1 && numberOfCourse <= 2)
                                            {
                                                discount = basic_regester * 0.05;
                                            } else if (numberOfCourse >= 3 && numberOfCourse <= 4)
                                            {
                                                discount = basic_regester * 0.10;

                                            } else if (numberOfCourse == 5){
                                                discount = basic_regester * 0.15;

                                            }

                                            total = price * numberOfCourse;
                                            lststudentinfo.Items.Add("student ID: " + id);
                                            lststudentinfo.Items.Add("student name: " + name);
                                            lststudentinfo.Items.Add("number of course: " + numberOfCourse);
                                            lststudentinfo.Items.Add("number of course: " + numberOfCourse);
                                            lststudentinfo.Items.Add("-------------------------------------");
                                            lststudentinfo.Items.Add("basic regitration fee: $" + price);
                                            lststudentinfo.Items.Add("course discount: $" + discount);
                                            lststudentinfo.Items.Add("--------------------------------------");
                                            lststudentinfo.Items.Add("final registration fee: $" + total);
                                            lststudentinfo.Items.Add("registration status: " + "approved");
                                            lststudentinfo.Items.Add(" ");

                                        }
                                       
                                        else
                                        {
                                            MessageBox.Show("at least one course must be inserted");
                                            lststudentinfo.Items.Add("student ID: " + id);
                                            lststudentinfo.Items.Add("student name: " + name);
                                           
                                            lststudentinfo.Items.Add("--------------------------------------");
                               
                                            lststudentinfo.Items.Add("registration status: " + "approved");
                                            lststudentinfo.Items.Add(" ");
                                        }
                                        



                                    }
                                    else
                                    {
                                        MessageBox.Show("age must be 16 up to 60");
                                    }

                                }
                                else
                                {
                                    MessageBox.Show("age connot be negative! ");
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("id must not be negative and it must be inserted! ");
                        }

                    }
                    else
                    {
                        MessageBox.Show("age must be numeric");
                    }

                }
                else
                {
                    MessageBox.Show("id must be numeric");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtname.Clear();
            txtage.Clear();
            txtid.Clear();
            txtcoursename.Clear();
            txtprice.Clear();
            txtnumberofcourse.Clear();
            lststudentinfo.Items.Clear();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            string cousre;
            int numberOfCourse;
            decimal price, valudate;
            cousre = txtcoursename.Text;
            if (cousre != null)
            {




                if (decimal.TryParse(txtprice.Text, out valudate))
                {
                    price = decimal.Parse(txtprice.Text);
                    numberOfCourse = int.Parse(txtnumberofcourse.Text);
                    if (price > 0)
                    {
                        if (numberOfCourse > 1 && numberOfCourse < 6)
                        {
                            int count = 0;
                            //while (cousre!=cousre)

                            lstcourseinfo.Items.Add("course name: " + cousre);
                            lstcourseinfo.Items.Add("course price: $" + price);
                            lstcourseinfo.Items.Add("number of course: " + numberOfCourse);


                           
                        }
                        else
                        {
                            MessageBox.Show("number of course must be betweeen 1 up to 5");
                        }


                    }
                    else
                    {
                        MessageBox.Show("price must be negative");
                    }
                }
                else
                {
                    MessageBox.Show("pleas enter  a numeric number!");
                }
            }
            else
            {
                MessageBox.Show("course must not empety");
            }
            txtcoursename.Clear();
            txtprice.Clear();
            txtnumberofcourse.Clear();

        }

        private void btnremove_Click(object sender, EventArgs e)
        {
        //    String selectedItem = lstcourseinfo.SelectedItem.ToString();
        //    if (lstcourseinfo.SelectedIndex != -1)
        //    {

        //        lstcourseinfo.Items.Remove(selectedItem);
        //    }
        //    else
        //    {
        //        MessageBox.Show("please select item to remove");
        //    }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
    }
    

