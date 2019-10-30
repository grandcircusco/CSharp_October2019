using System;
using System.Collections.Generic;

namespace Shape_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IShape> shapes = new List<IShape>
            {
                new Rhombus(5, 17),
                new Rhombus(20, 6),
                new Triangle(7.264, 8.561, 47.3),
                new Triangle(11, 4.95, 8.85)
            };

            foreach(IShape shape in shapes)
            {
                Console.WriteLine("Shape 1:");
                Console.WriteLine(shape.CalculateArea());
                Console.WriteLine(shape.CalculateArea());
                Console.WriteLine(shape.CalculateTheOutside());
                Console.WriteLine(shape.CalculateVolume());
            }
        }
    }
}
