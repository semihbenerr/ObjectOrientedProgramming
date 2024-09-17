using System;

namespace _06_StaticConstructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            new MyClass();
            new MyClass();
        }
    }
    class MyClass
    {
        static MyClass()
        {
            Console.WriteLine("MyClass Static Constructor ı tetiklenmiştir.");
            //Bu sınıftan nesne üretilirken ilk tetiklenecek metottur.
            //İlk nesne dışında bir daha tetiklenmez.
            //Static Constructor ın tetiklenebilmesi için illa ilk nesne üretimi yapılmasına gerek yoktur. İlgili sınıf içersinde herhangi bir static yapılanmanında tetiklenmesi static constructorın tetiklenmesini sağlayacaktır.
        }
        public MyClass()
        {
            Console.WriteLine("MyClass Constructor ı tetiklenmiştir.");
            //Bu sınıftan her nesne üretiminde tetiklenecek metottur.
        }

    }
}
