using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ellipsoid
{
    public class Area
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }
        public double Radius { get; set; }

        /*public bool Contains(double x, double y, double z)
        {
            double distance = Math.Sqrt(Math.Pow(x - X, 2) + Math.Pow(y - Y, 2) + Math.Pow(z - Z, 2));
            return distance <= Radius;
        }*/

        public double Volume()
        {
            double a = X;
            double b = Y;
            double c = Z;
            double volume = a * b * c;
            return volume;
        }
    }
}
