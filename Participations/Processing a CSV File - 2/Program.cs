using System;
using System.IO;

namespace Processing_a_CSV_File___2
{
    class Program
    {
        static void Main(string[] args)
        {
            // When the application loads, output all of the Names of the individual, as well as the Transaction_Date, who made the 
            // purchase.  Only show the information about the individual(their name and the transation date) if they used a Visa AND 
            // the sale took place in the United States.
            
            string filePath = @"SalesJan2009.csv";

            string[] lines = File.ReadAllLines(filePath);

            // Transaction_date,Product,Price,Payment_Type,Name,City,State,Country,Account_Created,Last_Login,Latitude,Longitude
            // Name = 5
            // Transaction_date = 1
            // Payment_Type (VISA) = 4
            // Country = 8

            for (int i = 1; i < lines.Length; i++)
            {
                string line = lines[i];
                string[] pieces = line.Split(',');
                string Name = (pieces[5]);
                string Date = (pieces[1]);
                string Country = (pieces[8]);
                if (pieces[4].Trim().ToLower() == "VISA")
                {
                    if (Country == "United States")
                    {
                        Console.WriteLine(Name);
                        Console.WriteLine(Date);
                    }
                    
                }
            }
            Console.ReadKey();
        }
    }
}
