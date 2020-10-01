using System;
using System.Collections.Generic;
using System.Text;

namespace TEST1
{
    class Geometry
    {
        public static double GetVector2DLength(double x, double y)
        {
            double aux, length;
            aux = x * x + y * y;
            length = System.Math.Sqrt(aux);
            return length;
        }
    
        public static double GetVector3DLength(double x, double y, double z)
        {
            double aux, length;
            aux = x * x + y * y + z * z;
            length = System.Math.Sqrt(aux);
            return length;
        }
    }
}
