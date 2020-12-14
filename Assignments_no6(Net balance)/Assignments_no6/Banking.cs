using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignments_no6
{
    class Banking
    {
        int netbalance;

        public int netBalance
        {
            get { return netbalance; }
            set { netbalance = value; }
        }

       public void overBalance(int amount)
        {
            double tax = amount * 0.18;
            MessageBox.Show("Your tax amount is " + tax);
        }
       public void underBalance()
        {
            MessageBox.Show("please maintain minimum balance up to 5000");
        }
    }
}
