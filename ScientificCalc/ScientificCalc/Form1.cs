using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScientificCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int no1, no2;
        double no4;
        string op;


        private void button13_Click(object sender, EventArgs e)
        {
            no1 = Convert.ToInt32(richTextBox1.Text);
            richTextBox1.Text = "";
            op = (sender as Button).Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + (sender as Button).Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + (sender as Button).Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + (sender as Button).Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + (sender as Button).Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + (sender as Button).Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + (sender as Button).Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + (sender as Button).Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + (sender as Button).Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + (sender as Button).Text;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + (sender as Button).Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            no1 = Convert.ToInt32(richTextBox1.Text);
            richTextBox1.Text = "";
            op = (sender as Button).Text;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            no1 = Convert.ToInt32(richTextBox1.Text);
            richTextBox1.Text = "";
            op = (sender as Button).Text;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            no1 = Convert.ToInt32(richTextBox1.Text);
            richTextBox1.Text = "";
            op = (sender as Button).Text;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            no4 = Convert.ToInt32(richTextBox1.Text);
            no4 = (no4 * (Math.PI)) / 180;
            // richTextBox1.Text = Convert.ToString(Math.Sin(no3));
            richTextBox1.Text = (Math.Sin(no4)).ToString();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            no4 = Convert.ToInt32(richTextBox1.Text);
            no4 = (no4 * (Math.PI)) / 180;

            richTextBox1.Text = (Math.Cos(no4)).ToString();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            no4 = Convert.ToInt32(richTextBox1.Text);
            no4 = (no4 * (Math.PI)) / 180;

            richTextBox1.Text = (Math.Tan(no4)).ToString();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            no4 = Convert.ToInt32(richTextBox1.Text);
            no4 = 1 / ((no4 * (Math.PI)) / 180);
            richTextBox1.Text = (1 / (Math.Sin(no4))).ToString();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            no4 = Convert.ToInt32(richTextBox1.Text);
            no4 = 1 / ((no4 * (Math.PI)) / 180);
            richTextBox1.Text = (1 / (Math.Cos(no4))).ToString();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            no4 = Convert.ToInt32(richTextBox1.Text);
            no4 = 1 / ((no4 * (Math.PI)) / 180);
            richTextBox1.Text = (1 / (Math.Tan(no4))).ToString();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            no4 = Convert.ToInt32(richTextBox1.Text);
            richTextBox1.Text = (Math.Pow(no4, 2)).ToString();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            no4 = Convert.ToInt32(richTextBox1.Text);
            richTextBox1.Text = (Math.Pow(no4, 3)).ToString();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            no4 = Convert.ToInt32(richTextBox1.Text);
            richTextBox1.Text = (Math.Sqrt(no4)).ToString();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + (sender as Button).Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            no2 = Convert.ToInt32(richTextBox1.Text);
            switch (op)
            {
                case "+":
                    richTextBox1.Text = (no1 + no2).ToString();
                    break;
                case "-":
                    richTextBox1.Text = (no1 - no2).ToString();
                    break;
                case "/":
                    richTextBox1.Text = (no1 / no2).ToString();
                    break;
                case "*":
                    richTextBox1.Text = (no1 * no2).ToString();
                    break;
                default:
                    break;
            }

        }
    }
}
    
