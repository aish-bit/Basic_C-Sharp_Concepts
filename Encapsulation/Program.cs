using System;

namespace Encapsulation //binding characteristics and behaviour together
    //this also clear static and non static characteristics ans behaviour concept of class
{

    class Demo
    {
        static public int no;  //static characteristic of class
        public int x, y;        //non static characteristics of class

        //public static Demo(int i) //does not take parameter as well access specifier
        static Demo()  //static constructor of class
        {
            no = 51;
        }

        public Demo() //default constructor
        {
            this.x = 10;
            this.y = 20;
        }
        public void fun()  //non static behaviour
        {
            Console.WriteLine("Inside non static behaviour fun");
            Console.WriteLine("you can access static char in non static method"+no); //you can access static char in non static method
        }

        public static void gun()  //static behaviour
        {
            Console.WriteLine("Inside static behaviour gun");
            Console.WriteLine("you can access static char in non static method"+no); //you can access static char in non static method
            //Console.WriteLine("you cannot access non static char in non static method"+x); //you cannot access non static char in non static method
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("static char of class: " + Demo.no); //we can access by class name also as well without creating obj of class
            Demo.gun();  //static behaviour. We can call by class name also as well without creating obj of class
           
            Demo dobj = new Demo();

            //Console.WriteLine("static char of class: " + dobj.no); //Unlike java you cannot access with object name 
            //dobj.gun(); //Unlike java you cannot access with object name 

            Console.WriteLine("non static char of class: " + dobj.x); //access using class name

            dobj.fun();


            Console.ReadKey();
        }
    }
}
