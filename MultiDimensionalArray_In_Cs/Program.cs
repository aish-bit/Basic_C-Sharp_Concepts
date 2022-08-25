


using System;

namespace MultiDimensionalArray_In_Cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inside main");

            //int[][] arr = new int[3][2];  //error
            int[,] arr = new int[3, 2];

            //arr[0][0] = 10; //error
            //arr[0][1] = 20; //error

            arr[0, 0] = 10;
            arr[0, 1] = 20;
            arr[1, 0] = 30;
            arr[1, 1] = 40;
            arr[2, 0] = 50;
            arr[2, 1] = 60;


            Console.WriteLine("Length of arr : " + arr.Length); //6

            Console.WriteLine("Length of arr : " + arr.GetLength(0)); //3

            

        }
    }
}

