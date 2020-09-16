using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace DataStructures.BinaryTree
{
    class BinaryTree<T> : IComparable<T>
    {
        public TreeNode<T> Root { get; private set; }
        public delegate Func<T, T, bool> compare();

        public BinaryTree(T data)
        {
            Root = new TreeNode<T>(data);
            
        }

        public void Add(T element)
        {
            if (Root == null)
            {
                Root.Data = element;
                return;
            }
            TreeNode<T> currentNode = Root;
            Traverse(element, currentNode);
        }

        public void Traverse(T element, TreeNode<T> node)
        {
            if (element.Equals(node.Data))
                node = node.RightChild;
            else
                node = node.LeftChild;
            Traverse(element, node);
        }

        public void Remove(T element)
        {
            TreeNode<T> rootNode = new TreeNode<T>(element, Root);
            RemoveValue(rootNode, rootNode.RightChild, element);
            rootNode = Root;
        }

        private void RemoveValue(TreeNode<T> parentNode, TreeNode<T> currentNode, T element)
        {
            if (currentNode == null)
                return;

            if (currentNode.Data.Equals(element))
            {
                parentNode.RightChild = currentNode.RightChild;
                return;
            }

            RemoveValue(currentNode, currentNode.RightChild, element);
        }

        public int CompareTo([AllowNull] T other)
        {
            if (other == null)
                return 0;
            return 1;
        }
    }
}
