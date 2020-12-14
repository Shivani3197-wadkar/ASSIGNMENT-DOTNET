using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        

        static void Main(string[] args)
        {
            String[] name = new string[]{ "shivani", "Megha", "Poonam", "Xyz", "Ywx" };
           
            for (int i = 0; i <name.Length; i++)
            {
                if (name[i].Length % 2 == 0)
                {
                    Console.WriteLine("String is even"+ name[i]);
                }
                else
                {
                    //for (int j = 0; j < name.Length; j++)
                    //{
                        if (name[i].Contains('a'))
                        {
                            Console.WriteLine("String is odd");
                            Console.WriteLine("string containing 'a' letter is:" + name[i]);
                        }
                    //}
                }
            }
    
                Console.Read();
        }
    }
}
