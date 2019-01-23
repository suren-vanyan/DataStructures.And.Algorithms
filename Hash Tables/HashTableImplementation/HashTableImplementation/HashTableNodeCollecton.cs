using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableImplementation
{
    class HashTableNodeCollecton<Tkey,TValue>:IEnumerable<Tkey>
    {
        private LinkedList<HashTableNode<Tkey, TValue>> _nodeList;

        public void Add(Tkey key,TValue value)
        {
            if (_nodeList == null)
            {
                _nodeList = new LinkedList<HashTableNode<Tkey, TValue>>();
            }
            else
            {
                foreach (HashTableNode<Tkey,TValue> item in _nodeList)
                {
                    if (item.Key.Equals(key))
                    {
                        throw new ArgumentException("This key is already used");
                    }
                }
            }
            _nodeList.AddLast(new HashTableNode<Tkey, TValue>(key, value));
        }

        IEnumerator<Tkey> IEnumerable<Tkey>.GetEnumerator()
        {
            if(_nodeList!=null)
            foreach (var item in _nodeList)
            {
                yield return item.Key;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<Tkey>)this).GetEnumerator();
        }
    }
}
