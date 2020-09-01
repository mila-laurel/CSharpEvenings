using System;

namespace Sorting
{
    class BubbleSort
    {
        public static void SortAscending(int[] arr)
        {
            Sort(arr, (a, b) => a > b );
        }

        public static void SortDescending(int[] arr)
        {
            Sort(arr, (a, b) => a < b);
        }

        private static void Sort(int[] arr, Func<int, int, bool> compare)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (compare(arr[j], arr[j + 1]))
                        Util.Swap(ref arr[j], ref arr[j + 1]);
                }
            }
        }
    }
}
