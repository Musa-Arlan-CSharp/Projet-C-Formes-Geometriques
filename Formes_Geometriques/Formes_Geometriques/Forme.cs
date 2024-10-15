using System;

namespace Formes_Geometriques
{
    // Forme sınıfı zaten public
    public abstract class Forme
    {
        public Point Point { get; set; }

        public Forme(Point point)
        {
            Point = point;
        }

        public abstract double Perimetre();
        public abstract double Aire();
    }
}
