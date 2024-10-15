using System;

namespace Formes_Geometriques
{
    // Point sınıfını public olarak tanımlıyoruz
    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point()
        {
            X = 0;
            Y = 0;
        }

        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public override bool Equals(object? obj)
        {
            if (obj == null || !(obj is Point))
            {
                return false;
            }
            Point p = (Point)obj;
            return (X == p.X) && (Y == p.Y);
        }

        public override string ToString()
        {
            return $"Point(X: {X}, Y: {Y})";
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(X, Y);
        }
    }
}
