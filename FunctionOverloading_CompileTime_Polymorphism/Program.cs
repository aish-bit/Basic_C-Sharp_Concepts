using System;

namespace FunctionOverloading_CompileTime_Polymorphism
{
    class Addition
    {
        //overloading by changing the no of arguments
        public int Add(int iNo1,int iNo2)
        {
            Console.WriteLine("Inside first addition");
            return iNo1 + iNo2;
        }

        public int Add(int iNo1, int iNo2,int iNo3)
        {
            Console.WriteLine("Inside second addition");
            return iNo1 + iNo2+iNo3;
        }

        //Overloading by changing the datatype of arguments
        public float Add(float fNo1, float fNo2)
        {
            Console.WriteLine("Inside third addition");
            return fNo1 + fNo2;
        }

        //overloading by changing the sequence of arguments
        public void fun(int i,float f)
        {
            Console.WriteLine("Inside first fun");
        }

        public void fun( float f,int i)
        {
            Console.WriteLine("Inside second fun");
        }


    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inside main");

            Addition aobj = new Addition();

            int iRet = 0;
            float fRet = 0.0F;

            iRet = aobj.Add(10, 11);
            Console.WriteLine("Addition of 2 int : " + iRet);

            iRet = aobj.Add(10, 11,30);
            Console.WriteLine("Addition of 3 int : " + iRet);

            fRet = aobj.Add(10.5F, 11.3F);
            Console.WriteLine("Addition of 2 flaot : " + iRet);

            aobj.fun(10, 11.11F);
            aobj.fun(11.11F, 10);
        }
    }
}
