using Microsoft.VisualBasic;
using System;
using System.IO;
using System.Threading;

namespace Processing_a_CSV_File___2
{
    class Program
    {
        public static object Date { get; private set; }

        static void Main(string[] args)
        {
            // When the application loads, output all of the Names of the individual, as well as the Transaction_Date, who made the 
            // purchase.  Only show the information about the individual(their name and the transation date) if they used a Visa AND 
            // the sale took place in the United States.
            
            string filePath = @"SalesJan2009.csv";

            string[] lines = File.ReadAllLines(filePath);

            // Transaction_date,Product,Price,Payment_Type,Name,City,State,Country,Account_Created,Last_Login,Latitude,Longitude
            // Name = 4
            // Transaction_date = 0
            // Payment_Type (VISA) = 3
            // Country = 7

            for (int i = 1; i < lines.Length; i++)
            {
                string line = lines[i];
                string[] pieces = line.Split(',');
                string Name = (pieces[4]);
                string Date = (pieces[0]);
                string Country = (pieces[7]);
                if (pieces[3].Trim().ToLower() == "VISA")
                {
                    Console.WriteLine($"{Name.ToUpper()} {Date}");
                }
                else if (pieces[7].Trim() == "United States")
                {
                    Console.WriteLine($"{Name.ToUpper()} {Date}");
                }
            }
            Console.ReadKey();
        }
    }
}