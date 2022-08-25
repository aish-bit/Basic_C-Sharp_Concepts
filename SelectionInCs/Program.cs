using System;

namespace SelectionInCs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inside main");

            //if else if same as C,C++ and Java
            int age = 0;

            Console.WriteLine("Enter your age");
            age = Convert.ToInt32(Console.ReadLine());

            if(age < 0)
            {
                age = -age;
            }

            if (age <= 95)
            {
                if (age < 18)
                {
                    Console.WriteLine("Sorry,you cannot drive");
                }
                else if (age >= 18 && age < 60)
                {
                    Console.WriteLine("You can drive");
                }
                else
                {
                    Console.WriteLine("Drive safely");
                }
            }
            else
            {
                Console.WriteLine("Dont drive.Take care of your health");
            }



            //switch case same as java
            int standard = 0;
            Console.WriteLine("Enter your standard to know exam schedule");
            standard = Convert.ToInt32(Console.ReadLine());

            if(standard < 0)
            {
                standard = -standard;
            }

            switch(standard)
            {
                case 1:
                    Console.WriteLine("Your exam is at 10 am");
                    break;

                case 2:
                    Console.WriteLine("Your exam is at 11 am");
                    break;
                case 3:
                    Console.WriteLine("Your exam is at 12 pm");
                    break;
                case 4:
                    Console.WriteLine("Your exam is at 1 pm");
                    break;
                default:
                    Console.WriteLine("There is no such standard");
                    break;  //unlike java and c we need to give break after default also
            }

            Console.ReadKey();
        }
    }
}
