using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram195BatchDay5
{

    public class LeapYear
    {
        public static void leapYear()
        {
            Console.WriteLine("INPUT YEAR IN YYYY FORMAT :");
            int Y = Convert.ToInt32(Console.ReadLine());

            if ((Y % 4 == 0) || (Y % 100 == 0))
            {
                Console.WriteLine(Y + "" + "IS A LEAP YEAR");

            }
            else
            {
                Console.WriteLine(Y + "" + "IS NOT A LEAP YEAR");
            }
        }
    }
}