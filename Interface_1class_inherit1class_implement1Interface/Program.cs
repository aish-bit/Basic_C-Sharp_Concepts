

//there is no implement keyword in c#
//if you want to implement then use same : for both inheritacne and implementation 
//interface is like blue print of class
//all methods in interface are by default public and abstract
//but in case of interface while giving definition of abstract methods you dont need to override it...simply provide definition
//interface dont contain characteristics in it

using System;

namespace Interface_1class_inherit1class_implement1Interface
{

    interface Hello1
    {
        // float PI = 3.14F; //interface dont contain characteristics
        void fun(); //by default public and abstarct
    }

    interface Hello3
    {
        // float PI = 3.14F; //interface dont contain characteristics
        void fun(); //by default public and abstarct
    }

    class Hello2
    {
        public void gun() 
        {
            Console.WriteLine("Inside Hello2 gun");
        }
    }

    class Demo : Hello2, Hello1,Hello3 //one class can extend one class and implement multiple interfaces
        //sequence bhayankar matter krte ..adhi extend mg implement karaych
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
            dobj.fun(); //doghanmdhlya fun la same ch definition milel i think
            dobj.gun(); //Hello2 gun
            // dobj.pi++; //not allowed
        }
    }
}


