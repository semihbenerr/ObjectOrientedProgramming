using System;

namespace _04_Destructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            X();
            GC.Collect();
            Console.ReadLine();
        }
        static void X()
        {
            new MyClass();
        }
    }
    class MyClass
    {
        public MyClass()//consturctor 
        {
            Console.WriteLine("Merhaba");
        }
        ~MyClass()
        {
            Console.WriteLine("Bye Bye");
        }
    }
}
