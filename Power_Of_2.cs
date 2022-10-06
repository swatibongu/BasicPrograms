using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram195BatchDay5
{
    public class Powerof2
    {
        public static void powerOf2()
        {
            int i;
            Console.WriteLine("Input any Value :");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n > 0 && n < 31)
            {
                Console.WriteLine("Entered value is in range" + n);

                for (i = 1; i <= n; i++)
                {
                    Console.WriteLine(Math.Pow(2, i));
                }
            }
            else
            {
                Console.WriteLine("Entered value is not in range");
            }
        }
    }
}