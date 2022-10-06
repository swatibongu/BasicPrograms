using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrgms194BatchDay4
{
    public class OddEven
    {
        public static void oddEven()
        {
            Console.WriteLine("INPUT NUMBER TO CHECK IT IS ODD OR EVEN : ");
            int number = Convert.ToInt32(Console.ReadLine());

            //if number is divisible by 2 it is even else odd

            if (number % 2 == 0)
            {
                Console.WriteLine("GIVEN NUMBER IS EVEN : " + number);
            }
            else
            {
                Console.WriteLine("GIVEN NUMBER IS ODD: " + number);
            }

        }

    }
}