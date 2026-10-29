using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics.Eventing.Reader;

namespace files_assignment1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btndeletefile_Click(object sender, EventArgs e)
        {



            if (File.Exists("C:\\Users\\HP\\Desktop\\C#TASKS FILE\\Read path\\CA242.txt"))
            {
                DialogResult result = MessageBox.Show(
                    "Are you sure you want to delete this file?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.Yes)
                {
                    File.Delete("C:\\Users\\HP\\Desktop\\C#TASKS FILE\\Read path\\CA242.txt");

                    listBox1.Items.Clear();

                    MessageBox.Show("File deleted successfully!");
                }
            }
            else
            {
                MessageBox.Show("File does not exist!");
            }
        }

        private void btndeleteitem_Click(object sender, EventArgs e)
        {


            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an item first!");
                return;
            }

            if (File.Exists("C:\\Users\\HP\\Desktop\\C#TASKS FILE\\Read path\\CA242.txt"))
            {
                List<string> lines = File.ReadAllLines("C:\\Users\\HP\\Desktop\\C#TASKS FILE\\Read path\\CA242.txt").ToList();

                lines.RemoveAt(listBox1.SelectedIndex);

                File.WriteAllLines("C:\\Users\\HP\\Desktop\\C#TASKS FILE\\Read path\\CA242.txt", lines);

                listBox1.Items.Clear();
                listBox1.Items.AddRange(lines.ToArray());

                MessageBox.Show("Item deleted successfully!");
            }
            else
            {
                MessageBox.Show("File does not exist!");
            }
        }

        private void btn_createfile_Click(object sender, EventArgs e)
        {
            StreamWriter outputfile;

            outputfile = File.CreateText("C:\\Users\\HP\\Desktop\\C#TASKS FILE\\Read path\\CA242.txt");

            outputfile.WriteLine("East Africa Countrues Are:");
            outputfile.WriteLine("Somalia");
            outputfile.WriteLine("Kenya");
            outputfile.WriteLine("Tanzania");
            outputfile.WriteLine("Eriteria");
            outputfile.WriteLine("Uganda");
            outputfile.WriteLine("ethiopia");
            outputfile.WriteLine("sudan");
            outputfile.WriteLine("rwanda");
            outputfile.WriteLine("burundi");
            outputfile.WriteLine("sout sudan");
            outputfile.WriteLine("djibuti");


            outputfile.Close();
            MessageBox.Show("file succesfully created");



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnreadalllines_Click(object sender, EventArgs e)
        {

            String[] lines;
            lines = File.ReadAllLines("C:\\Users\\HP\\Desktop\\C#TASKS FILE\\Read path\\CA242.txt");
            listBox1.Items.AddRange(lines);


            

        }


        private void button1_Click(object sender, EventArgs e)


        {

            listBox1.Items.Add("READ LINES");
            listBox1.Items.Add("==============");

            if (File.Exists("C:\\Users\\HP\\Desktop\\C#TASKS FILE\\Read path\\CA242.txt"))
            {


                string[] lines;
                foreach (string line in File.ReadLines("C:\\Users\\HP\\Desktop\\C#TASKS FILE\\Read path\\CA242.txt"))
                {
                    listBox1.Items.Add(line);


                }
            }
            else
            {
                MessageBox.Show("path not found");
            }

        }

        private void btn_readfile_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("READ ALL LINES");
            listBox1.Items.Add("==============");

            StreamReader readinfo;
            readinfo = File.OpenText("C:\\Users\\HP\\Desktop\\C#TASKS FILE\\Read path\\CA242.txt");

            string lines;
            while (readinfo.EndOfStream==false)
            {
                lines = readinfo.ReadLine();
                listBox1.Items.Add(lines);


            }

            readinfo.Close();
        }
    }
    }

