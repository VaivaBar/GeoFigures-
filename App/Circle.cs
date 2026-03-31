using System;


namespace GeoFigures
{
    public class Circle
    {
        public double Radius { get; set; }
        public double GetArea() => Math.PI * Math.Pow(Radius, 2);
        public double GetPerimeter() => 2 * Math.PI * Radius;

        
    public Circle()
        {
                      
        }

     public Circle(double radius)
        {
            Radius = radius;
        }   
    }

}