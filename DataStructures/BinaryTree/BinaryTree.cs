using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace DataStructures.BinaryTree
{
    class BinaryTree
    {
        public TreeNode<int> Root { get; private set; }

        public BinaryTree(int data)
        {
            Root = new TreeNode<int>(data);
        }

        public void Add(int element)
        {
            if (Root == null)
            {
                Root.Data = element;
                return;
            }
            TreeNode<int> currentNode = Root;
            currentNode = Traverse(element, currentNode);
            currentNode.Data = element;
        }

        public TreeNode<int> Traverse(int element, TreeNode<int> node)
        {
            if (element > node.Data)
            {
                if (node.RightChild != null || node.RightChild.Data != element)
                    node = node.RightChild;
                else if (node.RightChild.Data == element)
                    return node;
                else
                    return node.RightChild;
            }
            else if (element < node.Data)
            {
                if (node.LeftChild != null || node.LeftChild.Data != element)
                    node = node.LeftChild;
                else if (node.LeftChild.Data == element)
                    return node;
                else
                    return node.LeftChild;
            }
            else
                return node;
            return Traverse(element, node);
        }

        public void Remove(int element)
        {
            if (Root.Data == element)
                throw new ArgumentException("You are trying to remove root");
            RemoveValue(Root, element);
        }

        private void RemoveValue(TreeNode<int> currentNode, int element)
        {
            TreeNode<int> removable;
            if (currentNode == null)
                return;
            currentNode = Traverse(element, currentNode);
            if (currentNode == null)
                return;
            if (currentNode.RightChild.Data == element)
            {
                removable = currentNode.RightChild;
                currentNode.RightChild = removable.RightChild;
                currentNode.LeftChild = removable.LeftChild;
                return;
            }
            if (currentNode.LeftChild.Data == element)
            {
                removable = currentNode.LeftChild;
                currentNode.RightChild = removable.RightChild;
                currentNode.LeftChild = removable.LeftChild;
                return;
            }
        }
    }
}
