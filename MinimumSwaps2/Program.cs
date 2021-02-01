using System;
using System.Linq;

namespace MinimumSwaps2
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            var arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int count = 0;
            int i = 0;
            while (i < arr.Length)
            {

                // If current element is 
                // not at the right position 
                if (arr[i] != i + 1)
                {

                    while (arr[i] != i + 1)
                    {
                        int temp = 0;

                        // Swap current element 
                        // with correct position 
                        // of that element 
                        temp = arr[arr[i] - 1];
                        arr[arr[i] - 1] = arr[i];
                        arr[i] = temp;
                        count++;
                    }
                }

                // Increment for next index 
                // when current element is at 
                // correct position 
                i++;
            }
            Console.WriteLine(count); 
        }
    }
}
