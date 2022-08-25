

//there is no implement keyword in c#
//if you want to implement then use same : for both inheritacne and implementation 
//interface is like blue print of class
//all methods in interface are by default public and abstract
//but in case of interface while giving definition of abstract methods you dont need to override it...simply provide definition
//interface dont contain characteristics in it

using System;

namespace Interface_1class_multiple_interface_In_Cs
{

    interface Hello1
    {
        // float PI = 3.14F; //interface dont contain characteristics
        void fun(); //by default public and abstarct
        void gun();
    }

    interface Hello2
    {
        // float PI = 3.14F; //interface dont contain characteristics
        void fun(); //by default public and abstarct
        void fun(int iNo); 
    }

    class Demo : Hello1,Hello2 //one class can implement more than one interfaces
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

        public void fun(int iNo) //concrete method
        {
            Console.WriteLine("Inside fun 2");
        }

        public void gun() //concrete method
        {
            Console.WriteLine("Inside gun");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Demo dobj = new Demo();
            dobj.fun(); //doghanmdhlya fun la same ch definition milel i think
            dobj.fun(10);
            dobj.gun();
           // dobj.pi++; //not allowed
        }
    }
}

