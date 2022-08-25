using System;



// he general rules for naming variables are:
// Names can contain letters, digits and the underscore character (_)
// Names must begin with a letter
// Names should start with a lowercase letter and it cannot contain whitespace
// Names are case sensitive ("myVar" and "myvar" are different variables)
// Reserved words (like C# keywords, such as int or double) cannot be used as names
//constant variable must be define at the time of creation only
//constant value cannot be incremented or decremented or modified


namespace Create_Variables_In_Cs
{
   
    class CreateVariable
    {
        public static void Main()
        {
            //Creating Variables: 

            int a = 10, y = 20, z = 30;
            Console.WriteLine("Value of int a: " + a);

            float b = 10.10F;
            Console.WriteLine("Value of float b: " + b);

            double p = 10.10D;
            Console.WriteLine("Value of double p: " + p);

            char ch = 'M';
            Console.WriteLine("Value of char ch: " + ch);

            bool bRet = true;
            Console.WriteLine("Value of bool bRet: " + bRet);

            string name = "Aishwarya Karande";
            Console.WriteLine("Value stored in string is: " + name);

            string fname = "Piyush";
            string lname = "Khairnar";
            string name1 = fname + lname;
            Console.WriteLine("Value stored in string is: " + name1);


            int i;
            i = 11;
            Console.WriteLine("Value of int i: " + i);

            int j;
            j = 11;
            j = 21;
            Console.WriteLine("Value of int j: " + j);
            j++;
            Console.WriteLine("Value of int j: " + j);
            ++j;
            Console.WriteLine("Value of int j: " + j);

            //Contsant :

            const int x = 101;
            // const int x; //not allowed constant variable must be define at the time of creation only
            //  x = 101;
            // x = 151;
            Console.WriteLine("Value of int x: " + x);
            // x++;
            // Console.WriteLine("Value of int x: "+x);

        }
    }
}
