using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrgms194BatchDay4
{
    public class SwapNumbers
    {
        public static void swapNumbers()
        {
            //define temp variable
            int temp = 0;


            Console.WriteLine("INPUT 1ST NUMBER :");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("INPIUT 2ND NUMBER :");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("BEFORE SWAPPING num1 :" + num1 + "num2 :" + num2);

            //for swapping numbers it stored in temp
            temp = num1;
            num1 = num2;
            num2 = temp;

            Console.WriteLine("After Swapping num2 :" + num1 + "num1 :" + num2);
        }
    }
}