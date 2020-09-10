using System;

namespace CoinToss
{
    class Program
    {
        const string DEVELOPER = "Lauren Simon";
        const int Heads = 1;
        const int Tails = 0;
        static void Main(string[] args)
        {
            Console.WriteLine("Heads or Tails?");
            string answer = Console.ReadLine();

            Random rnd = new Random();
            int result = rnd.Next(0, 2);

            if (result == Heads && answer == "Heads")
            {
                Console.WriteLine("You are CORRECT!");
            }
            else if (result == Tails && answer == "Tails")
            {
                Console.WriteLine("You are CORRECT!");
            }
            else
            {
                Console.WriteLine("You are WRONG!");
            }
            Console.WriteLine(DEVELOPER);
        }   
    }
}
