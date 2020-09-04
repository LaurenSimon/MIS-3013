using System;

namespace InputOutput
{
    class Program
    {
        static const string CLASS_NAME = "MIS 3013";
        static void Main(string[] args)
        {
            //This won't work because it is a constant
            // CLASS_NAME = "MIS 3353"
            //string firstName, lastName;
            string firstName = "Lauren";
            string lastName = "Simon";
            Console.WriteLine(firstName + " " + lastName);
                " is teaching " + CLASS_NAME);
        }
    }
}
