﻿using System;

namespace Conditional_FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int number = rnd.Next(1, 101);
            //int remainder = number % 3;
            //bool hasRemainder = remainder == 0'

            //BOOLEAN OPERATIONS
            //      OR = ||
            //      AND = &&
            //Assign a specific value in order to test
            
            if (number % 5 == 0 && number % 3 == 0)
            {
                Console.WriteLine("Fizz Buzz");
            }
            
            else if (number % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }

            else if (number % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }

            Console.WriteLine(number);
        }
    }
}
