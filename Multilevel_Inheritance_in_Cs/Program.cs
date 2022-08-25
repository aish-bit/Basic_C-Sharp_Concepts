//inheritance in c# is similar to java extactly
//here also we have single and multi level inheritance only
//"like java c# also not supports multiple inheritance"
//bt like java ha apn bhurta swataha atlya aat multiple inheritance implement krto
//like java ithe hi object class ahe jo super class sarkha work krto. sagle class ya class pasun inherit zalele ahet


using System;

namespace Single_Level_Inheritance_In_Cs
{

    class Base1
    {
        public int x, y;

        public Base1()
        {
            Console.WriteLine("Inside default constructor of Base1 class");
            this.x = 10;
            this.y = 20;
        }

        public void fun()
        {
            Console.WriteLine("Base1 fun");
        }
    }

    class Derived1 : Base1 //single level inheritance
    {
        public int x, y;

        public Derived1(int x,int y)
        {
            Console.WriteLine("Inside parameterised constructor of Derived1 class");
            this.x = x;
            this.y = y;
        }



        public void gun()
        {
            Console.WriteLine("Inside Derived1 gun");
        }

    }

    class MyDerived1 :Derived1 //multi level inheritance
    {
        public int x, y;

        public MyDerived1(int x, int y,int w,int z) : base(w,z) //explicit call to derived1 constructor
        {
            Console.WriteLine("Inside parameterised constructor of MyDerived1 class");
            this.x = x;
            this.y = y;
        }



        public void sun()
        {
            Console.WriteLine("Inside MyDerived1 sun");
        }

    }

    /// ///////////////////////////////////////////////////////////////////////////
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inside main");

            MyDerived1 dobj1 = new MyDerived1(11,21,51,101);
            dobj1.fun();
            dobj1.gun();
            dobj1.sun();
        }
    }
}
