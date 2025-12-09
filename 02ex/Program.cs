
using System;
using System.Diagnostics;
using System.Threading;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Exercise 02 Project ===");
        // You can call each test function here if you like.
    }

    // Q1: Memory allocation test skeleton
    static void MemoryAllocationTest()
    {
        try
        {
            int size = 1000000; 
            int[] arr = new int[size];
            Console.WriteLine($"Allocated array of {size} ints.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Allocation failed: " + ex.Message);
        }
    }

    // Q2: Sequential vs Strided access
    static void AccessTimeTest()
    {
        int size = 20_000_000;
        int stride = 1000;
        int[] arr = new int[size];

        var sw = new Stopwatch();

        sw.Start();
        long sum1 = 0;
        for (int i = 0; i < size; i++)
            sum1 += arr[i];
        sw.Stop();
        Console.WriteLine("Sequential access: " + sw.ElapsedMilliseconds + " ms");

        sw.Restart();
        long sum2 = 0;
        for (int i = 0; i < size; i += stride)
            sum2 += arr[i];
        sw.Stop();
        Console.WriteLine("Strided access: " + sw.ElapsedMilliseconds + " ms");
    }

    // Q3: Swap functions
    static void Swap(int[] arr, int i, int j)
    {
        int temp = arr[i];
        arr[i] = arr[j];
        arr[j] = temp;
    }

    static void Swap<T>(ref T a, ref T b)
    {
        T temp = a;
        a = b;
        b = temp;
    }

    // Q4: Threading test
    static int[] bigArray = new int[30_000_000];

    static void ThreadTest()
    {
        Thread t1 = new Thread(() => WorkOnRange(0, bigArray.Length / 2));
        Thread t2 = new Thread(() => WorkOnRange(bigArray.Length / 2, bigArray.Length));

        var sw = Stopwatch.StartNew();
        t1.Start();
        t2.Start();
        t1.Join();
        t2.Join();
        sw.Stop();
        Console.WriteLine("Two threads, separate regions: " + sw.ElapsedMilliseconds + " ms");

        Thread t3 = new Thread(() => WorkOnRange(0, bigArray.Length));
        Thread t4 = new Thread(() => WorkOnRange(0, bigArray.Length));

        sw.Restart();
        t3.Start();
        t4.Start();
        t3.Join();
        t4.Join();
        sw.Stop();
        Console.WriteLine("Two threads, whole array: " + sw.ElapsedMilliseconds + " ms");
    }

    static void WorkOnRange(int start, int end)
    {
        for (int i = start; i < end; i++)
            bigArray[i]++;
    }
}
