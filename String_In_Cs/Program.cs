using System;

namespace String_In_Cs
{
    class String
    {
        static void Main()
        {
            string name = "   Aishwarya Karande   ";
            Console.WriteLine($"Hello {name}"); //string interpolation
            Console.WriteLine("Length of string is: " + name.Length);
            Console.WriteLine("name is: [" + name + "]");

            string trimmedString = name.TrimStart();
            Console.WriteLine("name is: [" + trimmedString + "]");

            trimmedString = name.TrimEnd();
            Console.WriteLine("name is: [" + trimmedString + "]");

            trimmedString = name.Trim();
            Console.WriteLine("name is: [" + trimmedString + "]");
            //The methods that manipulate strings return new string objects rather than making modifications in place. You can see that each call to any of the Trim methods returns a new string but doesn't change the original message.

            string name2 = "Aishwarya Karande";
            Console.WriteLine(name2);
            name2 = name2.Replace("Aishwarya", "Shardul"); //modification happened in same string 
            Console.WriteLine(name2);

            Console.WriteLine(name2.ToUpper());
            Console.WriteLine(name2.ToLower());
            Console.WriteLine(name2);   //main string is Shardul Karande even if we do lower case here but we didnt assign it to main string

            name2 = name2.ToUpper();
            Console.WriteLine(name2);

            string songLyrics = "check the time its half pass six,watch the sunset bit by bit...think about what we will could do..dinner date with candles lit..there is something I must confess...cant be sure you will accept..but babe...do you want to come with me and we will live our best...boy your smile is miles away..and without you I wont be okay..till the end of our time,World will be fine,say you will be mine..I know that you are the one for me..you know that you are the one for me..loving you never tested so sweet..with you forever and ever...!!";
            Console.WriteLine(songLyrics.Contains("loving"));
            Console.WriteLine(songLyrics.Contains("Loving"));
            Console.WriteLine(songLyrics.StartsWith("check"));
            Console.WriteLine(songLyrics.StartsWith("dinner"));
            Console.WriteLine(songLyrics.EndsWith("!"));
            Console.WriteLine(songLyrics.EndsWith("check"));

        }
    }
}


//Hello Aishwarya Karande
// Length of string is: 23
// name is: [   Aishwarya Karande   ]
// name is: [Aishwarya Karande   ]
// name is: [   Aishwarya Karande]
// name is: [Aishwarya Karande]
// Aishwarya Karande
// Shardul Karande
// SHARDUL KARANDE
// shardul karande
// Shardul Karande
// SHARDUL KARANDE
// True
// False
// True
// False
// True
// False
