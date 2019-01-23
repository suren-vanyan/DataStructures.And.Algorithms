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
            _value = value;
            _key = key;
        }

        public readonly Tvalue _value;
        public readonly Tkey _key;

        public Tvalue Value { get => _value; }
        public Tkey Key { get => _key; }
    }
}
