using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        FileStream f1;
        StreamWriter wrt;
        StreamReader rd;
      
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            int id = Convert.ToInt32(textBox1.Text);
            String name = textBox2.Text;
            



            f1 = new FileStream(@"C:\Users\test\Documents\ass1.txt", FileMode.Open, FileAccess.Write);
            if (f1 == null)
            {
                MessageBox.Show("sorry... file not found...");
            }
            else
            {
                wrt = new StreamWriter(f1);
                wrt.Write(id + " " + name + " " );
                MessageBox.Show("inserted successfully...");
            }
            wrt.Close();
            f1.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            f1 = new FileStream(@"C:\Users\test\Documents\ass1.txt", FileMode.Open, FileAccess.Read);
            
            StreamReader sr = new StreamReader(f1);
            richTextBox1.Text = sr.ReadToEnd().ToString();
            //richTextBox1.Text = sr.Read().ToString();
            //richTextBox1.Text = sr.Read().ToString();
            wrt.Close();
            f1.Close();

        }
    }
}