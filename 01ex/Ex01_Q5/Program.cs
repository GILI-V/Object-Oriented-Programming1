using System;

namespace Ex01_Q5
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int number = 10;
            long factorial = Factorial(number);
            Console.WriteLine($"{number}! = {factorial}");
        }

        public static long Factorial(int number)
        {
            long result = 1;
            for (int i = number; i >= 1; i--)
            {
                result *= i;
            }
            return result;
        }
    }
}
