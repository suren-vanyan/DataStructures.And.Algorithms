using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSortImplement
{
    /// <summary>
    /// In sorting n objects, merge sort has an average and worst-case performance of O(n log n).
    /// If the running time of merge sort for a list of length n is T(n), then the recurrence T(n) = 2T(n/2) + n 
    /// follows from the definition of the algorithm (apply the algorithm to two lists of half the size
    /// of the original list, and add the n steps taken to merge the resulting two lists).
    /// The closed form follows from the master theorem for divide-and-conquer recurrences.
    /// In the worst case, the number of comparisons merge sort makes is given by the sorting numbers.
    /// These numbers are equal to or slightly smaller than (n ⌈lg n⌉ - 2⌈lg n⌉ + 1),
    /// which is between (n lg n - n + 1) and (n lg n + n + O(lg n)).[5]
    /// </summary>
    class Program
    {
       
        public static void ArrayCopy(int[] sourceArray, int sourceIndex, int[] destinationArray, int destinationIndex, int length)
        {
            for (int i = sourceIndex, j = destinationIndex; i < length; i++, j++)
            {
                destinationArray[j] = sourceArray[i];
            }
        }
        public static void MergeSort(int[] array)
        {
            if (array.Length == 1) return;

            int leftLength = array.Length / 2;
            int rightLength = array.Length - leftLength;

            int[] leftSubArr = new int[leftLength];
            int[] rightSubArr = new int[rightLength];



            ArrayCopy(array, 0, leftSubArr, 0, leftLength);
            ArrayCopy(array, leftLength, rightSubArr, 0, array.Length);

            MergeSort(leftSubArr);
            MergeSort(rightSubArr);
            Merge(array, leftSubArr, rightSubArr);

        }

        public static void Merge(int[] array, int[] leftSubArr, int[] rightSubArr)
        {
            int leftIndex = 0;
            int rightIndex = 0;
            int temporaryIndex = 0;
            int totalLength = leftSubArr.Length + rightSubArr.Length;
            while (totalLength > 0)
            {
                if (leftIndex >= leftSubArr.Length)
                {
                    array[temporaryIndex++] = rightSubArr[rightIndex++];
                }
                else if (rightIndex >= rightSubArr.Length)
                {
                    array[temporaryIndex++] = leftSubArr[leftIndex++];
                }
                else if (leftSubArr[leftIndex] < rightSubArr[rightIndex])
                {
                    array[temporaryIndex++] = leftSubArr[leftIndex++];
                }
                else
                {
                    array[temporaryIndex++] = rightSubArr[rightIndex++];
                }
                totalLength--;
            }
        }

        public static void PrintArray(int[] array,string content)
        {
            Console.WriteLine(content);
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            int[] array = new int[] { 7, 9, 5, 2, 8, 6, 10, 9 };
            PrintArray(array, "Before Sorting");
            MergeSort(array);
            PrintArray(array, "After Sorting");
           
        }
    }
}
