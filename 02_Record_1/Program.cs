using System;

namespace _02_Record_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass m1 = new()
            {
                MyProperty = 5
            };
            MyClass m2 = new()
            {
                MyProperty = 5
            };
            Console.WriteLine(m1.Equals(m2));
            MyRecord m3 = new()
            {
                MyProperty = 5
            };
            MyRecord m4 = new()
            {
                MyProperty = 5
            };
            Console.WriteLine(m3.Equals(m4));
        }
    }
    record MyRecord
    {
        public int MyProperty { get; set; }
    }
    class MyClass
    {
        public int MyProperty { get; set; }
    }
}
