using System;

namespace ThisConcept
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inside main");
            Demo dobj = new Demo();
            dobj.gun();
        }
    }

    class Demo
    {
        public int x, y;

        public Demo()
        {
            //this(10, 20);  //not similar to java we cannot able to call another constructor using this keyword
            Console.WriteLine("Inside default constructor");
        }

        public Demo(int x,int y)
        {
            Console.WriteLine("Inside parameterised constructor");
            this.x = x;     //use (1)
            this.y = y;
        }

        public void fun()
        {
            Console.WriteLine("Demo fun");
            Console.WriteLine("Value of x : " + this.x);
        }

        public void gun()
        {
            Console.WriteLine("Demo gun");
            this.fun();   //use (2)
        }
    }
}
