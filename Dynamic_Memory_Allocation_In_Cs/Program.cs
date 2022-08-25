using System;

namespace Dynamic_Memory_Allocation_In_Cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Demo dobj = new Demo();   //same as java and automatic garbage collection

            dobj.fun();

            Console.ReadKey();
        }
    }


    class Demo
    {
        public int x, y;

        public Demo()
        {
            Console.WriteLine("Inside default constructor");
            x = 0;
            y = 0;
        }

        public void fun()
        {
            Console.WriteLine("Inside fun");
        }
    }


}
