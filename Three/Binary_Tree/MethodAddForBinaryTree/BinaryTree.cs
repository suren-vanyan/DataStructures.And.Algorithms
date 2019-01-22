using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAddForBinaryTree
{
    class BinaryTree<T>:IEnumerable<T>where T:IComparable<T>
    {
        private BinaryTreeNode<T> _head;

        private int _count;
        public int Count { get => _count; }

    
        #region Method Add

        public void Add(T value)
        {
            if (_head == null)
            {
                _head = new BinaryTreeNode<T>(value);
            }
            else
            {
                AddTo(_head,value);
            }
            _count++;
        }
        #endregion

        #region Method AddTo recursion
        public void AddTo(BinaryTreeNode<T> nodeHead,T value)
        {
            if (nodeHead.Value.CompareTo(value) >= 0)
            {
                if (nodeHead.Left == null)
                {
                    nodeHead.Left = new BinaryTreeNode<T>(value);
                }
                else
                {
                    AddTo(nodeHead.Left,value);
                }
            }
            else
            {
                if (nodeHead.Right == null)
                {
                    nodeHead.Right = new BinaryTreeNode<T>(value);
                }
                else
                {
                    AddTo(nodeHead.Right,value);
                }
            }
        }
        #endregion

        #region IEnumerable
        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
