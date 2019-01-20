using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSortImplement
{
    // The steps are:
    //1․Pick an element, called a pivot, from the array.

    //2․Partitioning: reorder the array so that all elements with values less than the pivot 
    //come before the pivot, while all elements with values greater than the pivot come after 
    //it(equal values can go either way). After this partitioning, the pivot is in its final position.
    //This is called the partition operation.

    //3․Recursively apply the above steps to the sub-array of elements with smaller values and 
    //separately to the sub-array of elements with greater values.
    class Program
    {
        public static void Swap<T>(T[] array, int left, int right)
        {
            T temp = array[left];
            array[left] = array[right];
            array[right] = temp;

        }
        public static void QuickSort(int[] array)
        {
            DivideIntoPart(array, 0, array.Length - 1);
        }

        public static void DivideIntoPart(int[] array, int left, int right)
        {
            // Random number for pivotIndex   
            Random random = new Random();
            if (left < right)
            {
                int pivotIndex = random.Next(left, right);
                int newPivotIndex = PartitionSort(array, left, right, pivotIndex);
                DivideIntoPart(array, left, newPivotIndex - 1);
                DivideIntoPart(array, newPivotIndex + 1, right);

            }
        }

        public static int PartitionSort(int[] array, int left, int right, int pivotIndex)
        {
            int pivotValue = array[pivotIndex];
            Swap(array, pivotIndex, right);// Moving to the end to remember the place
                                           //and we consider it to be the biggest

            int temIndex = left;
            for (int i = left; i < array.Length; i++)
            {
                if (array[i] < pivotValue)
                {
                    if (left != right)
                    {
                        Swap(array, i, temIndex);
                        temIndex++;
                    }
                }
            }

            Swap(array, temIndex, right);//to the left are elements that are smaller than him, to the right are big than
            return temIndex;
        }
        static void Main(string[] args)
        {
            int[] array = new int[] { 5, 6, 2, 4, 10, 5, 6, 9 };
            QuickSort(array);
            foreach (var item in array)
            {
                Console.WriteLine(item + " ");
            }

        }
    }
}
