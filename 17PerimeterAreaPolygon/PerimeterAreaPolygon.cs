using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PerimeterAreaPolygon
{
    class PerimeterAreaPolygon
    {

        public class Point
        {
            private int x;
            private int y;

            public int X
            {
                get { return this.x; }
                set
                {
                    this.x = value;
                }
            }
            public int Y
            {
                get { return this.y; }
                set
                {
                    this.y = value;
                }
            }

            public Point(int x, int y)
            {
                this.X = x;
                this.Y = y;
            }

            public double CalcDistance(Point p)
            {
                return Math.Sqrt((p.x - this.x) * (p.x - this.x) +
                   (p.y - this.y) * (p.y - this.y));
            }
        }

        class Polygon
        {
            private List<Point> polygon;

            public Polygon()
            {
                polygon = new List<Point>();
            }

            public void AddPoint(Point p)
            {
                this.polygon.Add(p);
            }

            public double GetPerimetre()
            {
                polygon.Add(polygon[0]);
                double result = 0;

                for (int i = 0; i < polygon.Count - 1; i++)
                {
                    result += polygon[i].CalcDistance(polygon[i + 1]);
                }

                polygon.RemoveAt(polygon.Count - 1);
                return result;
            }

            public double GetArea()
            {
                polygon.Add(polygon[0]);
                double result = 0;

                for (int i = 0; i < polygon.Count - 1; i++)
                {
                    result += polygon[i].X * polygon[i + 1].Y - polygon[i].Y * polygon[i + 1].X;
                }

                polygon.RemoveAt(polygon.Count - 1);
                result = Math.Abs(result / 2);
                return result;
            }
        }

        static void Main()

        {
            int n = int.Parse(Console.ReadLine());

            Polygon polygon = new Polygon();

            for (int i = 0; i < n; i++)
            {
                int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                Point point = new Point(numbers[0], numbers[1]);
                polygon.AddPoint(point);
            }

            Console.WriteLine("perimeter = {0:F2}", polygon.GetPerimetre());
            Console.WriteLine("area = {0:F2}", polygon.GetArea());
        }
    }
}
