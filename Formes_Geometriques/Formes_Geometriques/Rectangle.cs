using System;


namespace Formes_Geometriques
{
    
    
        public class Rectangle : Forme
        {
            public double Longueur { get; set; }
            public double Largeur { get; set; }

            public Rectangle(Point point, double longueur, double largeur) : base(point)
            {
                Longueur = longueur;
                Largeur = largeur;
            }

            public override double Perimetre()
            {
                return 2 * (Longueur + Largeur);
            }

            public override double Aire()
            {
                return Longueur * Largeur;
            }
        }

    }

