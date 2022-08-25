using System;
//avoiding run time sudden accidental closing of program due to some run time error
//that run time error gets handled by CLR and CLR will close the program by telling giving what exception came for sudden closing


namespace ExceptionHandling_In_Cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inside main");

            int iNo1 = 0, iNo2 = 0;
            float fRet = 0.0F;

            Console.WriteLine("Enter first and second numner");

            iNo1 = Convert.ToInt32(Console.ReadLine());
            iNo2 = Convert.ToInt32(Console.ReadLine());

            try //exception prone code written inside it due to which the execution of this critical section gets done under the observation of CLR
            {
                fRet = iNo1 / iNo2;
                Console.WriteLine("Division is : " + fRet);
            }
            //if any exception comes then CLR will throw the obj of exception which gets catched by catch block
            catch (DivideByZeroException obj) //specific catch 
            {
                Console.WriteLine("Exception occured : " + obj);
            }
            catch (Exception eobj) //generic .As Exception is Super class of all exception any kind of exception gets catched in it
            {
                Console.WriteLine("Exception occured : " + eobj);
            }
            finally //irrespective of anything this block gets exectuted
            {
                Console.WriteLine("Inside finally");
            }
        }
    }
}
