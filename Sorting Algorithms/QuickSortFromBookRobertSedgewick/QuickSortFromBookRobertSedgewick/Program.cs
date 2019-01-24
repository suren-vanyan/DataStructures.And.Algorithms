using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSortFromBookRobertSedgewick
{
    class QucikSort
    {
        public static void Swap(int[] array ,int indexOne, int indexTwo)
        {
            int temp = array[indexOne];
            array[indexOne] = array[indexTwo];
            array[indexTwo] = temp;

        }
        //Robert Sedgewick and Kevin Wayne
        public static int Partition(int[] array, int start, int end)
        {          
            int marker = start;//divides left and right subarrays
            for (int i = start; i <= end; i++)
            {
                if (array[i] < array[end]) //array[end] is pivot
                {
                    if(i!=marker)
                    Swap(array,i,marker);
                    marker += 1;
                }
            }
            //put pivot(array[end]) between left and right subarrays
            Swap(array,marker,end);
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
            int[] array = { 7, 4, 4, 6, 5, 9,12,18,8};
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
