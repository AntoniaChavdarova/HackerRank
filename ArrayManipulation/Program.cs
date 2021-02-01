using System;
using System.Linq;

namespace ArrayManipulation
{
    class Program
    {
        private static int[,] matrix;
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var sizeOfArray = input[0];
            var operations = input[1];
           
            matrix = ReadMatrix(operations, operations);

            var array = new long[sizeOfArray + 2];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {

                var a = matrix[i, 0];
                var b = matrix[i, 1];
                var k = matrix[i, 2];
                array[a] += k;    //prefix sum alg
                array[b + 1] -= k;


            }


            Console.WriteLine(GetMax(array));
           

        }

        private static long GetMax(long[] array)
        {
            long max = long.MinValue;
            long sum = 0;

            foreach (var item in array)
            {
                sum += item;
                max = Math.Max(max, sum);
            }

            return max;
        }

        private static int[,] ReadMatrix(int row, int col)
        {
            var matrix = new int[row, col];

            for (int r = 0; r < row; r++)
            {
                var line = Console.ReadLine().Split().Select(int.Parse).ToArray();


                for (int c = 0; c < col; c++)
                {
                    matrix[r, c] = line[c];
                }
            }

            return matrix;
        }
    }
}
