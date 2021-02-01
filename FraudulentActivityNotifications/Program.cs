using System;
using System.Collections.Generic;
using System.Linq;

namespace FraudulentActivityNotifications
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = input[0];
            int d = input[1];

            var costs = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Console.WriteLine(ActivityNotifications(costs , d));
           


        }

        static int ActivityNotifications(int[] expenditure, int d)
        {
           


            var n = expenditure.Length - d;
            var notice = 0;
            for (int i = 0; i < n - 1; i++)
            {
                
               int[] array = expenditure.Take(d).ToArray();
               //BubbleSort(array);
               array = MergeSort(array);
                double median = 0;
                var middle = 0;
                if(array.Length % 2 == 0)
                {
                    middle = array.Length / 2;
                    median = (array[middle] + array[middle - 1]) / 2.0; 
                }
                else
                {
                     middle = array.Length / 2;
                     median = array[middle];
                }

                //var arrayCheck = stack.ToArray();

                if(expenditure[d] >= median * 2)
                {
                    notice++;
                }
               expenditure = expenditure.Where((item, index) => index != 0).ToArray();
                // expenditure = expenditure.Skip(1).ToArray();
               //stack.Pop();
            }

            return notice;
        }

        private static void BubbleSort(int[] array)
        {
            var isSorted = false;
            var i = 0;
            while (!isSorted)
            {
                isSorted = true;

                for (int j = 1; j < array.Length-i; j++)
                {
                    if(array[j - 1] > array[j])
                    {
                        Swap(array, j - 1, j);
                        isSorted = false;

                    }
                }

                i += 1;
            }

        }

        private static void Swap(int[] nums, int first, int sec)
        {
            var temp = nums[first];
            nums[first] = nums[sec];
            nums[sec] = temp;
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
