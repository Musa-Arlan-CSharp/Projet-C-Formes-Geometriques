using Formes_Geometriques;

class Program
{
    static void Main(string[] args)
    {
        Point p1 = new Point(2, 3);
        Cercle c = new Cercle(p1, 5);
        Console.WriteLine($"Cercle - Périmètre: {c.Perimetre()}, Aire: {c.Aire()}");

        Point p2 = new Point(5, 6);
        Rectangle r = new Rectangle(p2, 4, 6);
        Console.WriteLine($"Rectangle - Périmètre: {r.Perimetre()}, Aire: {r.Aire()}");
    }
}
