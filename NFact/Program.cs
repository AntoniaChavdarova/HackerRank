using System;

namespace NFact
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            Console.WriteLine(NFact(n));
            NFactWithLoop(n);
        }

        private static void NFactWithLoop(int n)
        {
            long sum = 1;
            for (int i = 1; i <= n; i++)
            {
                sum *= i;
            }

            Console.WriteLine(sum);
        }

        private static long NFact(int n)
        {
            if(n == 1)
            {
                return 1;
            }

            return n * NFact(n - 1);
        }
    }
}
