using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using MathNet.Numerics;
using MathNet.Numerics.Distributions;

namespace Ellipsoid
{
    public class EllipsoidClass : Shape
    {
        public EllipsoidClass() { }
        public EllipsoidClass(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public EllipsoidClass(double x, double y, double z, double radius)
        {
            X = x;
            Y = y;
            Z = z;
            Radius = radius;
        }

        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }
        public double Radius { get; set; }
        public double VectorRadius { get; set; }

        public override double Volume()
        {
            return  (4.0 / 3.0) * Math.PI * Math.Pow(this.Radius, 3);
        }

        public double Concentration(List<EllipsoidClass> ellipsoid)
        {
            double result = 0;
            foreach(EllipsoidClass obj in ellipsoid)
            {
                result = Math.Pow(obj.VectorRadius, 3) / Math.Pow(obj.Radius, 3);
            }
            return result;
        }

        public override string ToString()
        {
            return $"X: {X}, Y: {Y}, Z: {Z}";
        }

        public static bool CheckCollision(EllipsoidClass ellipsoid1, EllipsoidClass ellipsoid2)
        {
            double distance = (double)Math.Sqrt(Math.Pow(ellipsoid2.X - ellipsoid1.X, 2) + Math.Pow(ellipsoid2.Y - ellipsoid1.Y, 2) + Math.Pow(ellipsoid2.Z - ellipsoid1.Z, 2));
            double sumRadii = ellipsoid1.Radius + ellipsoid2.Radius;

            return distance <= sumRadii;
        }

        public static bool IsInsideArea(Area area, EllipsoidClass ellipsoid) 
        {
            return ellipsoid.Volume() <= area.Volume();
        }


        public double Concatenation(double vr, double radius, int lim)
        {
            double result = 0;
            for (int i = 0; i < lim; i++)
            {
                result = Math.Pow(vr, 3);
            }
            return result / Math.Pow(radius, 3);
        }

        public double GetSize(double size, double excess)
        {
            return excess * size * 6.0 * Math.PI;
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

            //пример визуализации в консоли
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

        public static void WriteToCsv<T>(List<T> list, string filePath)
        {
            var csv = new StringBuilder();

            // Get the properties of the object type
            var properties = typeof(T).GetProperties();

            // header row
            foreach (var property in properties)
            {
                csv.Append(property.Name + ",");
            }
            csv.AppendLine();

            // data rows
            foreach (var item in list)
            {
                foreach (var property in properties)
                {
                    var value = property.GetValue(item, null);
                    csv.Append(value + ",");
                }
                csv.AppendLine();
            }

            File.WriteAllText(filePath, csv.ToString());
        }

        static int g = 7;
        static double[] p = {0.99999999999980993, 676.5203681218851, -1259.1392167224028,
         771.32342877765313, -176.61502916214059, 12.507343278686905,
         -0.13857109526572012, 9.9843695780195716e-6, 1.5056327351493116e-7};

        public static double CustomGamma(double z)
        {
            if (z < 0.5)
                return Math.PI / (Math.Sin(Math.PI * z) * CustomGamma(1 - z));
            z -= 1;
            double x = p[0];
            for (var i = 1; i < g + 2; i++)
                x += p[i] / (z + i);
            double t = z + g + 0.5;
            return Math.Sqrt(2 * Math.PI) * (Math.Pow(t, z + 0.5)) * Math.Exp(-t) * x;
        }
    }
}
