using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication24
{
    class Banking

    {
        int NetBal;
        public int NetBalance { get {return NetBal; } set { NetBal = value; } }

        public void OverBalance(int amount)
        {
           
            if (NetBalance > 100000)
            {
                double tax = amount * 0.18;
                Console.Write("Your tax amount is " + tax);

            }
        }
        public void UnderBalace()
        {
            if (NetBalance < 5000)
            {
                Console.WriteLine(" balance must be maintain as Rs. 5000");
            }
        }
    }
}

