using System;

namespace LoopsInCs
{
    class Program
    {
        static void Main(string[] args)
        {
            //for loop same as c,c++,java
            int iCnt = 0;

            for(iCnt = 0;iCnt < 5;iCnt++)
            {
                if(iCnt == 2)
                {
                    continue;  //2 will not get print ..it will take next iteration
                }
                Console.WriteLine(iCnt);
                if(iCnt == 3)
                {
                    break; //it will break the loop 
                }
            }

            //while loop same as c,c++,java
            iCnt = 0;

            while(iCnt < 5)
            {
                Console.WriteLine(iCnt);
                iCnt++;
            }


            //while loop same as c,c++,java
            iCnt = 0;

            do
            {
                Console.WriteLine(iCnt);
                iCnt++;
            } while (iCnt < 5);


            Console.ReadKey();
        }
    }
}
