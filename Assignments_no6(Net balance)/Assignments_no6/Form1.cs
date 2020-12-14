using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignments_no6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Banking b1 = new Banking();
            b1.netBalance = Convert.ToInt32(textBox1.Text);
            
            if (b1.netBalance >= 100000)
            {
                b1.overBalance(b1.netBalance);
            }
            else if(b1.netBalance <= 5000)
            {
                b1.underBalance();
            }
            else
            {
                MessageBox.Show("congraulations you dont have to pay any tax...");
            }
        }
    }
}
