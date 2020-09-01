using System;

namespace Sorting
{
    class SelectionSort
    {
        public static void SortAscending(int[] arr)
        {
            Sort(arr, (a, b) => a > b);
        }

        public static void SortDescending(int[] arr)
        {
            Sort(arr, (a, b) => a < b);
        }

        private static void Sort(int[] arr, Func<int, int, bool> compare)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int swapWithIndex = i;

                for (int j = swapWithIndex + 1; j < arr.Length; j++)
                {
                    if (compare(arr[swapWithIndex], arr[j]))
                    {
                        swapWithIndex = j;
                    }
                }

                if(i != swapWithIndex)
                    Util.Swap(ref arr[i], ref arr[swapWithIndex]);
            }
        }
    }
}
