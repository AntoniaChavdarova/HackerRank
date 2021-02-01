using System;
using System.Linq;

namespace Arrays
{
    class Program
    {
        private static int[,] matrix;
        static void Main(string[] args)
        {
            int r = 6;
            int c = 6;

            matrix = ReadMatrix(r, c);
            
            Console.WriteLine(HourglassSum(matrix));
               
        }

        static int HourglassSum(int[,] matrix)
        {
            int max = int.MinValue;
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    if (j + 2 < 6 && i + 2 < 6)
                    {
                        int sum =
                            matrix[i, j] +
                            matrix[i, j + 1] +
                            matrix[i, j + 2] +
                            matrix[i + 1, j + 1] +
                            matrix[i + 2, j] +
                            matrix[i + 2, j + 1] +
                            matrix[i + 2, j + 2];

                        if (sum > max)
                        {
                            max = sum;
                        }
                    }
                }
            }

            return max;

        }

        private static int[,] ReadMatrix(int row, int col)
        {
            var matrix = new int[row , col];

            for (int r = 0; r < row; r++)
            {
                var line = Console.ReadLine().Split().Select(int.Parse).ToArray();
                

                for (int c = 0; c < col; c++)
                {
                    matrix[r,c] = line[c];
                }
            }

            return matrix;
        }
    }
}
