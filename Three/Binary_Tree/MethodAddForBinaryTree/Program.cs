using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAddForBinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree<int> binaryTree = new BinaryTree<int>();
            binaryTree.Add(7);
            binaryTree.Add(5);
            binaryTree.Add(8);
            binaryTree.Add(5);
            binaryTree.Add(8);
            binaryTree.Add(10);
            binaryTree.Add(15);
            Console.WriteLine();
        }
    }
}
