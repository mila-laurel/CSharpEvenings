using System;
using DataStructures.LinkedList;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new LinkedList<int>();
            list.Add(1);
            list.Add(3);
            list.Add(5);

            list.AddTail(12);

            Print(list);
        }

        static void Print<T>(LinkedList<T> list)
        {
            var current = list.Head;
            if(current != null)
                System.Console.WriteLine(current.Data);
            while(current.Next != null)
            {
                current = current.Next;
                System.Console.WriteLine(current.Data);
            }
        }
    }
}
