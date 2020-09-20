using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DataStructures.LinkedList;

[assembly: InternalsVisibleTo("DataStructures.Tests")]
namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
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

            tree.Remove(14);
            tree.Remove(3);
            tree.Remove(666);


            //list.AddTail(12); 

            //var head = list.Head;
            //var nextItem = head.Next;
            //var oldNext = nextItem.Next;
            //nextItem.Next = new ListNode<int>(555, oldNext);

            //Print(list);

            //Console.WriteLine(list[1]);
            //list[4] = 44;
            //Print(list);
            //list.Remove(5);
            //Print(list);
            //var list = new DataStructures.LinkedList.LinkedList<int>();
            //list.Add(5);
            //list.Remove(6);
            //Print(list);
        }

        static void Print<T>(IEnumerable<T> collection)
        {
            foreach (T node in collection)
            {
                Console.WriteLine(node);
            }
        }
    }
}
