using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test_score_avg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            try
            {

                double score1, score2, score3, average;

                score1 = double.Parse(txtscore1.Text);
                score2 = double.Parse(txtscore2.Text);
                score3 = double.Parse(txtscore3.Text);

                average = (score1 + score2 + score3) / 3;

                if (average >= 90)
                {
                    lblavg.Text = "Excellent: " + average.ToString("0.0");
                }
                else if (average >= 80)
                {
                    lblavg.Text = "Very Good: " + average.ToString("0.0");
                }
                else if (average >= 70)
                {
                    lblavg.Text = "Good: " + average.ToString("0.0");
                }
                else if (average >= 60)
                {
                    lblavg.Text = "Pass: " + average.ToString("0.0");
                }
                else
                {
                    lblavg.Text = "Fail: " + average.ToString("0.0");

                }
            }
            catch(Exception x)
            {
                MessageBox.Show(x.Message);
            }




            }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtscore3.Clear();
            txtscore2.Clear();
            txtscore3.Clear();
            lblavg.Text = "";

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }
