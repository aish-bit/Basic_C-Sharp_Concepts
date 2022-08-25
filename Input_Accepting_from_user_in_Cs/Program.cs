using System;

namespace Input_Accepting_from_user_in_Cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inside main");

            int iNo = 0;
            double dNo = 0.0D;

            Console.WriteLine("Enter number");

            iNo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Value of ino is : " + iNo);

            dNo = Convert.ToDouble (Console.ReadLine());

            Console.WriteLine("Value of dno is : " + dNo);

            Console.ReadKey();

        }
    }
}
