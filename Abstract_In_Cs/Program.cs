//same as java abstarct concept but while concreting the method we need to override it

using System;

namespace Abstract_In_Cs
{

    abstract class Hello //it proves that abstract class can have zero or more abstarct method in it
    {
        public void fun()
        {
            Console.WriteLine("Inside Hello fun");
        }
    }

    abstract class Base
    {
        public int i, j;

        public Base()
        {
            i = 0;
            j = 0;
        }
        public virtual void fun()  //definition
        {
            Console.WriteLine("Inside Base fun");
        }

        public void gun() //defintion
        {
            Console.WriteLine("Inside Base gun");

        }

        public abstract void sun(); //abstarct method

    }


    class Derived : Base
    {
        public int i, j;

        public Derived()
        {
            i = 0;
            j = 0;
        }
        public override void fun()  //overriden method
        {
            Console.WriteLine("Inside Derived fun");
        }

        public void gun()  //just definition 
        {
            Console.WriteLine("Inside Derived gun");

        }

        public override void sun() //concrete method  //to concrete it we need to override it
        {
            Console.WriteLine("Derived sun");
           //we can also able to give empty definition
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            //Hello hobj = new Hello(); //error cannot create obj of abstract class
            //Base bobj = new Base(); //not allowed
            Base bobj;  //but we can create reference of abstract class
            bobj = new Derived();

            bobj.fun(); //derived fun
            bobj.gun(); //base gun
            bobj.sun(); //derived sun

            Derived dobj = new Derived();
            dobj.sun(); //derived sun

            
        }
    }
}
