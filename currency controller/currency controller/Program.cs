﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace currency_controller
{
    class Program
    {
        static void Main(string[] args)
        {
            Double no, inr, val;
            int choice;

            while (true)
            {
                Console.WriteLine("Enter your Choice :\n 1- Dollar to Rupee \n 2 - Chinese yuan to Rupee " +
                    "\n 3 - Malaysian Ringgit to Rupee \n 4- Japneses yen to Rupee \n 5- Bitcoin  to Rupee" +
                    "\n 6- Litecoin to Rupee \n 7- Ether to Rupee \n 8- Egyptian Pound to Rupee \n 9- Iranian Rial to Rupee" +
                    "\n 10- Mexican Peso to Rupee");
                Console.WriteLine("Choose the currency to be converted into INR");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:

                        // how many dpllars
                        Console.WriteLine("Enter amount to be converted");
                        no = Convert.ToDouble(Console.ReadLine()); ;
                        // current value of US$
                        val = 69;
                        inr = no * val;
                        Console.WriteLine("{0} Dollar = {1} INR", no, inr);
                        Console.ReadLine();
                        break;

                    case 2:
                        
                        Console.WriteLine("Enter amount to be converted");
                        no = Convert.ToDouble(Console.ReadLine()); ;

                        val = 11.22;
                        inr = no * val;
                        Console.WriteLine("{0} Chinese yuan = {1} INR", no, inr);
                        Console.ReadLine();
                        break;

                    case 3:
                        Console.WriteLine("Enter amount to be converted");
                        no = Convert.ToDouble(Console.ReadLine()); ;

                        val = 18.22;
                        inr = no * val;
                        Console.WriteLine("{0} Malaysian Ringgit = {1} INR", no, inr);
                        Console.ReadLine();
                        break;

                    case 4:
                        Console.WriteLine("Enter amount to be converted");
                        no = Convert.ToDouble(Console.ReadLine()); ;

                        val = 0.70;
                        inr = no * val;
                        Console.WriteLine("{0} Japneses yen = {1} INR", no, inr);
                        Console.ReadLine();
                        break;
                    case 5:
                        Console.WriteLine("Enter amount to be converted");
                        no = Convert.ToDouble(Console.ReadLine()); ;

                        val = 1390871.19;
                        inr = no * val;
                        Console.WriteLine("{0} Bitcoin  = {1} INR", no, inr);
                        Console.ReadLine();
                        break;
                    case 6:
                        Console.WriteLine("Enter amount to be converted");
                        no = Convert.ToDouble(Console.ReadLine()); ;

                        val = 6523.39;
                        inr = no * val;
                        Console.WriteLine("{0} Litecoin = {1} INR", no, inr);
                        Console.ReadLine();
                        break;
                    case 7:
                        Console.WriteLine("Enter amount to be converted");
                        no = Convert.ToDouble(Console.ReadLine()); ;

                        val = 43584.32;
                        inr = no * val;
                        Console.WriteLine("{0}  Ether = {1} INR", no, inr);
                        Console.ReadLine();
                        break;
                    case 8:
                        Console.WriteLine("Enter amount to be converted");
                        no = Convert.ToDouble(Console.ReadLine()); ;

                        val = 4.70;
                        inr = no * val;
                        Console.WriteLine("{0} Egyptian Pound = {1} INR", no, inr);
                        Console.ReadLine();
                        break;
                    case 9:
                        Console.WriteLine("Enter amount to be converted");
                        no = Convert.ToDouble(Console.ReadLine()); ;

                        val = 0.0017;
                        inr = no * val;
                        Console.WriteLine("{0} Iranian Rial = {1} INR", no, inr);
                        Console.ReadLine();
                        break;
                    case 10:
                        Console.WriteLine("Enter amount to be converted");
                        no = Convert.ToDouble(Console.ReadLine()); ;

                        val = 3.68;
                        inr = no * val;
                        Console.WriteLine("{0} Mexican Peso = {1} INR", no, inr);
                        Console.ReadLine();
                        break;

                    default:
                        break;

                }
            }
        }
        
    }
}
