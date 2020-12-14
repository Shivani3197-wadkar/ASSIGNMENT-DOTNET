using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace scientific_calcs
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

        private void standerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 353;
            richTextBox1.Width = 313;

        }

        private void scintificToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 621;
            richTextBox1.Width = 313;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 353;
            richTextBox1.Width = 313;

        }

        private void button10_Click(object sender, EventArgs e)
        {
          
            richTextBox1.Text = richTextBox1.Text + (sender as Button).Text;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            no1 = Convert.ToInt32(richTextBox1.Text);
            richTextBox1.Text = "";
            op = (sender as Button).Text;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            no4 = Convert.ToInt32(richTextBox1.Text);
            richTextBox1.Text = (Math.Sqrt(no4)).ToString();


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

        private void button19_Click(object sender, EventArgs e)
        {
            no4 = Convert.ToInt32(richTextBox1.Text);
            no4 = (no4 * (Math.PI)) / 180;

            richTextBox1.Text = (Math.Tan(no4)).ToString();

        }

        private void button20_Click(object sender, EventArgs e)
        {
            no4 = Convert.ToInt32(richTextBox1.Text);
            no4 = 1 / ((no4 * (Math.PI)) / 180);
            richTextBox1.Text = (1/(Math.Sin(no4))).ToString();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            no4 = Convert.ToInt32(richTextBox1.Text);
            no4 = 1 / ((no4 * (Math.PI)) / 180);
            richTextBox1.Text = (1 / (Math.Cos(no4))).ToString();

        }

        private void button27_Click(object sender, EventArgs e)
        {
            no4 = Convert.ToInt32(richTextBox1.Text);
            no4 = 1 / ((no4 * (Math.PI)) / 180);
            richTextBox1.Text = (1 / (Math.Tan(no4))).ToString();
        }

        private void button28_Click(object sender, EventArgs e)
        {
            no4 = Convert.ToInt32(richTextBox1.Text);
            richTextBox1.Text = (Math.Pow(no4,2)).ToString();
        }

        private void button29_Click(object sender, EventArgs e)
        {
            no4 = Convert.ToInt32(richTextBox1.Text);
            richTextBox1.Text = (Math.Pow(no4, 3)).ToString();
        }

        private void button30_Click(object sender, EventArgs e)
        {
            no4 = Convert.ToInt32(richTextBox1.Text);
            richTextBox1.Text = ((Math.Log(no4,10))).ToString();
        }

        private void button11_Click(object sender, EventArgs e)
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
      