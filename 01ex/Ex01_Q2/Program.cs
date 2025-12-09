using System;

namespace Ex01_Q2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string s1 = "hello";
            string s2 = s1;
            s1 += " world";

            Console.WriteLine($"s1 = {s1}");
            Console.WriteLine($"s2 = {s2}");
        }
    }
}
