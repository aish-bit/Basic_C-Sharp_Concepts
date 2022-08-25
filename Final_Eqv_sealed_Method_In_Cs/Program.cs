


using System;

namespace Final_Eqv_sealed_Method_In_Cs
{
    class Base
    {
        public virtual void fun() 
        {
            Console.WriteLine("Inside Base fun");
        }

        //public sealed virtual void gun()   //you cannot sealed beacuse it is not overrided
        //{
        //    Console.WriteLine("Base gun");
        //}

        public virtual void sun()
        {
            Console.WriteLine("Inside Base sun");
        }

    }


    class Derived : Base
    {
        public override sealed void fun()  //only overriden method gets sealed
        {
            Console.WriteLine("Inside Derived fun");
        }


        public override void sun() 
        {
            Console.WriteLine("Inside Derived sun");
        }
    }


    class MyDerived : Derived
    {
        public void run()
        {
            Console.WriteLine("Inside Myderived run");
        }

        //public  override void fun()  //cannot override derived fun beacuse it is sealed
        //{

        //}

        public override void sun() //but you can override derived overriden sun
        {
            Console.WriteLine("Inside MyDerived sun");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Base bp = new  MyDerived();

            bp.sun();
        }
    }
}
