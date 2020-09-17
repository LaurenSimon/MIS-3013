using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomGuess
{
    class Program
    {
        const string developer = "Lauren Simon";
        static void Main(string[] args)
        {
            int MinValue = 0;
            int MaxValue = 0;
            int Guess = 0;
            string response;
            string response2;

            Console.WriteLine("Choose a Minimum Value.");
            response = Console.ReadLine();
            MinValue = Convert.ToInt32(response);
            
            Console.WriteLine("Choose a Maximum Value.");
            response2 = Console.ReadLine();
            MaxValue = Convert.ToInt32(response2);

            Random rnd = new Random();
            int result = rnd.Next(MinValue, MaxValue + 1);
            string Number = Convert.ToString(result);

            Console.WriteLine("Guess a number");
            Guess = Convert.ToInt32(Console.ReadLine());
            
            while (Guess != result);
            {
                Console.WriteLine("Wrong, guess again");
                Console.ReadLine();
            }
            Console.WriteLine("Correct!");

            Console.WriteLine(developer);
            Console.ReadKey();
        }
    }
}
