using System;

namespace Interface_1Interface_extends_anotherInerface
{

    interface Base
    {
        void fun();
    }

    interface Derived : Base  //one interface can extend another interface
    {
        void fun();
    }

    class Demo : Derived //the class who implement interface  need to give definition of both interfaces
    {
        public void fun()
        {
            Console.WriteLine("Inside fun");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Demo dobj = new Demo();
            dobj.fun();
        }
    }
}
