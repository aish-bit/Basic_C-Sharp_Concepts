using System;

//namespace and calss name is allowed to be same
/*class and its method name should not be same*/
//if two same clases are available then namespace helps to seperate out 

// or /**/ => This instructs the compiler to ignore all the instructions on that line.

namespace Namespace_In_Cs
{
    class BaseNamespace
    {
        public static void Main(String[] str)
        {
            Console.Write("Hey,");
            Console.WriteLine("Hello DemoNamespace");
            string name = "Aishwarya";
            Console.WriteLine($"Hello {name}"); //string interpolation
            Console.WriteLine("Length of string is: " + name.Length); //here L is capital and no ()

            Hello.Hello hobj = new Hello.Hello();
            second.Welcome wobj = new second.Welcome();
            hobj.SayHello();
            wobj.SayWelcome();
            Third.Hello tobj = new Third.Hello();
            tobj.SayHello();
        }
    }
}

namespace Hello
{
    class Hello
    {
        public void SayHello()
        {
            Console.WriteLine("Inside Hello");
        }
    }
}

namespace second
{
    class Welcome
    {
        public void SayWelcome()
        {
            Console.WriteLine("Inside Welcome");
        }
    }
}

namespace Third
{
    class Hello
    {
        public void SayHello()
        {
            Console.WriteLine("Inside Hello");
        }
    }
}


