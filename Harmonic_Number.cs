using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram195BatchDay5
{
    public class Harmonic
    {
        public static void harmonic()
        {

            double harmonic = 0;

            Console.WriteLine("ENTER LIMIT OF HARMONIC NUMBER :");

            // int count=Convert.ToInt32(Console.ReadLine());
            double count = Convert.ToDouble(Console.ReadLine());

            if (count != 0)
            {

                for (double i = 1; i < count; i++)
                {
                    harmonic = harmonic + 1 / i;
                }
                Console.WriteLine("HARMONIC NUMBERS ARE :" + harmonic);
            }
        }
    }
}