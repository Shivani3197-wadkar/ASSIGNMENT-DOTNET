using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            stack st = new stack();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("\nStack MENU");
                Console.WriteLine("1. Add an element");
                Console.WriteLine("2. Remove top element.");
                Console.WriteLine("3. Display stack elements.");
                Console.WriteLine("4. Reverse stack elements.");
                Console.WriteLine("5. Exit");
                Console.Write("Select your choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter an Element : ");
                        st.Push(Console.ReadLine());
                        break;


                    case 2:
                        Console.WriteLine("Element removed: {0}", st.Pop());
                        break;

                    case 3:
                        st.Display();
                        break;

                    case 4:
                        Console.WriteLine("Enter an Element : ");
                        st.Reverse();
                        break;

                    case 5:
                        System.Environment.Exit(1);
                        break;
                }
                Console.ReadKey();
            }
        }
    }

    interface Stack
    {
        Boolean isEmpty();
        void Push(string element);
        string Pop();
      void Display();
        string Reverse(string item);
    }
    class stack : Stack
    {
        private int StackSize;
        public int StackSizeSet
        {
            get { return StackSize; }
            set { StackSize = value; }
        }
        public int top;
        string[] item;
        public stack()
        {
            StackSizeSet = 10;
            item = new string[StackSizeSet];
            top = -1;
        }
       
        public bool isEmpty()
        {
            if (top == -1) return true;

            return false;
        }
        public void Push(string element)
        {
            if (top == (StackSize - 1))
            {
                Console.WriteLine("Stack is full!");
            }

            else
            {

                item[++top] = element;
                Console.WriteLine("Item pushed successfully!");
            }
        }
        public string Pop()
        {
            if (isEmpty())
            {
                Console.WriteLine("Stack is empty!");
                return "No elements";
            }
            else
            {

                return item[top--];
            }
        }
       


        public void Display()
        {
            for (int i = top; i > -1; i--)
            {

                Console.WriteLine("Item {0}: {1}", (i + 1), item[i]);
            }
            Console.ReadLine();
        }


        public static string Reverse(string item)
        {

            for (var i = item.Length - 1; i >= 0; i--)
            {

                var result = new char[item.Length];
                var j = item.Length - 1;
                foreach (char c in item)
                    result[i--] = c;
                Console.WriteLine("Item {0}: {1}", (i + 1), item[i]);
                return new string(result);
            }
         
        }

    }
}