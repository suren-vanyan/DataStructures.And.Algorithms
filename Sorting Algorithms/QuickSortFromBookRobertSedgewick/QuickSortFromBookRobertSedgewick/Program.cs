using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSortFromBookRobertSedgewick
{
    class QucikSort
    {
        //Robert Sedgewick and Kevin Wayne
        public static int Partition(int[] array, int start, int end)
        {
            int temp;//swap helper
            int marker = start;//divides left and right subarrays
            for (int i = start; i <= end; i++)
            {
                if (array[i] < array[end]) //array[end] is pivot
                {
                    temp = array[marker]; // swap
                    array[marker] = array[i];
                    array[i] = temp;
                    marker += 1;
                }
            }
            //put pivot(array[end]) between left and right subarrays
            temp = array[marker];
            array[marker] = array[end];
            array[end] = temp;
            return marker;
        }

        public static void QuickSortDividePart(int[] array, int start, int end)
        {
            if (start >= end)
            {
                return;
            }
            int pivot = Partition(array, start, end);
            QuickSortDividePart(array, start, pivot - 1);
            QuickSortDividePart(array, pivot + 1, end);
        }
        static void Main(string[] args)
        {
            int[] array = { 7, 4, 4, 6, 5, 9, 12, 19, 2, 8 };
            Print(array, "Before Sorting");
            QuickSortDividePart(array, 0, array.Length - 1);

            Print(array, "After Sorting");

        }

        public static void Print(int[] array, string str)
        {
            Console.WriteLine(str);
            foreach (var item in array)
            {
                Console.Write(item + " ");

            }
            Console.WriteLine();
        }
    }
}
