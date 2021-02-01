using System;
using System.Linq;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //int n = int.Parse(Console.ReadLine());
            //var path = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string s = Console.ReadLine();
            long n = int.Parse(Console.ReadLine());

            Console.WriteLine(RepeatedString(s,  n));

        }

        static long RepeatedString(string s, long n)
        {
            long count = (n / s.Length); //broi subiraniq cqla
            long countLetters = (n % s.Length); //ostanali bukvi
            long matches = 0;
            long matches2 = 0;
            long totalMatches = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if(s[i] == 'a')
                {
                    matches++;
                }
            }

            for (int i = 0; i < countLetters; i++)
            {
                if(s[i] == 'a')
                {
                    matches2++;
                }
            }

            totalMatches = (matches * count) + matches2;
            return totalMatches;
        }
        static int JumpingOnClouds(int[] c)
        {
            int count = 0;
            int i = 0;
            while (i < c.Length - 1)
            {
                if(i + 2 < c.Length)
                {
                    if (c[i + 2] == 0)
                    {
                        count++;
                        i += 2;
                    }
                    else
                    {
                        i += 1;
                        count++;
                    }

                }
                else
                {
                    i += 1;
                    count++;
                }



            }

            return count;

        }

        public static int CountingValleys(int steps, string path)
        {
            int level = 0;
            int valleys = 0;

            for (int i = 0; i < steps; i++)
            {
                if (path[i] == 'U')
                {
                    if (++level == 0)
                    {
                        valleys++;
                    }
                }
                else
                {
                    level--;
                }
            }

            return valleys;

        }

        static int SockMerchant(int n, int[] arr)
        {
            var arrBoll = new bool[n];
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[i] == arr[j] && arrBoll[i] == false  && arrBoll[j] == false )
                    {
                        count++;
                        arrBoll[i] = true;
                        arrBoll[j] = true;
                    }
                   


                 }
            }

            return count;
        }
    }
}
