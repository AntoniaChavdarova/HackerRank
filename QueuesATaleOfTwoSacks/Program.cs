using System;
using System.Linq;

namespace QueuesATaleOfTwoSacks
{

    public struct MutablePoint
    {
        public int X;
        public int Y;

        public MutablePoint(int x, int y) => (X, Y) = (x, y);

        public override string ToString() => $"({X}, {Y})";
    }
    class Program
    {
        static void Main(string[] args)
        {

            //string a = "hello";
            //string b = "h";
            //// Append to contents of 'b'
            //b += "ello";
            //Console.WriteLine(a == b);
            //Console.WriteLine(object.ReferenceEquals(a, b));

            var p1 = new MutablePoint(1, 2);
            var p2 = p1;
            p2.Y = 200;
            Console.WriteLine($"{nameof(p1)} after {nameof(p2)} is modified: {p1}");
            Console.WriteLine($"{nameof(p2)}: {p2}");

            MutateAndDisplay(p2);
            Console.WriteLine($"{nameof(p2)} after passing to a method: {p2}");
        }

            private static void MutateAndDisplay(MutablePoint p)
            {
                p.X = 100;
                Console.WriteLine($"Point mutated in a method: {p}");
            }

       
    }
}
