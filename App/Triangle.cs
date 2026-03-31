using System;

namespace GeoFigures
{
    public class Triangle
    {
        public double Base { get; set; }
        public double Height { get; set; }
        public double GetArea() => Base * Height / 2;
        public double GetPerimeter() => Base + Height + Math.Sqrt(Base * Base + Height * Height);

        public Triangle()
        {
            
        }

        public Triangle(double triBase, double height)
        {
            Base = triBase;
            Height = height;
        }
    }
}