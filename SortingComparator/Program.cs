using System;
using System.Collections.Generic;
using System.Linq;

namespace SortingComparator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var dict = new Dictionary<string, int>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split();
                var name = input[0];
                var score = int.Parse(input[1]);

                dict.Add(name, score);

            }

            foreach (KeyValuePair<string, int> item in dict.OrderByDescending(key => key.Value).ThenBy(key => key.Key))
            {
                Console.WriteLine($"{item.Key}  {item.Value}");
            }
        }
    }
}
