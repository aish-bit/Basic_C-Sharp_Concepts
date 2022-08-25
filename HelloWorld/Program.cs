using System;
using System.IO;
using System.Text;

namespace HelloWorld
{
    class Program
    {

        static void greet()
        {
            Console.WriteLine("Nice to meet you");
        }

        //method overloading
        static float Average(int a,int b,int c)
        {
            float sum = a + b + c;
            return sum / 3;
        }

        static float Average(int a, int b)
        {
            float sum = a + b;
            return sum / 3;
        }

        static void Main(string[] args)
        {

            ///////////////////////////////////////////////////////////////////////////////////////////////
            //greet();
            //float fRet = 0.0F;
            //fRet = Average(3, 3, 3);
            //Console.WriteLine("Avg is : " + fRet);
            //fRet = Average(3, 9);
            //Console.WriteLine("Avg is : " + fRet);

            Player pobj1 = new Player("Sachin", 50);
            Player pobj2 = new Player("Dhoni", 40);

            pobj1.Display();
            pobj2.Display();

            ///////////////////////////////////////////////////////////////////////////////////////////////
            //this is comment
            /*
            This is multiline comment.
             */

            //int iNo = 34;


            //Console.WriteLine("sizeof(char)     : {0}", sizeof(char));
            //Console.WriteLine("sizeof(byte)     : {0}", sizeof(byte));
            //Console.WriteLine("sizeof(sbyte)    : {0}", sizeof(sbyte));
            //Console.WriteLine("sizeof(float)    : {0}", sizeof(float));
            //Console.WriteLine("sizeof(ushort)   : {0}", sizeof(ushort));
            //Console.WriteLine("sizeof(double)   : {0}", sizeof(double));
            //Console.WriteLine("sizeof(int)      : {0}", sizeof(int));
            //Console.WriteLine("sizeof(bool)     : {0}", sizeof(bool));
            //Console.WriteLine("sizeof(short)    : {0}", sizeof(short));
            //Console.WriteLine("sizeof(decimal)    : {0}", sizeof(decimal));
            //Console.WriteLine("sizeof(long)    : {0}", sizeof(long));
            //// Console.WriteLine("sizeof(void)    : {0}", sizeof(void));
            //Console.WriteLine("sizeof(bool)    : {0}", sizeof(bool));

            //float fNo = 11.11F;
            //double dNo = 11.11D;
            //bool bRet = false;
            // Console.WriteLine("Bool : " + bRet);
            // char ch = 'M';
            // string str = "Aishwarya Karande";

            // Console.WriteLine("The number is : " + iNo);
            //Console.WriteLine("Hello World!");
            //Console.Write("Hello Aishwarya!");
            //Console.WriteLine("I love c#!");

            //Console.WriteLine("Enter string : ");
            //string str1 = Console.ReadLine();
            //Console.WriteLine("The input string from user is : " + str1);

            //typecasting : 
            //implicit casting - char to int to long to float to double

            //int a = (int) 3.5;  //explicit casting
            //double a1 = (double) 3.5F;  //explicit casting
            //Console.WriteLine(a);
            //Console.WriteLine(a1);


            //double d = a; //implicit casting
            //Console.WriteLine(d);

            //int z = 'y';
            //Console.WriteLine(z);

            ////Inbuilt methods for typecasting
            //float varr = Convert.ToInt32(3.55);
            //Console.WriteLine(varr);

            //Console.WriteLine("Enter Number : ");
            //int no = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("no+4 is : " + (no+4));

            //arithmetic operators : + - / *
            //assignment operators : =   +=  -=  /=  *=
            //int v = 3;
            //int y = v;
            //Console.WriteLine(y);
            //y += 4;
            //Console.WriteLine(y);

            //logical operator : && ||  ! (not operator = change true->false and false->true) 

            //comparison operators : > < >= <= != ==

            //there is max class here which has some inbuilt function

            //int z = Math.Max(11, 21);
            //Console.WriteLine(z);

            //double f = Math.Sqrt(36);
            //Console.WriteLine(f);

            //int g = Math.Abs(-51);  //make positive value
            //Console.WriteLine(g);


            //string str2 = "Marvellous";
            //Console.WriteLine(str2.Length);
            //Console.WriteLine(str2.ToUpper());
            //Console.WriteLine(str2.ToLower());
            //Console.WriteLine(string.Concat(str2, " Infosysytem"));

            //string name = Console.ReadLine();
            //string candies = Console.ReadLine();

            //Console.WriteLine($"The person with name {name} will get {candies} candies."); //String interpolation

            //string str2 = "Mar \n vello \" us"; //indexed char array
            //Console.WriteLine(str2[9]);
            //Console.WriteLine(str2.IndexOf('s'));
            //Console.WriteLine(str2.IndexOf("llous"));
            //Console.WriteLine(str2.Substring(1));

            //Console.WriteLine("Please enter your age");
            //int age = Convert.ToInt32(Console.ReadLine());


            //if(age > 18)
            //{
            //    Console.WriteLine("You can drive");
            //}
            //else if(age <10)
            //{
            //    Console.WriteLine("Complete your high school first");
            //}
            //else
            //{
            //    Console.WriteLine("You cannot drive");

            //}


            //switch(age)
            //{
            //    case 18:
            //        Console.WriteLine("You can drive");
            //        break;
            //    case 10:
            //        Console.WriteLine("You cannot drive");
            //        break;
            //    default:
            //        Console.WriteLine("Enjoy driving");
            //        break;
            //}

            //int iCNT = 0;

            //while(iCNT < 5)
            //{
            //    Console.WriteLine(iCNT);
            //    iCNT++;
            //}

            //do  //ha 0 tri print krel ch
            //{
            //    Console.WriteLine(iCNT);
            //    iCNT++;
            //} while (iCNT != 0 && iCNT > 5);

            //for(iCNT = 0;iCNT <5;iCNT++)   // 1 2 3 4 
            //{
            //    if(iCNT == 0)  //it will step directly to the next iteration 
            //        {
            //            continue;
            //        }
            //    Console.WriteLine(iCNT);
            //    //break;

            //}

            //break = leave loop forever
            //continue = leave loop this iteration and take next iteration 
            Console.ReadLine();

            //multiple cursor : alt + ctrl
            //copy line : ctrl + D
            //auto comment : ctrl + k + c
            //auto uncommet : Ctrl+K+U 
            //line vr khali nenyasathi atl + up and down arrow key  
            //shortcut to go to new line in visual studio code” Code Answer : Shift + Alt + Up / Down

        }
    }
}
