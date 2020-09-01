using System;

namespace Sorting
{
    class QuickSort
    {
        public static void SortAscending(int[] arr)
        {
            DoQuickSort(arr, 0, arr.Length - 1, (a, b) => a < b);
        }

        public static void SortDescending(int[] arr)
        {
            DoQuickSort(arr, 0, arr.Length - 1, (a, b) => a > b);
        }

        private static void DoQuickSort(int[] arr, int low, int high, Func<int, int, bool> compare)
        {
            if(low < high)
            {
                int pivot = Partition(arr, low, high, compare);
                DoQuickSort(arr, low, pivot - 1, compare);
                DoQuickSort(arr, pivot + 1, high, compare);
            }
        }

        private static int Partition(int[] arr, int low, int high, Func<int, int, bool> compare)
        {
            int pivot = arr[high];
            int smallIndex = low - 1;

            for (int i = low; i < high; i++)
            {
                // condition of sorting
                if(compare(arr[i], pivot))
                {
                    smallIndex++;
                    Util.Swap(ref arr[i], ref arr[smallIndex]);
                }
            }
            
            Util.Swap(ref arr[smallIndex + 1], ref arr[high]);
            return smallIndex + 1;
        }
    }
}
