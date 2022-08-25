//there is no implement keyword in c#
//if you want to implement then use same : for both inheritacne and implementation 
//interface is like blue print of class
//all methods in interface are by default public and abstract
//but in case of interface while giving definition of abstract methods you dont need to override it...simply provide definition
//interface dont contain characteristics in it

using System;

namespace Interface_1class_implement_1interface_In_Cs
{

    interface Hello
    {
       // float PI = 3.14F; //interface dont contain characteristics
        void fun(); //by default public and abstarct
    }

    class Demo : Hello //same syntax for inheritance as well as implementation
    {
        public readonly float pi;

        public Demo()
        {
            pi = 3.14F;
        }

        public void fun() //concrete method
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
