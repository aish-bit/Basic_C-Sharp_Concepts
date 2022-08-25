//exact similar to final class in java

using System;

namespace Final_Eqv_sealed_Class_In_cs
{

    sealed class Base
    {
        public int i;

        public Base()
        {
            i = 10;
        }

        public void fun()
        {
            Console.WriteLine("Base fun");
        }
    }

    ///////////////////////////////////////////////////////////////////////////

    //class Derived : Base { } //sealed class cannot be inherited same as final class in java

    ///////////////////////////////////////////////////////////////////////////
    //bhurta.....
    //pan rule todaycha ch ahe tr ha ha haaa..........I will use concept of composition..!!!
    //tula ky watle tula dyaych nhi tr mla gheta yenar nhi ka....
    class Derived
    {
        public Base bobj; //composition : create object of sealed class as a non static characteristic of class

        public Derived()
        {
            bobj = new Base();
        }

        public void gun()
        {
            bobj.fun();
        }

        public void fun()  //not overriden as Derived is not inherited from Base.Both classes are still different
            //base cha fun cha ani yacha laaaamb prynt sambandh nhi
        {
            Console.WriteLine("Derived fun");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Base bobj = new Base(); //we cant inherit sealed class but we can make its individual object and use it

            bobj.fun();

            Derived dobj = new Derived();
            dobj.gun();
            dobj.fun();

        }
    }
}
