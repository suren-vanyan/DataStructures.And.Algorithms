using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectSortAnotherImplementation
{
    class Program
    {
        //The selection sort algorithm sorts an array by repeatedly finding the minimum element
        //(considering ascending order) from unsorted part and putting it at the beginning.
        //The algorithm maintains two subarrays in a given array.

        //1) The subarray which is already sorted.
        //2) Remaining subarray which is unsorted.

        //In every iteration of selection sort, the minimum element(considering ascending order)
        //from the unsorted subarray is picked and moved to the sorted subarray.

        public static void Swap(ref int first, ref int second)
        {
            if (first == second) return;
            first ^= second;
            second ^= first;
            first ^= second;
        }

       // Time Complexity: O(n2) as there are two nested loops.
        public static void SelectSort(int[] array)
        {           
            for (int i = 0; i < array.Length; i++)
            {
               int smallestIndex = i;
                for (int j = i+1; j < array.Length; j++)
                {
                    if (array[smallestIndex] > array[j])
                    {
                        smallestIndex = j;
                    }
                }
                Swap(ref array[smallestIndex], ref array[i]);
            }

        }

        
        static void Main(string[] args)
        {
            int[] array = new int[] { 9, 4, 5, 13, 3, 8 };
            PrintItems(array, "After Sorting");
            SelectSort(array);
            PrintItems(array, "Before Sorting");
        }

        public static void PrintItems(int[] array, string content)
        {
            Console.WriteLine(content);
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}

