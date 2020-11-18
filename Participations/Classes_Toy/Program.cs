using System;

namespace Classes_Toy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What toy do you want?");
            string Name = Console.ReadLine();

            Console.WriteLine("Who manufacturers that toy?");
            string Manufacturer = Console.ReadLine();

            Console.WriteLine("What is the price of that toy?");
            double Price = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Any special notes for that toy?");
            string Notes = Console.ReadLine();



            Console.ReadKey();
        }
    }
}
