using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Tree
{
    class BinaryTreeNode<TNode> : IComparable<TNode> where TNode:IComparable<TNode>
    {
        public BinaryTreeNode(TNode value)
        {
            Value = value;
        }
        public TNode Value { get; set; }

        public BinaryTreeNode<TNode> Left { get; set; }
        public BinaryTreeNode<TNode> Right { get; set; }

        public int CompareTo(TNode other)
        {
            return Value.CompareTo(other);
        }

        public int ComareNode(BinaryTreeNode<TNode> node)
        {
            return this.Value.CompareTo(node.Value);
        }
    }
}
