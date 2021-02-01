using System;
using System.Collections.Generic;
using System.Linq;

namespace AlmostSorted
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var arr =  Console.ReadLine().Split().Select(int.Parse).ToArray();

            AlmostSorted(arr);
        }

        static void AlmostSorted(int[] arr)
        {
            if (IsAlreadySorted(arr))
            {
                
                Console.WriteLine("yes");
                return;

            }
            else 
            
            {
                if (BubbleSort(arr))
                {
                    Reversed(arr);
                }
                else
                {
                    return;
                }
                    
            }
            
               

          



        }

        private static void Reversed(int[] arr)
        {
            var list = new List<int>();
           // var list2 = new List<int>();
            for (int i = 1; i < arr.Length - 1; i++)
            {
                if(arr[0] > arr[1])
                {
                    Console.WriteLine("no");
                    return;
                }
                
                if (arr[i - 1] > arr[i])
                {
                   list = arr.Skip(i - 1).ToList();
                    break;

                }
               
               
            }

            for (int i = list.Count - 1; i >= 0; i--)
            {
                if(list[i] > list[i - 1])
                {
                     list.RemoveAt(i);
                    break;
                }
            }

            list.Reverse();
            if (IsAlreadySorted(list.ToArray()))
            {
                Console.WriteLine("yes");
                Console.WriteLine($"reverse {list[0]} {list[list.Count - 1]}");
            }
            else
            {
                Console.WriteLine("no");
            }
           

        }

        private static bool BubbleSort(int[] array)
        {
            var isSorted = false;
            var i = 0;
            int count = 0;
            var firstEl = 0;
            var secEl = 0;
            var copyArray = new int[array.Length];
            array.CopyTo(copyArray , 0);
            while (!isSorted)
            {
                isSorted = true;
               

                for (int j = 1; j < array.Length - i; j++)
                {
                    if (copyArray[j - 1] > copyArray[j])
                    {
                        Swap(copyArray, j - 1, j);
                        count++;
                        firstEl = j ;
                        secEl = j + 1;
                        isSorted = false;

                    }
                }

                i += 1;
            }

            if(count == 1)
            {
                Console.WriteLine("yes");
                Console.WriteLine($"swap {firstEl} {secEl}");
                return false;
            }
            else
            {
                return true;
            }



        }

        private static void Swap(int[] array, int first, int sec)
        {
            var temp = array[first];
            array[first] = array[sec];
            array[sec] = temp;

        }

        private static bool IsAlreadySorted(int[] arr)
        {
            bool isSorted = false;

            for (int i = 1; i < arr.Length ; i++)
            {
              

                if (arr[i - 1] < arr[i])
                {
                    isSorted = true;
                }
                else
                {
                    isSorted = false;
                    return false;
                }
            }

            return true;
        }
    }
}
