
// C# Type Casting
// Type casting is when you assign a value of one data type to another type.

// In C#, there are two types of casting:

// Implicit Casting (automatically) - converting a smaller type to a larger type size
// char -> int -> long -> float -> double

// Explicit Casting (manually) - converting a larger type to a smaller size type
// double -> float -> long -> int -> char

using System;

namespace Typecasting_In_Cs
{
    class typecasting
    {
        static void Main()
        {
            //Implicit typecasting
            int i1 = 10;
            double d1 = i1;

            Console.WriteLine(i1); //10
            Console.WriteLine(d1); //10

            //explicit typecasting
            double d2 = 11.11D;
            int i2 = (int)d2;

            Console.WriteLine(i2); //11
            Console.WriteLine(d2); //11.11

            //Type Conversion Methods
            // It is also possible to convert data types explicitly by using built-in methods, such as Convert.ToBoolean, Convert.ToDouble, Convert.ToString, Convert.ToInt32 (int) and Convert.ToInt64 (long):

            int i3 = 11;
            double d3 = 11.11D;
            bool b1 = true;

            Console.WriteLine(Convert.ToString(i3));
            Console.WriteLine(Convert.ToDouble(i3));
            Console.WriteLine(Convert.ToInt32(d3));
            Console.WriteLine(Convert.ToString(b1));

        }
    }
}