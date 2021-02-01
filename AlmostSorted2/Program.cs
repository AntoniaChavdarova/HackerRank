using System;
using System.Linq;

namespace AlmostSorted2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = Array.ConvertAll(Console.ReadLine().Trim().Split(), int.Parse);
            int[] sortedArray = array.OrderBy(x => x).ToArray();

            int left = 0, right = n - 1;
            while (left < n && array[left] == sortedArray[left]) left++;
            while (right >= 0 && array[right] == sortedArray[right]) right--;

            if (right == 0)
            {
                Console.WriteLine("yes");
            }
            else
            {
                bool sorted = true;
                bool reversed = true;
                for (int i = left; i < right; i++)
                {
                    if (array[i] < array[i + 1])
                    {
                        reversed = false;
                        break;
                    }
                }
                for (int i = left + 1; i < right; i++)
                {
                    if (array[i] != sortedArray[i])
                    {
                        sorted = false;
                        break;
                    }
                }

                if (sorted)
                {
                    Console.WriteLine("yes");
                    Console.WriteLine("swap {0} {1}", left + 1, right + 1);
                }
                else if (reversed)
                {
                    Console.WriteLine("yes");
                    Console.WriteLine("reverse {0} {1}", left + 1, right + 1);
                }
                else
                {
                    Console.WriteLine("no");
                }
            }
        }
    }
}
