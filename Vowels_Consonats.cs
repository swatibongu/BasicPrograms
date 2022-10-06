using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram195BatchDay4
{
    public class VowelsConsonants
    {
        public static void vowelsConsonants()
        {
            Console.WriteLine("INPUT ANY ALPHABETIC LETTER :");

            //store inpute alphabet in char alphabet
            char alphabet = Convert.ToChar(Console.ReadLine());

            //VOWELS are "a e i o u" others are CONSONANTS

            //using Switch case to get enterd alphabet is Vowel or Consonant
            switch (alphabet)
            {
                case 'a':
                    Console.WriteLine("THIS ALPHABET IS A VOWEL");
                    break;
                case 'e':
                    Console.WriteLine("THIS ALPHABET IS A VOWEL");
                    break;
                case 'i':
                    Console.WriteLine("THIS ALPHABET IS A VOWEL");
                    break;
                case 'o':
                    Console.WriteLine("THIS ALPHABET IS A VOWEL");
                    break;
                case 'u':
                    Console.WriteLine("THIS ALPHABET IS A VOWEL");
                    break;
                default:
                    Console.WriteLine("GIVEN ALPHABETIC LETTER IS A CONSONANT");
                    break;
                    Console.ReadKey();
            }
        }
    }
}