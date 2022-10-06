using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram195BatchDay5
{
    public class Factors
    {
        public static void factors()
        {
            Console.WriteLine("ENTER THE NUMBER : ");
            int a = Convert.ToInt32(Console.ReadLine());

            //prime numbers starts from 2 so i=2
            for (int i = 2; i * i <= a; i++)
            {
                //
                while (a % i == 0)
                {
                    Console.WriteLine(i);
                    a = a / i;
                }
            }
            if (a > 2)
            {
                Console.WriteLine(a);
            }
        }
    }
}