using System;
using System.Collections.Generic;
using System.Linq;

namespace HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            var numsTrips = int.Parse(Console.ReadLine());
            var result = new List<int>();

            for (int j = 0; j < numsTrips; j++)
            {
                var money = int.Parse(Console.ReadLine());
                var size = int.Parse(Console.ReadLine());
                var costs = Console.ReadLine().Split().Select(int.Parse).ToArray();
                var dict = new Dictionary<int, int>();

                for (int i = 0; i < costs.Length; i++)
                {
                    dict.Add(i, costs[i]);
                }

                List<KeyValuePair<int, int>> l = dict.ToList();

                l.Sort((p1, p2) => p1.Value.CompareTo(p2.Value));
                foreach (KeyValuePair<int, int> keyPair in l.Where(x => x.Value < money))
                {
                    KeyValuePair<int, int> ans = l.Where(x => (x.Value == (money - keyPair.Value)) && x.Key != keyPair.Key).FirstOrDefault();
                    if (!ans.Equals(new KeyValuePair<int, int>()))
                    {
                        if (keyPair.Key > ans.Key)
                        {
                            Console.WriteLine(string.Format("{0} {1}", ans.Key + 1, keyPair.Key + 1));
                        }
                        else
                        {
                            Console.WriteLine(string.Format("{0} {1}", keyPair.Key + 1, ans.Key + 1));
                        }
                        break;
                    }
                }
            }
             

            
           
           
        }
    }
}
