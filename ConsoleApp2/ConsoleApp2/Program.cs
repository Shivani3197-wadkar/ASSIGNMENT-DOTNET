using ConsoleApp2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
   //Protected virtual class



        //    class baseClass
        //    {

        //        protected virtual void show()
        //        {
        //             Console.WriteLine("Base class");
        //        }
        //    }
        
        //    class derived : baseClass
        //    {
            
        //        public void show1()
        //         {
        //            Console.WriteLine("Derived class");
        //        }
        //    }

        //    class main
        //    {
        //    public static void Main()
        //    {

        //        derived obj;
        //        obj = new derived();
        //        obj.show1();
        //        obj.show();

        //}
        //}

    abstract class baseClass
    {
        protected float L, B; 
         protected abstract float area();
      
        
    }


    class derived : baseClass
    {
        public void GetLB()
        {
            Console.Write("Enter  Length  :  ");

            L = float.Parse(Console.ReadLine());

            Console.Write("Enter Breadth : ");

            B = float.Parse(Console.ReadLine());
        }

        protected override float area()
        {
            Console.WriteLine("Derived class");
            return L * B;
        }
    }
    //class Sub3 : baseClass
    //    {
    //        public override void calculate(double x)
    //        {
    //            Console.WriteLine("CUBE is :" + (x * x * x));
    //        }
    //    }
    }

class main:derived
{

    public static void Calculate(baseClass S)
    {

        Console.WriteLine("Area :", S.area());
    }
    public static void Main()
    {
        derived obj = new derived();
        obj.GetLB();
       Calculate(obj);
    }

}
    


