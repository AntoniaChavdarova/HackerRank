using System;
using System.Linq;

namespace FormingMagicSquare
{
    class Program
    {
        private static int[,] matrix;
        static void Main(string[] args)
        {
            matrix = ReadMatrix(3 , 3);
           
            Console.WriteLine(SumMatrix(matrix));
            
        }

        private static int SumMatrix(int[,] matrix)
        {
            int[,] square =
                 {
                     { 4, 9, 2, 3, 5, 7, 8, 1, 6 },
                     { 2, 7, 6, 9, 5, 1, 4, 3, 8 },
                     { 6, 1, 8, 7, 5, 3, 2, 9, 4 },
                     { 8, 3, 4, 1, 5, 9, 6, 7, 2 },
                     { 2, 9, 4, 7, 5, 3, 6, 1, 8 },
                     { 6, 7, 2, 1, 5, 9, 8, 3, 4 },
                     { 8, 1, 6, 3, 5, 7, 4, 9, 2 },
                     { 4, 3, 8, 9, 5, 1, 2, 7, 6 }
            };

            int min = int.MaxValue;

            for (int i = 0; i < square.GetLength(0); i++)
            {
                int total = 0;
                for (int j = 0; j < square.GetLength(1); j++)
                {
                    total += Math.Abs(matrix[j / 3, j % 3] - square[i, j]);
                }

                if(total < min)
                {
                    min = total;
                }

            }

            return min;
        }


    

        private static int[,] ReadMatrix(int row, int col)
        {
            var table = new int[row , col];
            for (int r = 0; r < row; r++)
            {
                var input = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int c = 0; c < col; c++)
                {
                   table[r, c] = input[c];
                }
            }

            return table;
        }
    }
}
