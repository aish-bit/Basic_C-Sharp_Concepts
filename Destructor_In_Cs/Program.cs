//referecne link : https://www.c-sharpcorner.com/article/understanding-destructors-in-C-Sharp/
//destructor internally override finalize method from Super Object class
//so destructor gets called by gc

using System;

namespace Destructor_In_Cs
{

    class Base
    {
        public Base()
        {
            Console.WriteLine("Inside Base default constructor");
        }

        ~Base() //A Destructor does not accept any parameters and modifiers.
        {
            Console.WriteLine("Inside Basedestructor");
        }
        public virtual void fun()   
        {
            Console.WriteLine("Base fun");
        }

        public void gun()
        {
            Console.WriteLine("Base gun");
        }
    }

    class Derived : Base 
    {

        public Derived()
        {
            Console.WriteLine("Inside Derived default constructor");
        }
        public override void fun() 
        {
            Console.WriteLine("Derived fun");
        }

        public void sun()
        {
            Console.WriteLine("Derived sun");
        }

        ~Derived() //A Destructor does not accept any parameters and modifiers.
        {
            Console.WriteLine("Inside Derived destructor");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Derived dobj = new Derived();

        }
    }
}







    

  

