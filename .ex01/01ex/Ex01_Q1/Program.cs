using System;

namespace Ex01_Q1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            MyClass c1 = new MyClass { X = 5 };
            MyClass c2 = c1;
            c2.X = 10;

            MyStruct s1 = new MyStruct { X = 5 };
            MyStruct s2 = s1;
            s2.X = 10;

            Console.WriteLine($"MyClass -> c1.X={c1.X}, c2.X={c2.X}");
            Console.WriteLine($"MyStruct -> s1.X={s1.X}, s2.X={s2.X}");
        }
    }

    public class MyClass
    {
        public int X;
    }

    public struct MyStruct
    {
        public int X;
    }
}
