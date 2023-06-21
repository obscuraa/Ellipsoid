using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

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

        public override double Volume()
        {
            double a = X / 2;
            double b = Y / 2;
            double c = Z / 2;
            return  (4.0 / 3.0) * Math.PI * a * b * c;
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

        public static bool isInsideArea(Area area, EllipsoidClass ellipsoid) 
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
    }
}
