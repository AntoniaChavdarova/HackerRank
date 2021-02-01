using System;
using System.Collections.Generic;

namespace Fibbonachi
{
    class Program
    {
        private static Dictionary<int, long> memo;
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            memo = new Dictionary<int, long>();

            Console.WriteLine(GetFibonacci(n));
            Console.WriteLine(FibonacciWithBottomUpDP(n));
            FibonacciIterative(n);

          
        }
        public static void FibonacciIterative(int len)
        {
            int a = 0, b = 1, c = 0;
            Console.Write("{0} {1}", a, b);
            for (int i = 2; i < len; i++)
            {
                c = a + b;
                Console.Write(" {0}", c);
                a = b;
                b = c;
            }
        }
        private static long GetFibonacci(int n)
        {
            if (memo.ContainsKey(n))
            {
                return memo[n];
            }

            if (n <= 2)
            {
                return 1;
            }

            var result = GetFibonacci(n - 1) + GetFibonacci(n - 2);
            memo[n] = result;

            return result;
        }

        private static long FibonacciWithBottomUpDP(int n)
        {
            long[] fibonacciNumbers = new long[n + 1];

            fibonacciNumbers[0] = 1;
            fibonacciNumbers[1] = 1;
            for (int i = 2; i <= n; i++)
            {
                fibonacciNumbers[i] =
                        fibonacciNumbers[i - 1] + fibonacciNumbers[i - 2];
            }

            return fibonacciNumbers[n];
        }
    }
}
