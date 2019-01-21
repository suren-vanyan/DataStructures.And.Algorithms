using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSortImplement
{
    class Program
    {
        public static void Swap<T>(T[] array, int firtIndex, int secondIndex)
        {
            T temp = array[firtIndex];
            array[firtIndex] = array[secondIndex];
            array[secondIndex] = temp;

        }

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
            int length = leftSubArr.Length + rightSubArr.Length;
            while (length > 0)
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
                length--;
            }
        }

        static void Main(string[] args)
        {
            int[] array = new int[] { 7, 9, 5, 2, 8, 6, 10, 9 };
            MergeSort(array);
            Console.WriteLine("After Sorting");
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
        }
    }
}
