using System;
using System.Linq;

namespace ArraysLeft_Rotation
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int size = nums[0];
            int rotations = nums[1];

            var array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            
            Console.WriteLine(String.Join(" " , RotLeft(array , rotations)));

            static int[] RotLeft(int[] array, int rotations)
            {
                
                for (int i = 0; i < rotations; i++)
                {
                    var temp = array[0];

                    for (int  j = 0;  j < array.Length - 1;j ++)
                    {
                        
                        array[j] = array[j + 1];
                       
                        
                    }

                    array[array.Length - 1] = temp;
                }

                return array;
            }


        }
    }
}
