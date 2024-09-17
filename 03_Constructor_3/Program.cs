using System;

namespace _03_Constructor_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            new MyClass();
            new MyClass(5);
            new MyClass("5");
            new MyClass(5,"5");
            new MyClass("5",5);//Sadece bu hata veriyor çünkü böyle bir overloading bulunmamakta constructorlar overload edilebilir ve birden fazla şekilde varyasyonları vardır.
        }
    }
    class MyClass
    {
        public MyClass()
        {
            
        }
        public MyClass(int a)
        {
            Console.WriteLine("Integer : "+a);
        }
        public MyClass(string a)
        {
            Console.WriteLine("String : "+a);
        }
        public MyClass(int a, string b)
        {
            Console.WriteLine("Integer : "+a+" String : "+b);
        }
    }
}
