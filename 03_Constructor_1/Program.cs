using System;

namespace _03_Constructor_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            new MyClass();//Bu artık default constructor ı ezmiştir ve developerın belirlemiş olduğu işlemleri class ayağa kalkarken oluşturur ve uygular.
        }
    }
    class MyClass
    {
        public MyClass()
        {
            Console.WriteLine("Bir adet MyClass nesnesi oluşturulmuştur.");
        }
    }
}
