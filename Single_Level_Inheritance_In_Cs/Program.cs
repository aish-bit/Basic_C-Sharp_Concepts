using System;

namespace Single_Level_Inheritance_In_Cs
{

    class Base1
    {
        public int x, y;

        public Base1()
        {
            Console.WriteLine("Inside default constructor of Base1 class");
            this.x = 10;
            this.y = 20;
        }

        public void fun()
        {
            Console.WriteLine("Base1 fun");
        }
    }

    class Derived1 : Base1 //single level inheritance
    {
        public int x, y;

        public Derived1()
        {
            Console.WriteLine("Inside default constructor of Derived1 class");
            this.x = 30;
            this.y = 40;
        }



        public void gun()
        {
            Console.WriteLine("Inside Derived1 gun");
        }

    }

    /// ///////////////////////////////////////////////////////////////////////////
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inside main");

            Derived1 dobj1 = new Derived1();
            dobj1.fun();
            dobj1.gun();
        }
    }
}
