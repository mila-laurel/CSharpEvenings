using System;
using System.Collections.Generic;
using DataStructures.LinkedList;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
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

            //list.Remove(555);

            Print(list);

            Console.WriteLine(list[1]);
            list[4] = 44;
            Print(list);
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
