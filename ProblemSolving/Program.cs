using System;
using System.Linq;

namespace ProblemSolving
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Console.WriteLine(simpleArraySum(input));
        }

        static int simpleArraySum(int[] ar)
        {
            int sum = 0;

            for (int i = 0; i < ar.Length ; i++)
            {
                sum += ar[i];
            }

            return sum;

        }
    }
}
