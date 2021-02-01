using System;
using System.Collections.Generic;
using System.Linq;

namespace SherlockandValid_String
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine();
            Console.WriteLine(IsValid(s));
        }

        static string IsValid(string s)
        {
            Dictionary<char, int> counts = new Dictionary<char, int>();
            foreach (char c in s.AsEnumerable())
            {
                if (counts.ContainsKey(c))
                {
                    counts[c]++;
                }
                else
                {
                    counts[c] = 1;
                }
            }

            Dictionary<int, int> uniqueCounts = new Dictionary<int, int>();
            foreach (int c in counts.Values.AsEnumerable())
            {
                if (uniqueCounts.ContainsKey(c))
                {
                    uniqueCounts[c]++;
                }
                else
                {
                    uniqueCounts[c] = 1;
                }
            }

            if (uniqueCounts.Count == 1)
                return "YES";
            if (uniqueCounts.Count == 2)
            {
                int maxI = uniqueCounts.Keys.Max();
                int minI = uniqueCounts.Keys.Min();
                if (uniqueCounts[minI] == 1)
                    return "YES";
                if (uniqueCounts[maxI] == 1 && maxI - minI == 1)
                    return "YES";
            }
            return "NO";
        }
            
                
        
    }
}
