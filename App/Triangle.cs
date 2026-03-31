using System;

namespace GeoFigures
{
    public class Triangle : Shape
    {
        public double Base { get; set; }
        public double Height { get; set; }
        public override double GetArea() => Base * Height / 2;
        public override double GetPerimeter() => Base + Height + Math.Sqrt(Base * Base + Height * Height);

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