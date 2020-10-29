using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    public class Rectangle
    {
        private int width;
        private int height;


        /// <summary>
        /// default/empty constructor
        /// </summary>
        public Rectangle()
        {
            width = 0;
            height = 0;
        }

        /// <summary>
        ///  overload constructor
        /// </summary>
        /// <param name="width"></param>
        /// <param name="height"></param>
        public Rectangle(int width, int height)
        {
            this.width = width;
            this.height = height;
        }


        public double Area()
        {
            double result = width * height;

            return result;
        }
    }
}
