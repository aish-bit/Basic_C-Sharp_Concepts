using System;

namespace MethodOverriding_RunTImePolymorphism_In_Cs
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
        public virtual void fun()  //(1)9mention virtual word in function prototype if you want to override it) 
        {
            Console.WriteLine("Base fun");
        }

        public void gun()
        {
            Console.WriteLine("Base gun");
        }
    }

    class Derived : Base //(3)Inheritance
    {

        public Derived()
        {
            Console.WriteLine("Inside Derived default constructor");
        }
        public override void fun() //(2)to make if overriden method mention override word in it
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

    class Virtual
    {
        static void Main(string[] args)
        {
            Base bp = new Derived();   //(4)upcasting
            bp.fun();
            bp.gun();
            //bp.sun(); //not allowed
        }
    }
}
