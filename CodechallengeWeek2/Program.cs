using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodechallengeWeek2
{
    class Program
    {
        static void Main(string[] args)
        {
            //loop to address fizzbuzz between numbers
           for (int i = 0; i <= 20; i++)
           {
               Console.WriteLine(FizzBuzz(i));
           }
            //output for LetterCounter
           letterCounter('i', "I love biscuits and gravy. It's the best breakfast ever.");
           
           letterCounter('n', "Never gonna give you up. Never gonna let you down.");
          
           letterCounter('s', "Sally sell seashells down by the seashore. She's from Sussex.");
           Console.ReadKey();
        }
        /// <summary>
        /// if a number is divisble by 5 or 3 player gets fizzbuzz, fizz if divisble by 5, and buzz if divisble  by 3
        /// </summary>
        /// <param name="number">a number to call fizz buzz to</param>
        /// <returns>fizz, buzz, or fizzbuzz</returns>
        public static string FizzBuzz(int number)
        {
            string FizzBuzz =" ";

            if (number % 5 == 0 && number % 3 == 0)
            {
                return "FizzBuzz";
            }
            else if (number % 5 == 0)
            {
                return "Fizz";
            }
            else if (number % 3 == 0)
            {
                return "Buzz";
            }
            else
            {
                return number.ToString();
            }

        }
        /// <summary>
        /// Lettercounter to search string for a user input letter
        /// </summary>
        /// <param name="letter">user inputs letter to search</param>
        /// <param name="inString"> a string to search through for a particular letter</param>
        public static void letterCounter(char letter, string inString)
        {
           int counterT = 0;
           int counterts = 0;
            for (int i = 0; i < inString.Length; i++)
            {
                if (inString[i].ToString() == letter.ToString())
                {
                    counterts++;
                }
                if (inString[i].ToString() == letter.ToString().ToUpper())
                {
                    counterT++;
                }
            }
            
            Console.WriteLine("Input: " + inString);
            Console.WriteLine("Number of lowercase " + letter + "'s found: " + counterts);
            Console.WriteLine("Number of Uppercase " + letter.ToString().ToUpper() + "'s letters found: " + counterT);
            Console.WriteLine("Total number of " + letter + "'s found: " + (counterT + counterts));
            
          }
    }
}
