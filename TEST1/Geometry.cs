using System;
using System.Collections.Generic;
using System.Text;

namespace TEST1
{
    class Geometry
    {
        public static double GetVectorLength(double x, double y)
        {
            double aux, length;
            aux = x * x + y * y;
            length = System.Math.Sqrt(aux);
            return length;
        }
    }
}
