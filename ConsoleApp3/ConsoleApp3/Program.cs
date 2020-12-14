using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApp3
{

    class Program
    {
        class Bank
        {
            float Netbalance;
            float Tranamount;
            public Bank()

            {
                
                Console.WriteLine("Value of Netbalance ");
                Netbalance = float.Parse(Console.ReadLine());

                Console.WriteLine("value of Tranamount");
                Tranamount = float.Parse(Console.ReadLine());
            }

            void Deposit()
            {
               Netbalance = Netbalance + Tranamount;
                Console.WriteLine("Deposit:" + Netbalance);
            }

            void Withdrawal()
            {
                Tranamount = Netbalance - Tranamount;
                Console.WriteLine("withdrawal:" + Tranamount);
            }

            static void Main(string[] args)
            {
                Bank b = new Bank();

                Thread t1 = new Thread(b.Deposit);
                t1.Start();
                Thread t2 = new Thread(b.Withdrawal);
                t2.Start();
                t1.Join();
                t2.Join();
             


            }
        }
    }
}
