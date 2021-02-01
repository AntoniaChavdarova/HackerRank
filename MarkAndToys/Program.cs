using System;
using System.Linq;

namespace MarkAndToys
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var prices = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var budget = input[1];


            // Console.WriteLine(String.Join(" " , MergeSort(prices)));
            Console.WriteLine(MaximumToys(prices , budget));
        }

        static int MaximumToys(int[] prices, int k)
        {
            var sorting = MergeSort(prices);
           
            int i = 0;
            int count = 0;

            while (k > 0)
            {
                k -= sorting[i];
                i++;
                if(k > 0)
                {
                    count++;
                }
               
            }

            return count;

        }

        private static int[] MergeSort(int[] nums)
        {
            if (nums.Length == 1)
            {
                return nums;
            }

            var middleIdx = nums.Length / 2;
            var left = nums.Take(middleIdx).ToArray();
            var right = nums.Skip(middleIdx).ToArray();

            return MergeArrays(MergeSort(left), MergeSort(right));
        }

        private static int[] MergeArrays(int[] left, int[] right)
        {
            var sorted = new int[left.Length + right.Length];
            var mergedIdx = 0;
            var leftIdx = 0;
            var rightIdx = 0;

            while (leftIdx < left.Length && rightIdx < right.Length)
            {
                if (left[leftIdx] < right[rightIdx])
                {
                    sorted[mergedIdx++] = left[leftIdx++];
                }
                else
                {
                    sorted[mergedIdx++] = right[rightIdx++];
                }

            }

            while (leftIdx < left.Length)
            {
                sorted[mergedIdx++] = left[leftIdx++];

            }

            while (rightIdx < right.Length)
            {
                sorted[mergedIdx++] = right[rightIdx++];

            }

            return sorted;

        }
    }
}