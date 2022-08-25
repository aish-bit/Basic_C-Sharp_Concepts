using System;

namespace OneDimensionalArray_In_Cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inside main");

            // int arr[] = new int[5]; //error

            int[] arr = new int[5];  //first way
            arr[0] = 11; 
            arr[1] = 21;
            arr[2] = 51;
            arr[3] = 101;
            arr[4] = 111;

            Console.WriteLine("Length of arr : " + arr.Length); //5

            int[] brr = { 11, 21, 51, 101, 111 }; //second way

            Console.WriteLine("Length of brr : " + brr.Length); //5

            int[] crr = new int[] { 11, 21, 51, 101, 111 }; //third way

            Console.WriteLine("Length of crr : " + crr.Length); //5

            int iCnt = 0;

            for(iCnt = 0;iCnt <arr.Length;iCnt++)
            {
                Console.WriteLine(arr[iCnt]);
            }

            //for(int no : arr) //not present in c#
            //{

            //}

        }
    }
}
