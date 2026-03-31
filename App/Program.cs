// See https://aka.ms/new-console-template for more information
using System;
using System.ComponentModel;


// Sukurkite naują projektą GeoFigures;
// Aprašykite klasė Circle su Radius property;
// Aprašykite klasė Triangle su Base ir Height properties;
// Sukurkite keleta Circle ir Triangle objektų Main metode;
// Aprašykite Rectangle klasę. Pridėkite Width ir Height property. Patikrinkite ar reikšmės teigiamos;
// Kiekvienoje iš aprašytu klasių pridėkite metodus GetArea() ir GetPerimeter(). Aprašykite jų funkcialumą.


namespace GeoFigures
{
   

     class Program
    {
        static void Main(string[] args)
        {
            Triangle t1 = new Triangle();
            t1.Base = 5;
            t1.Height = 10;
            Triangle t2 = new Triangle();
            t2.Base = 2;
            t2.Height = 4;

            Circle c1 = new Circle();
            c1.Radius = 7;
            Circle c2 = new Circle();
            c2.Radius = 3;

            Console.WriteLine("Traingles: ");
            Console.WriteLine($"1st Triangle: Area = {t1.GetArea()}");
            Console.WriteLine($"2nd Triangle: Area = {t2.GetArea()}");

            Console.WriteLine("Circles: ");
            Console.WriteLine($"1st Circle: Area = {c1.GetArea():F2}");
            Console.WriteLine($"2nd Circle: Area = {c2.GetArea():F2}");
        }
    }
    
}

