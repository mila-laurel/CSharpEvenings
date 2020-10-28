using System;
using System.Collections.Generic;
using System.Linq;

namespace Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sourceArray = Util.CreateArray(10);
            System.Console.WriteLine("Source array:");
            sourceArray.Print();

            TestSort("Bubble", sourceArray, BubbleSort.SortAscending, BubbleSort.SortDescending);
            TestSort("Insertion", sourceArray, InsertSort.SortAscending, InsertSort.SortDescending);
            TestSort("Selection", sourceArray, SelectionSort.SortAscending, SelectionSort.SortDescending);
            TestSort("Quick", sourceArray, QuickSort.SortAscending, QuickSort.SortDescending);

            // Console.WriteLine("Bubble");
            // int[] tenth = { 6, 7, 15, 89, 47, 0, 6, 23, 40, 8 };
            // BubbleSort.SortAscending(tenth);
            // tenth.Print();

            // int[] eighth = Util.CreateArray(8);
            // BubbleSort.SortDescending(eighth);
            // eighth.Print();

            // int[] another = Util.CreateArray(12);
            // InsertSort.SortAscending(another);
            // another.Print();

            // int[] andAnotherOne = Util.CreateArray(14);
            // SelectionSort.SortAscending(andAnotherOne);
            // andAnotherOne.Print();
        }

        static void TestSort(string name, IReadOnlyList<int> source, Action<int[]> sortAscending, Action<int[]> SortDescending)
        {
            int[] targetArray = null;
            Console.WriteLine($"{name} sort");

            Console.WriteLine("Ascending");
            targetArray = source.ToArray();
            sortAscending(targetArray);
            targetArray.Print();

            Console.WriteLine("Descending");
            targetArray = source.ToArray();
            SortDescending(targetArray);
            targetArray.Print();

            Console.WriteLine();
        }
    }
}
