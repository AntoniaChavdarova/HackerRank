using System;
using System.Linq;

namespace SortingBubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            var arrray = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int count = 0;

            var isSorted = false;
            var i = 0;

            while (!isSorted)
            {
                isSorted = true;

                for (int j = 1; j < arrray.Length - i; j++)
                {
                    if (arrray[j - 1] > arrray[j])
                    {
                        isSorted = false;
                        Swap(arrray, j - 1, j);
                        count++;
                    }
                }

                i += 1;

            }

            Console.WriteLine($"Array is sorted in {count} swaps.");
            Console.WriteLine($"First Element: {arrray[0]}");
            Console.WriteLine($"Last Element: {arrray[arrray.Length-1]}");
            


        }

        private static void Swap(int[] nums, int first, int sec)
        {

           var temp = nums[first];
            nums[first] = nums[sec];
            nums[sec] = temp;
        }
    }
}
