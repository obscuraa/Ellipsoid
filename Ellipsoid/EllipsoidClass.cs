using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Ellipsoid
{
    public class EllipsoidClass
    {
        public EllipsoidClass() { }
        public EllipsoidClass(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public double Volume()
        {
            double a = X / 2;
            double b = Y / 2;
            double c = Z / 2;
            double volume = (4.0 / 3.0) * Math.PI * a * b * c;
            return volume;
        }

        public override string ToString()
        {
            return $"X: {X}, Y: {Y}, Z: {Z}";
        }

        public List<EllipsoidClass> GenerateRandomPoints(double a, double b, double c, int numPoints)
        {
            List<EllipsoidClass> points = new List<EllipsoidClass>();
            Random rand = new Random();

            for (int i = 0; i < numPoints; i++)
            {
                double x = rand.NextDouble() * 2 * a - a;
                double y = rand.NextDouble() * 2 * b - b;
                double z = rand.NextDouble() * 2 * c - c;

                points.Add(new EllipsoidClass(x, y, z));
            }

            Area area = new Area
            {
                X = 10,
                Y = 10,
                Z = 10,
                Radius = 5
            };

            foreach (EllipsoidClass point in points)
            {
                bool isInside = point.Volume() <= area.Volume();
                Console.WriteLine(isInside);
                Console.WriteLine(point.ToString());
            }

            return points;
        }
    }
}
