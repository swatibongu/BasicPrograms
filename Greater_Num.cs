using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram195BatchDay4
{
    public class LargestNumber
    {
        public static void largestNumber()
        {
            Console.WriteLine("INPUT THREE NUMBERS AS :");

            int num1 = Convert.ToInt32(Console.ReadLine());

            int num2 = Convert.ToInt32(Console.ReadLine());

            int num3 = Convert.ToInt32(Console.ReadLine());

            //check if A1 is greater than A2 (by nested if)
            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.Write("num1 is the largest");
                }
                else
                {
                    Console.Write("num3 is the largest");
                }
            }
            else if (num2 > num3)
            {

                Console.Write("num2 is the largest");
            }
            else
                Console.Write("num3 is the largest");
        }
    }
}