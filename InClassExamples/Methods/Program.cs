using System;
using System.Collections.Generic;
using System.Windows.Markup;

namespace Methods
{
    class Program
    {
        static List<int> values = new List<int>();

        static void Main(string[] args)
        {

            // Random rand = new Random(); // this is an instance

            Console.ReadKey();
        }

        static bool PossiblyAddStringToAList(string inputFromWhoeverCalledMe)
        {
            bool wasSuccess = true;
            int value;

            wasSuccess = int.TryParse(inputFromWhoeverCalledMe, out value);

            if (wasSuccess)
            {
                // we want to add it to the list
                Values.Add(value);
            }
            else
            {
                // we want to tell them they had an invalid input
                Console.WriteLine($"{value} was not a valid integer. You must enter an integer");
            }

            return wasSuccess;
        }
    }
}
