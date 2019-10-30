using System;
using System.Collections.Generic;
using System.Text;

namespace Shape_Interface
{
    interface IShape
    {
        double CalculateTheOutside();
        double CalculateArea();
        double CalculateVolume();
    }
}
