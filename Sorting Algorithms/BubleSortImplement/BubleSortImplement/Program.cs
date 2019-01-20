using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubleSortImplement
{
    //Bubble sort has a worst-case and average complexity of О(n2),
    //where n is the number of items being sorted.
    //Most practical sorting algorithms have substantially 
    //better worst-case or average complexity, often O(n log n).
    //Even other О(n2) sorting algorithms, such as insertion sort,
    //generally run faster than bubble sort, and are no more complex.
    //Therefore, bubble sort is not a practical sorting algorithm.

    class Program
    {
        public static void Swap<T>(T[] array,int left,int right)//O(1)+O(1)+O(1)=O(max(1,1,1)) = O(1).
        {
            T temp = array[right];//O(1)
            array[right] = array[left];//O(1)
            array[left] = temp;//O(1)

        }
        public static void BubleSort(int [] array) 
        {      
            for (int i = 0; i < array.Length-1; i++)//2*(a1)*(n-1)d/2*n
            {
                bool check = true;//O(1)
                for (int j = 0; j < array.Length-1-i; j++)//O((n-k)*1)=O(n-k)
                {
                    if (array[j] > array[j + 1])//O(1)
                    {
                        check = false;//O(1)
                        Swap(array, j, j+1);
                        //sum=O(1)
                    }
                }

                //if the array is already sorted will stop the loop
                if (check)
                    break;
            }//T(n) = (2 * (n - 1) + (n - 1) * (-1)) / 2 * n = n ^ 2 / 2 , 
        }

        public static void PrintItems(int[] array)
        {
            foreach (var item in array)
            {
                Console.WriteLine(item+"\t");
            }
        }
        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 8, 2, 1, 8, 5,11,6,5 };
            BubleSort(array);
            PrintItems(array);
        }
    }
}
