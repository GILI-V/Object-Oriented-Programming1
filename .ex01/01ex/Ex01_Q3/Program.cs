using System;

namespace Ex01_Q3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] a = { 1, 2, 3 };
            Console.WriteLine("Original: " + string.Join(",", a));

            ArrayUtils.ExpandArray(ref a);

            Console.WriteLine("Expanded: " + string.Join(",", a));
        }
    }

    public static class ArrayUtils
    {
        public static void ExpandArray(ref int[] array)
        {
            int[] oldArray = array;
            array = new int[oldArray.Length * 2];

            for (int i = 0; i < oldArray.Length; i++)
                array[i] = oldArray[i];

            for (int i = 0; i < oldArray.Length; i++)
                array[i + oldArray.Length] = oldArray[i];
        }
    }
}
