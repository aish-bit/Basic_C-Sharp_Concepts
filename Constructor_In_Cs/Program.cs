using System;

namespace Constructor_In_Cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inside main");

            Demo dobj1 = new Demo();
            Demo dobj2 = new Demo(30,40);
            Demo dobj3 = new Demo(dobj1);

            Console.WriteLine(dobj3.x); //deep copy
            
        }
    }
    
    class Demo
    {
        public static int no;
        public int x, y;

        public Demo() //default constructor
        {
            Console.WriteLine("inside default constructor");
            x = 10;
            y = 20;
        }

        public Demo(int x, int y) //parameterised constructor
        {
            Console.WriteLine("inside parameterised constructor");
            this.x = x;
            this.y = y;
        }

        static Demo() //static constructor //no access specifier as well as no input parameters are allowed
            //used to initialise static characteristics of class
        {
            Console.WriteLine("inside static constructor");
            no = 51;
        }

        public Demo(Demo obj)  //copy constructor
        {
            Console.WriteLine("inside copy constructor");
            this.x = obj.x;
            this.y = obj.y;
        }

        //private Demo() //private constructor
        //{
        //      //if the constructor is private we cannot able to create obj of class
        //      //it is used when we dont want to create instance of class
        //      //in that case if you want to use functionality of class then 
        //      //-all make all methods and characteristics of class static so without 
        //      //creating object of class we can able to access its functionality
        //}
    }
}
