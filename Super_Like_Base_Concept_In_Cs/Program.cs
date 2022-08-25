using System;

namespace Super_Like_Base_Concept_In_Cs
{
  
    /// ///////////////////////////////////////////////////////////////////////////
   
    //In case if base class contains parameterised construtor
    class Base
    {
        public int x, y;

        public Base(int x,int y)
        {
            Console.WriteLine("Inside parameterised constructor of Base class");
            this.x = x;
            this.y = y;
        }

        public void fun()
        {
            Console.WriteLine("Base fun");
        }
    }

    class Derived : Base
    {
        public int x, y;
        
        public Derived(int x, int y,int w,int z) : base(w,z) //use (1) explicit calling of parameterised constructor of base class
        {
            Console.WriteLine("Inside parameterised constructor of Derived class");
            this.x = x;
            this.y = y;
        }

       

        public void gun()
        {
            Console.WriteLine("Inside Derived gun");
            Console.WriteLine("Value of x from derived class"+this.x);
            Console.WriteLine("Value of x from base class"+base.x);  //use (3) calling base class char using base keyword
            base.fun(); //use (2) calling base class method using base keyword
        }

    }

    /// ////////////////////////////////////////////////////////////////////////////// 


   
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inside main");
            Derived dobj = new Derived(10, 20, 30, 40);
            dobj.gun();

           
        }
    }
}
