using System;

namespace Final_Eqv_sealed_characteristics_In_Cs
{
    //to make a characteristic constant dont use sealed keyword...its not made for this
    //instead use readonly keyword to do so..
    //const keyword is used in case of local variables

    class Demo
    {
        //public sealed int i = 10; //there is no such concept of sealed chara in c#

        public const int i = 10; //its not get considered as a characteristics of class

        public readonly int j; //(2)
        public Demo()  
        {
            j = 20;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inside main");

            //to make local variable constant
            //sealed int x = 10; //error local variables cant be sealed
            const int x = 10;

            //x++; //not allowed

            Demo dobj = new Demo();

            Console.WriteLine("const i : " + dobj.j);

           // dobj.j++; //error

        }
    }
}
