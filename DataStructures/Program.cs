using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DataStructures.BinaryTree;
using DataStructures.LinkedList;

[assembly: InternalsVisibleTo("DataStructures.Tests")]
namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedListMain();
            BinaryTreeMain();
        }

        static void LinkedListMain()
        {
            var list = new DataStructures.LinkedList.LinkedList<int>();
            list.Add(1);
            list.Add(3);
            list.Add(5);

            list.AddTail(12);

            var head = list.Head;
            var nextItem = head.Next;
            var oldNext = nextItem.Next;
            nextItem.Next = new ListNode<int>(555, oldNext);

            Print(list);

            Console.WriteLine(list[1]);
            list[4] = 44;
            Print(list);
            list.Remove(5);
            Print(list);
            list.Add(5);
            list.Remove(6);
            Print(list);
        }

        static void BinaryTreeMain()
        {
            var tree = new DataStructures.BinaryTree.BinaryTree<int>(15);
            tree.Add(1);
            tree.Add(3);
            tree.Add(20);
            tree.Add(14);
            tree.Add(28);
            tree.Add(2);
            tree.Add(25);
            tree.Add(16);

            BFS(tree.Root);
        }

        static void Print<T>(IEnumerable<T> collection)
        {
            foreach (T node in collection)
            {
                Console.WriteLine(node);
            }
        }

        static void BFS(TreeNode<int> node)
        {
            Queue<TreeNode<int>> queue = new Queue<TreeNode<int>>();
            queue.Enqueue(node);

            while (queue.Count > 0)
            {
                TreeNode<int> currentNode = queue.Dequeue();
                if (currentNode.LeftChild != null)
                    queue.Enqueue(currentNode.LeftChild);
                if (currentNode.RightChild != null)
                    queue.Enqueue(currentNode.RightChild);
                Console.WriteLine(currentNode.Data);
            }
        }

        static void DFS(TreeNode<int> node)
        {
            Stack<TreeNode<int>> stack = new Stack<TreeNode<int>>();
            stack.Push(node);

            while (stack.Count > 0)
            {
                TreeNode<int> currentNode = stack.Pop();
                if (currentNode.LeftChild != null)
                    stack.Push(currentNode.LeftChild);
                if (currentNode.RightChild != null)
                    stack.Push(currentNode.RightChild);
                Console.WriteLine(currentNode.Data);
            }
        }
    }
}
