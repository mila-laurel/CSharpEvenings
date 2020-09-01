using System;

namespace Sorting
{
    public static class Util
    {
        public static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        public static void Print(this int[] array) 
        {
            Console.WriteLine(string.Join('-', array));
        }

        public static int[] CreateArray(int length)
        {
            Random random = new Random();
            int[] result = new int[length];
            for (int i = 0; i < length; i++)
            {
                result[i] = random.Next(100);
            }
            return result;
        }
    }
}
