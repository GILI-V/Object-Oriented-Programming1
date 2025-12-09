using System;

namespace Ex01_Q6
{
    public class Program
    {
        public static void Main(string[] args)
        {
            MeasureIntArray();
            MeasureDoubleArray();
        }

        static void MeasureIntArray()
        {
            long before = GC.GetAllocatedBytesForCurrentThread();
            int[] arr = new int[1000];
            long after = GC.GetAllocatedBytesForCurrentThread();
            Console.WriteLine($"int[] allocation: {after - before} bytes");
        }

        static void MeasureDoubleArray()
        {
            long before = GC.GetAllocatedBytesForCurrentThread();
            double[] arr = new double[1000];
            long after = GC.GetAllocatedBytesForCurrentThread();
            Console.WriteLine($"double[] allocation: {after - before} bytes");
        }
    }
}
