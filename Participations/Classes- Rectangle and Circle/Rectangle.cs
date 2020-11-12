namespace Classes__Rectangle_and_Circle
{
    internal class Rectangle
    {
        public double Length { get; set; }
        public double Width { get; set; }

        public RectangleL(double Length)
        {
            this.Length = Length;
        }

        public RectangleW(double Width)
        {
            this.Width = Width;
        }

        public double CalculateArea()
        {
            return Length * Width;
        }

        public double CalculatePerimeter()
        {
            return 2 * Length + 2 * Width;
        }
    }
}