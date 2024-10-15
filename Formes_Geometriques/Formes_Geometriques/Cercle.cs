using System;


namespace Formes_Geometriques
{
   
    
        public class Cercle : Forme
        {
            public double Rayon { get; set; }

            public Cercle(Point point, double rayon) : base(point)
            {
                Rayon = rayon;
            }

            public override double Perimetre()
            {
                return 2 * Math.PI * Rayon;
            }

            public override double Aire()
            {
                return Math.PI * Rayon * Rayon;
            }
        }

    }

