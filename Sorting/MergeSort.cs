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
            for (int i = 0; i < high; i = i + 2)
            {
                if (arr[i] > arr[i + 1])
                    Util.Swap(ref arr[i], ref arr[i + 1]);
            }
            for (int i = 1; i < high; i = i + 2)
            {

            }
        }

        private static int Partition(int[] arr, int low, int high, Func<int, int, bool> compare)
        {
            int middle = high / 2;
            high = middle - 1;
            return high;
        }
    }
}
