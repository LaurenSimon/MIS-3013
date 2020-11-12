using System;

namespace Classes__Rectangle_and_Circle
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle mycircle = new Circle();
            mycircle.Radius = 7.5;
            Console.WriteLine($"The radius of {mycircle.Radius} is {mycircle.CalculateArea()}" + $" and a perimeter of {mycircle.CalculatePerimeter()}");

            Circle circle2 = new Circle();
            circle2.Radius = 8282828282;
            double areaofcircle2 = circle2.CalculateArea();
            double perimeterofcircle2 = circle2.CalculatePerimeter;

            Circle circle3 = new Circle(3.5);

            Rectangle myrectangle = new RectangleL();
            myrectangle.Length = 6;
            Console.WriteLine($"The length of {myrectangle.Length} is {myrectangle.CalculateArea()}" + $" and a perimeter of {myrectangle.CalculatePerimeter()}");

            Rectangle rectangle2 = new RectangleW();
            rectangle2.Length = 43;
            rectangle2.Width = 23;
            double areaofrectangle2 = rectangle2.CalculateArea();
            double perimeterofrectangle2 = rectangle2.CalculatePerimeter();
        }
    }
}
