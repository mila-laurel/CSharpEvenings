using System;

namespace Sorting
{
    class InsertSort
    {
        public static void SortAscending(int[] arr)
        {
            Sort(arr, (a, b) => a < b);
        }

        public static void SortDescending(int[] arr)
        {
            Sort(arr, (a, b) => a > b);
        }

        private static void Sort(int[] arr, Func<int, int, bool> compare)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                if (compare(arr[i], arr[i - 1]))
                {
                    Util.Swap(ref arr[i], ref arr[i - 1]);
                    for (int j = i - 1; j > 0 && compare(arr[j], arr[j - 1]); j--)
                    {
                        Util.Swap(ref arr[j], ref arr[j - 1]);
                    }
                }
            }
        }
    }
}
