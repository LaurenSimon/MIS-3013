using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            string phrase = "Programming today is a race between software " +
                "engineers striving to build bigger and better idiot-proof " +
                "programs, and the universe trying to build bigger and better idiots. " +
                "So far, the universe is winning.";

            Console.WriteLine(phrase);

            Console.WriteLine("\nWhat word do you want to look for?");
            string oldword = Console.ReadLine();

            bool check = phrase.Contains(oldword);

            if (check == false)
            {
                Console.WriteLine("\nSorry, I could not find your word " + oldword);

                for (int i = oldword.Length - 1; i >= 0; i--)
                {
                    Console.WriteLine(oldword[i]);
                }
                Console.ReadKey();
            }
            else if (check == true)
            {
                Console.WriteLine("\nWhat word do you want to replace it with?");
                string newword = Console.ReadLine();

                Console.WriteLine();

                Console.WriteLine(phrase.Replace(oldword, newword));

                Console.ReadKey();
            }
        }
    }
}
