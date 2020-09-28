using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace DataStructures.BinaryTree
{
    class BinaryTree<T> where T : IComparable<T>
    {
        public TreeNode<T> Root { get; private set; }

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
            currentNode = Traverse(element, currentNode);
            if (currentNode.Data.CompareTo(element) > 0)
                currentNode.LeftChild = new TreeNode<T>(element);
            else if (currentNode.Data.CompareTo(element) < 0)
                currentNode.RightChild = new TreeNode<T>(element);
            else
                return;
        }

        public TreeNode<T> Traverse(T element, TreeNode<T> node)
        {
            TreeNode<T> selectedNode;
            if (element.CompareTo(node.Data) > 0)
                selectedNode = node.RightChild;
            else if (element.CompareTo(node.Data) < 0)
                selectedNode = node.LeftChild;
            else
                return node;

            if (selectedNode != null)
                return Traverse(element, selectedNode);
            else
                return node;
        }

        public void Remove(T element)
        {
            if (Root.Data.CompareTo(element) == 0)
                throw new ArgumentException("You are trying to remove root");
            RemoveValue(Root, element);
        }

        private void RemoveValue(TreeNode<T> currentNode, T element)
        {
            TreeNode<T> removable;
            if (currentNode == null)
                return;
            currentNode = Traverse(element, currentNode);
            if (currentNode == null)
                return;
            if (currentNode.RightChild != null && currentNode.RightChild.Data.CompareTo(element) == 0)
            {
                removable = currentNode.RightChild;
                if (removable.LeftChild == null && removable.RightChild == null)
                    currentNode.RightChild = null;
                if (removable.LeftChild != null)
                    currentNode.RightChild = removable.LeftChild;
                if (removable.RightChild != null)
                {
                    currentNode = Traverse(removable.RightChild.Data, currentNode);
                    if (currentNode.Data.CompareTo(removable.RightChild.Data) > 0)
                        currentNode.LeftChild = removable.RightChild;
                    else if (currentNode.Data.CompareTo(removable.RightChild.Data) < 0)
                        currentNode.RightChild = removable.RightChild;
                }
                return;
            }
            if (currentNode.LeftChild != null && currentNode.LeftChild.Data.CompareTo(element) == 0)
            {
                removable = currentNode.LeftChild;
                if (removable.LeftChild == null && removable.RightChild == null)
                    currentNode.LeftChild = null;
                if (removable.LeftChild != null)
                    currentNode.RightChild = removable.LeftChild;
                if (removable.RightChild != null)
                {
                    currentNode = Traverse(removable.RightChild.Data, currentNode);
                    if (currentNode.Data.CompareTo(removable.RightChild.Data) > 0)
                        currentNode.LeftChild = removable.RightChild;
                    else if (currentNode.Data.CompareTo(removable.RightChild.Data) < 0)
                        currentNode.RightChild = removable.RightChild;
                }
                return;
            }
            return;
        }
    }
}
