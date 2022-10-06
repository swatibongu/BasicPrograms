using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram195BatchDay5
{
    public class FlipCoin
    {
        public static void flipCoin()
        {
            Console.WriteLine("INPUT NUMBER OF TIMES TO FLIP COIN :");
            int number = Convert.ToInt32(Console.ReadLine());

            //variables
            int headCount = 0;
            int tailCount = 0;

            //for loop to iterate upto number entered to flip  coin
            for (int i = 0; i < number; i++)
            {
                Random random = new Random();
                int flip = random.Next(0, 2);
                //given if flip<0.5 then it prints Tail or else Head
                if (flip < 0.5)
                {
                    Console.WriteLine("FLIPPED COIN SHOWS TAIL :");
                    tailCount++;
                }
                else
                {
                    Console.WriteLine("FLIPPED COINS SHOWS HEAD :");
                    headCount++;
                }

                double tailpercent = (tailCount * 100) / number;
                double headpercent = (headCount * 100) / number;

                Console.WriteLine("TAIL PERCENTAGE :" + tailpercent);
                Console.WriteLine("HEAD PERCENTAGE :" + headpercent);
            }
        }
    }
}