using System;

namespace GeoFigures
{
    public class Rectangle
    {
        private double _width;
        private double _height;

        public double Width
        {
            get { return _width; }
            set
            {
                if (value > 0)
                {
                    _width = value;
                }
                else
                {
                    throw new ArgumentException("Width must be a positive number.");
                }
            }
        }

        public double Height
        {
            get { return _height; }
            set
            {
                if (value > 0)
                {
                    _height = value;
                }
                else
                {
                    throw new ArgumentException("Height must be a positive number.");
                }
            }
        }
         public double GetArea() => Width * Height;
        public double GetPerimeter() => 2 * (Width + Height);
    }
}
