using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            HashTableNodeCollecton<int, string> hashTable = new HashTableNodeCollecton<int, string>();
            hashTable.Add(1, "Alex");
            hashTable.Add(2, "Tom");
            hashTable.Add(3, "Jeffrey");

            foreach (var item in hashTable)
            {
                Console.Write(item+ " ");
            }
        }
    }
}
