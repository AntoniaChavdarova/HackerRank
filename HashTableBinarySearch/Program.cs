using System;
using System.Linq;

namespace HashTableBinarySearch
{
    class Flavor : IComparable
    {
        public Flavor(int price, int index)
        {
            this.Price = price;
            this.Index = index;
        }

        public int Price { get; private set; }

        public int Index { get; private set; }

        public int Compare(object x, object y)
        {
            throw new NotImplementedException();
        }

        public int CompareTo(object obj)
        {
            Flavor flavor = (Flavor)obj;

            return this.Price.CompareTo(flavor.Price);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var numsTrips = int.Parse(Console.ReadLine());

            for (int j = 0; j < numsTrips; j++)
            {
                var money = int.Parse(Console.ReadLine());
                var size = int.Parse(Console.ReadLine());
                var flavorsArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
                Flavor[] flavors = new Flavor[flavorsArray.Length];

                for (int i = 0; i < flavorsArray.Length; i++)
                {
                    flavors[i] = new Flavor(flavorsArray[i], i + 1);
                }

                Array.Sort(flavors);

                int firstIndex = 0;
                int secondIndex = 0;

                for (int i = 0; i < flavors.Length; i++)
                {
                    int moneyLeft = money - flavors[i].Price;
                    int index = binarySearch(flavors, moneyLeft, i);
                    if (index != -1)
                    {
                        if (flavors[index].Index > flavors[i].Index)
                        {
                            firstIndex = flavors[i].Index;
                            secondIndex = flavors[index].Index;
                        }
                        else
                        {
                            firstIndex = flavors[index].Index;
                            secondIndex = flavors[i].Index;
                        }
                    }
                }

                Console.WriteLine("{0} {1}", firstIndex, secondIndex);
            }

        }

        private static int binarySearch(Flavor[] flavors, int moneyLeft, int ignoreIndex)
        {
            int left = 0;
            int right = flavors.Length - 1;

            while (left <= right)
            {
                var mid = (left + right) / 2;

            }
        }
    }
}
