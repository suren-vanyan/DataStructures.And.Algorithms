using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableImplementation
{
    class HashTableNode<Tkey, Tvalue>
    {
        public HashTableNode(Tkey key, Tvalue value)
        {
            Value = value;
            _key = key;
        }

       
        public readonly Tkey _key;

        public Tvalue Value { get; set; }
        public Tkey Key { get => _key; }
    }
}
