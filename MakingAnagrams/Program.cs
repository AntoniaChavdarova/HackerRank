using System;
using System.Linq;

namespace MakingAnagrams
{
    class Program
    {
        static void Main(string[] args)
        {
           
            var a = "fcrxzfk";
            var b = "fcrba";

            //Console.WriteLine("Hello World!");

            Console.WriteLine(MakeAnagram(a, b) ); 
        }

       

        static int MakeAnagram(string a, string b)
        {
            int counter = 0;
            foreach (char current in Enumerable.Range('a', 'z'))
            {
                int aCount = a.Count(f => f == current);
                int bCount = b.Count(f => f == current);
                counter += Math.Abs(aCount - bCount);
                
            }

            return counter;
        }
    }
}
