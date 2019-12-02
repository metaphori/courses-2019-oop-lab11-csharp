using System;

/*
 * == README ==
 * 
 * Questo esercizio consente di approfondire e testare le varie possibilità offerte da C# per il passaggio dei parametri.
 * 
 * 1) Comprendere il funzionamente del programma proposto, stabilendo - prima di avviarlo - quale sarà l'output del programma.
 * 2) Avviare il programma e verificare che l'output ottenuto sia conforme a quanto atteso.
 * 
 */

namespace Parameters
{
    class Program
    {
        public static void Main(string[] args)
        {
            Library lib = new Library();

            int x = 10;
            Console.WriteLine("Main : x = " + x);
            lib.M1(x);
            Console.WriteLine("Main : x = " + x);
            lib.M2(ref x);
            Console.WriteLine("Main : x = " + x);
            lib.M3(out x);
            Console.WriteLine("Main : x = " + x);

            int a = 10;
            int b = 20;

            Console.WriteLine(string.Format("(invocation of Sum() with return value) {0} + {1} = {2}", a, b, lib.Sum(a, b)));

            lib.Sum(a, b, out int res);

            Console.WriteLine(string.Format("(invocation of Sum() with out param) {0} + {1} = {2}", a, b, res));

            Point3D p1 = new Point3D(1, 2, 3);
            Point3D p2 = new Point3D(4, 5, 6);

            Point3D p3 = lib.Sum(p1, p2);

            Console.WriteLine("P1: " + p1.ToString());
            Console.WriteLine("P2: " + p2.ToString());
            Console.WriteLine("P3: " + p3.ToString());
        }
    }

    public class Library
    {
        public void M1(int x)
        {
            x++;
            Console.WriteLine("m1 : x = " + x);
        }

        public void M2(ref int x)
        {
            x++;
            Console.WriteLine("m1 : x = " + x);
        }

        public void M3(out int x)
        {
            x = 100;
            Console.WriteLine("m1 : x = " + x);
        }

        public int Sum(int a, int b)
        {
            return a + b;
        }

        public void Sum(int a, int b, out int res)
        {
            res = a + b;
        }

        public Point3D Sum(Point3D p1, Point3D p2)
        {
            return new Point3D(p1.X + p2.X, p1.Y + p2.Y, p1.Z + p2.Z);
        }
    }

    public struct Point3D
    {
        public Point3D(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public int X { get; private set; }
        public int Y { get; private set; }
        public int Z { get; private set; }

        public override string ToString()
        {
            return string.Format("[POINT3D] ({0};{1};{2})", X, Y, Z);
        }
    }
}
