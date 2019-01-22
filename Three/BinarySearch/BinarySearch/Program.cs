using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree<int> binaryThree = new BinaryTree<int>();

            binaryThree.Add(10);  
            binaryThree.Add(8);   
            binaryThree.Add(12); 
            binaryThree.Add(11);   
            binaryThree.Add(14);
            binaryThree.Add(9);

            Console.WriteLine($"Three contains value 20:{binaryThree.ContainsValue(20)}");

        }
    }
}
