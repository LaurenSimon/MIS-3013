using System;

namespace _P__Classes___TextBox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create at least two TextBox instances with different values set for the properties.  
            // Call the DisplayText method on each instance of your TextBox.
            TextBox TextBox1 = new TextBox()
            {
                Console.WriteLine("Text Box Number 1");
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Blue;
                // Console.WriteLine(DisplayText);
            }

            TextBox TextBox2 = new TextBox()
            {
                Console.WriteLine("Text Box Number 2");
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Yellow;
                // Console.WriteLine(DisplayText);
            }
        }

        // static void DisplayText (string ForeGroundColor)
        // {
        // }

        // static void DisplayText (string BackgroundColor)
        // {
        // }
    }
}
