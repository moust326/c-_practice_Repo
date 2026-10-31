using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace filespractice2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamReader Aqrin;
            DialogResult result;
            result = openfile.ShowDialog();
            if(result== DialogResult.OK)//true
            {
                //open the file reading the file reads =
                Aqrin = File.OpenText(openfile.FileName);
                //process
                string lines;
                while(Aqrin.EndOfStream==false)
                {
                    lines = Aqrin.ReadLine();
                    if (!listBox1.Items.Contains(lines))
                    {
                        listBox1.Items.Add(lines);
                    }
                   
                }
               
                //close
                Aqrin.Close();



            }
            else if(result == DialogResult.Cancel)
            {
                MessageBox.Show("not open the file");
            }
            listBox1.Items.Add(textBox1);
            
            {
               

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            StreamWriter writes;
            DialogResult result;
            result = savefile.ShowDialog();
            if (result == DialogResult.OK)
            {
                //open the file _create new file writes
                writes = File.AppendText(savefile.FileName);

                //process
                writes.WriteLine(textBox1.Text);
                //close
                writes.Close();

                

                //display textbox data in listbox
                //listBox1.Items.Add(textBox1.Text);
              
               

            }
            else if (result == DialogResult.Cancel)
            {
                MessageBox.Show("not saved the file");
            }
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            textBox1.Clear();
        }

        private void createfile_Click(object sender, EventArgs e)
        {

        }
    }
}
