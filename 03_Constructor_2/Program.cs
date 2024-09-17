using System;

namespace _03_Constructor_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            new MyClass(5);//Contructorlar parametre alabilen yapılardır
            new MyClass();//Hata verir çünkü içine int bir değer bekliyor
        }
    }
    class MyClass
    {
        public MyClass(int a)
        {
            Console.WriteLine(a);
        }
    }
}
