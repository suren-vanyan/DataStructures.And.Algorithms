using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch_InsertionSort
{
    class Program
    {
        static void InsertionSort(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                int key = array[i];
                int j = i - 1;
                while (j>=0&&array[j]>key)
                {
                    array[j + 1] = array[j];
                    j--;
                }
                array[j+1] = key;
            }
        }

        static bool BinarySearch(int[] array,int element)
        {
            int min = 0;
            int max = array.Length - 1;
            
            for (int i = min; i <= max; i++)
            {
                int middle = array.Length / 2;
                if (element < array[middle])
                    max = middle - 1;
                if (element > array[middle])
                    min = middle + 1;
                if (element == array[middle])
                    return true;
                
            }

            return false;
        }
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] array = new int[8];          
            GeneratingRandomItem(array,random);
            Print(array, "Before Sorting");
            InsertionSort(array);
            Print(array, "After Sorting");
            Console.WriteLine($"Array Contains element 10 {BinarySearch(array, 10)}");

        }

        static void Print(int[] array,string content)
        {
            Console.WriteLine(content);
            foreach (var item in array)
            {
                Console.Write(item+ " ");
            }
            Console.WriteLine();
        }
        static void GeneratingRandomItem(int[] array,Random random)
        {

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(1, 15);
            }
        }
    }
}
