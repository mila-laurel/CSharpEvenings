using System;

namespace Sorting
{
    class MergeSort
    {
        public static void SortAscending(int[] arr)
        {
            DoMergeSort(arr, 0, arr.Length - 1, (a, b) => a < b);
        }

        public static void SortDescending(int[] arr)
        {
            DoMergeSort(arr, 0, arr.Length - 1, (a, b) => a > b);
        }

        private static void DoMergeSort(int[] arr, int low, int high, Func<int, int, bool> compare)
        {
            if (low < high)
            {
                int pivot = (low + high) / 2;
                DoMergeSort(arr, low, pivot, compare);
                DoMergeSort(arr, pivot + 1, high, compare);
                Merge(arr, low, pivot, high, compare);
            }
        }

        private static void Merge(int[] arr, int low, int pivot, int high, Func<int, int, bool> compare)
        {
            throw new NotImplementedException();
        }
    }
}
