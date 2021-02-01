using System;
using System.Collections.Generic;
using System.Linq;

namespace MaxMin
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            var list = new List<int>();
            var smalllist = new List<int>();

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
               
                list.Add(num);
            }


            list.Sort();
            

            int unfair = list[k - 1] - list[0];

            for (int i = 1; i <= n - k; i++)
                unfair = Math.Min(unfair, list[i + k - 1] - list[i]);
            Console.WriteLine(unfair);

        }
    }
}
