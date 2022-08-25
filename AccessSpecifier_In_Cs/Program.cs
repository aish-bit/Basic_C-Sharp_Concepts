//Irrespective of access specifier memory for all clasees get allocated

//C# provides five types of access specifiers.

//Public    //same as c++ and java
//Protected     //same as c++ and java
//Private  //same as c++ and java

//Internal   
/*The internal access specifier hides its member variables and methods from other classes and objects, 
 that is resides in other namespace.The variable or classes that are declared with internal can be access 
 by any member within application.It is the default access specifiers for a class in C# programming */

//Protected internal


using System;

namespace AccessSpecifier_In_Cs
{
    class Base
{
    public int a; //accessible to anywhere
    private int b; //only accessible inside this class 
    protected int c; //accessible only inside intermediate derived class
    internal int d;

    public Base(int a,int b,int c,int d)
    {
        this.a = a;
        this.b = b;
        this.c = c;
        this.d = d;
    }

    public int accessPrivate()
    {
        return b;
    }
}

class Derived : Base
{
    public int x;

    public Derived(int x,int y,int z,int w,int r) : base(y,z,w,r)
    {
        this.x = x;
    }

    public void display()
    {
        Console.WriteLine("Value of a : "+a);
        //Console.WriteLine("Value of b : "+b); // error you cannot acces private characteritics of other class directly
        Console.WriteLine("Value of c : "+c); //you can access protected characteristics in  derived class
        int iRet = base.accessPrivate();
        Console.WriteLine("Value of b : " + iRet); //so you can access private characteristics of base class by call by value method
       //but there are some method available in base class who will return it
    }
    
        internal void fun() 
        {
            Console.WriteLine("Inside Base fun");
        }


}



class MyDerived : Derived
{
    public MyDerived(int y, int z, int w,int r,int s) : base(y, z, w,r,s)
    {
    }

    public void display()
    {
        Console.WriteLine("Value of a : " + a); //accessible anywhere
        //Console.WriteLine("Value of b : "+b); // error you cannot acces private characteritics of other class directly
        Console.WriteLine("Value of c : " + c); //you can access protected characteristics in  derived class
        base.display(); //call to derived class display method
           Console.WriteLine("Value of d : " + d); //accessible within namespace
        }
}


    class Program
    {
        static void Main(string[] args)
        {
            MyDerived mobj = new MyDerived(10, 20, 30, 40, 50);

            Console.WriteLine("Value of a : " + mobj.a);  //accessible anywhere
            // Console.WriteLine("Value of a : " + mobj.b);  //not allowed 
            // Console.WriteLine("Value of a : " + mobj.c);  //not allowed 
            Console.WriteLine("Value of d : " + mobj.d);  //accessible inside this namespace only

            mobj.display();

            mobj.fun();

          
            
        }
    }

}


