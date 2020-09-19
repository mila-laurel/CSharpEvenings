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
            currentNode.Data = element;
        }

        public TreeNode<T> Traverse(T element, TreeNode<T> node)
        {
            if (element.CompareTo(node.Data) > 0)
            {
                if (node.RightChild != null || node.RightChild.Data.CompareTo(element) != 0)
                    node = node.RightChild;
                else if (node.RightChild.Data.CompareTo(element) == 0)
                    return node;
                else
                    return node.RightChild;
            }
            else if (element.CompareTo(node.Data) < 0)
            {
                if (node.LeftChild != null)
                {
                    if (node.LeftChild.Data.CompareTo(element) != 0)
                        node = node.LeftChild;
                    else
                        return node;
                }
                else
                    return node.LeftChild;
                }
                else
                    return node;
                return Traverse(element, node);
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
                if (currentNode.RightChild.Data.CompareTo(element) == 0)
                {
                    removable = currentNode.RightChild;
                    currentNode.RightChild = removable.RightChild;
                    currentNode.LeftChild = removable.LeftChild;
                    return;
                }
                if (currentNode.LeftChild.Data.CompareTo(element) == 0)
                {
                    removable = currentNode.LeftChild;
                    currentNode.RightChild = removable.RightChild;
                    currentNode.LeftChild = removable.LeftChild;
                    return;
                }
            }
        }
    }
