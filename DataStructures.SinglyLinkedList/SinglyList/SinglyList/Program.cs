using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinglyList
{
    
    class Program
    {
        public static void PrintNode(Node node)
        {
            while (node != null)
            {
                Console.WriteLine(node.Value);
                node = node.Next;

            }
        }
        static void Main(string[] args)
        {
            Node nodeFirst = new Node { Value = 3 };//Initialize of the first Node of the list value 3
            //[3|null]-->[4|null]

            Node nodeSecond = new Node { Value = 4 };//Initialize of the second Node of the list value 4

            //[3|ref]-->[4|null]
            nodeFirst.Next = nodeSecond;

            //[3|ref]-->[4|null]-->[6|null]
            Node nodeThree = new Node { Value = 6 };

            //[3|ref]-->[4|ref]-->[6|null]
            nodeSecond.Next = nodeThree;

            PrintNode(nodeFirst);

        }
    }
}
