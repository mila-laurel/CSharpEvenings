using System;
using System.Diagnostics.CodeAnalysis;
using System.Security.Principal;

namespace DataStructures.BinaryTree
{
    class TreeNode<T> where T : IComparable<T>
    {
        
        public T Data { get; set; }
        public TreeNode<T> LeftChild { get; set; }
        public TreeNode<T> RightChild { get; set; }

        public TreeNode(T data, TreeNode<T> left = null, TreeNode< T > right = null)
        {
            Data = data;
            LeftChild = left;
            RightChild = right;
        }
    }
}