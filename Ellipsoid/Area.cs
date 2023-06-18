using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ellipsoid
{
    public class Area : Shape
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }
        public double Radius { get; set; }

        public override double Volume()
        {
            double a = X;
            double b = Y;
            double c = Z;
            return a * b * c;
        }
    }
}
