using System;
using System.Collections.Generic;
using System.Text;

namespace _P__Classes___TextBox
{
    class TextBox
    {
        public int Padding { get; set; }
        // Padding is the spacing before and after text (hint: add the correct number of spaces 
        // BEFORE and AFTER the test property.

        public ConsoleColor BackColor { get; set; }

        public ConsoleColor ForeColor { get; set; }

        public string Text { get; set; }

        public TextBox()
        {

        }

        public void DisplayText()
        {
            // Writes out on the console the text with the correct ForegroundColor and BackgroundColor associated with Back/ Fore color 
            // property of the instance. There should be padding before / after the Text property based on the int value associated with padding
            Console.BackgroundColor = BackColor;
            Console.ForegroundColor = ForeColor;
            string BackgroundColor;
            string ForegroundColor;
            Console.WriteLine(BackgroundColor.PadLeft(10, '-'));
            Console.WriteLine(BackgroundColor.PadRight(10, '-'));
            Console.WriteLine(ForegroundColor.PadRight(10, '-'));
            Console.WriteLine(ForegroundColor.PadLeft(10, '-'));
            // used pad method from referencing 
            // https://docs.microsoft.com/en-us/dotnet/standard/base-types/padding
        }
    }
}
