using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListNode
{
    class Program
    {
        static void Main(string[] args)
        {
            //[(first)Value=11.5|Next=null]
            LinkedListNode<double> firstNode = new LinkedListNode<double>(11.5);

            //[(first)Value=11.5|Next=null]-->[(second)Value=20|Next=null]
            LinkedListNode<double> secondNode = new LinkedListNode<double>(20);

            //[(first)Value=11.5|Next=secondNode]-->[(second)Value=20|Next=null]
            firstNode.Next = secondNode;
            Console.WriteLine(firstNode.Value);
            Console.WriteLine(firstNode.Next.Value);
        }
    }
}
