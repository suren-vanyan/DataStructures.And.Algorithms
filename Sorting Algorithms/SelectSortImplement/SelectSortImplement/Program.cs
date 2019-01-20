using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectSortImplement
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
        public static void SelectSort(int[] array)
        {
            int assumedSmallerIndex = 0;
            while (assumedSmallerIndex < array.Length)
            {
                int foundSmallestIndex = FindSmallestIndex(array, assumedSmallerIndex);
                Swap(ref array[foundSmallestIndex], ref array[assumedSmallerIndex]);
                assumedSmallerIndex++;
            }

        }

        public static int FindSmallestIndex(int[] array, int smallerIndex)
        {
            int smallerValue = array[smallerIndex];
            for (int i = smallerIndex + 1; i < array.Length; i++)
            {
                if (array[i] < smallerValue)
                {
                    smallerValue = array[i];
                    smallerIndex = i;
                }
            }
            return smallerIndex;
        }
        static void Main(string[] args)
        {
            int[] array = new int[] { 11, 8, 2, 7,13,2,25,3};
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
