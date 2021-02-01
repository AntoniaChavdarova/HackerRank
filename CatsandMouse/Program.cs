using System;
using System.Linq;

namespace CatsandMouse
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int catA = input[0];
            int catB = input[1];
            int mouse = input[2];
            Console.WriteLine(CatAndMouse(catA , catB , mouse));
        }

        static string CatAndMouse(int x, int y, int z)
        {
            if(Math.Abs(z-x) < Math.Abs(z- y))
            {
                return "Cat A";

            }else if (Math.Abs(z - x) > Math.Abs(z - y))
            {
               return "Cat B";
            }
            else
            {
                return "Mouse C";
            }

        }
    }
}
