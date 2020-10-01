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
            if (Root != null)
            {
                if (Root.Data.CompareTo(element) == 0)
                    Root = Assign(Root);
                else
                RemoveValue(Root, element);
            }
            else
                return;
        }

        private void RemoveValue(TreeNode<T> currentNode, T element)
        {
            TreeNode<T> removable;

            currentNode = TraverseToRemove(element, currentNode);
            if (currentNode == null)
                return;
            if (currentNode.RightChild != null && currentNode.RightChild.Data.CompareTo(element) == 0)
            {
                removable = currentNode.RightChild;
                currentNode.RightChild = Assign(removable);
            }
            else if (currentNode.LeftChild != null && currentNode.LeftChild.Data.CompareTo(element) == 0)
            {
                removable = currentNode.LeftChild;
                currentNode.LeftChild = Assign(removable);
            }
            else
                return;
        }

        public TreeNode<T> TraverseToRemove(T element, TreeNode<T> node)
        {
            TreeNode<T> selectedNode;
            if (node.RightChild != null)
            {
                if (element.CompareTo(node.Data) > 0 && element.CompareTo(node.RightChild.Data) != 0)
                    selectedNode = node.RightChild;
                else
                    selectedNode = node;
            }
            else if (node.LeftChild != null)
            {
                if (element.CompareTo(node.Data) < 0 && element.CompareTo(node.LeftChild.Data) != 0)
                    selectedNode = node.LeftChild;
                else
                    selectedNode = node;
            }
            else
                return node;

            if (selectedNode != null)
                return TraverseToRemove(element, selectedNode);
            else
                return node;
        }

        private TreeNode<T> Assign(TreeNode<T> removable)
        {
            TreeNode<T> child = null;
            TreeNode<T> currentNode;
            if (removable.LeftChild == null && removable.RightChild == null)
                return null;
            if (removable.LeftChild != null)
                child = removable.LeftChild;
            if (removable.RightChild != null)
            {
                if (child != null)
                {
                    currentNode = Traverse(removable.RightChild.Data, child);
                    if (currentNode.Data.CompareTo(removable.RightChild.Data) > 0)
                        currentNode.LeftChild = removable.RightChild;
                    else if (currentNode.Data.CompareTo(removable.RightChild.Data) < 0)
                        currentNode.RightChild = removable.RightChild;
                }
                else
                    child = removable.RightChild;
            }
            return child;
        }
    }
}

