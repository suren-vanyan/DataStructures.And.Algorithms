using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTreeNode<int> treeNode1 = new BinaryTreeNode<int>(6);
            BinaryTreeNode<int> treeNode2 = new BinaryTreeNode<int>(8);
            BinaryTreeNode<int> treeNode3 = new BinaryTreeNode<int>(4);

            if (treeNode1.ComareNode(treeNode2) >= 0) { treeNode1.Left = treeNode2; }  
            else { treeNode1.Right = treeNode2; }                                      
                                                                                        
            if (treeNode1.ComareNode(treeNode3) >= 0) { treeNode1.Left = treeNode3; }                                                                  // 4    8
            else { treeNode1.Right = treeNode3; }

            Console.WriteLine($"  {treeNode1.Value}");
            Console.Write(treeNode3.Value);
            Console.WriteLine($"   {treeNode2.Value}");
        }
    }
}
