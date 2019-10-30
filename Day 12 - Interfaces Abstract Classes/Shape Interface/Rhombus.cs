using System;
using System.Collections.Generic;
using System.Text;

namespace Shape_Interface
{
    class Rhombus: IShape
    {
        public double Line { get; set; }
        public double Height { get; set; }

        public Rhombus(double line, double height)
        {
            Line = line;
            Height = height;
        }

        public Rhombus()
        {
            Line = 1;
            Height = 1;
        }

        public double CalculateTheOutside()
        {
            return 4 * Line;
        }
        public double CalculateArea()
        {
            return Line * Height;
        }
        public double CalculateVolume()
        {
            return 0;
        }

    }
}
