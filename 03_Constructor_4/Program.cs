using System;

namespace _03_Constructor_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            new MyClass();//Bir nesne oluşturulurken o nesnenin constructor ına tetikleriz ve eğer constructor public değilse hata alırız.
        }
    }
    class MyClass
    {
        //private yada hiç bir şey yazmazsanda aynısı olur dışardan erişime kapalıdır.
        /*private*/ MyClass()
        {

        }
        void X()
        {
            new MyClass();//class içinde erişim sağlanır private tamda bu işi yapar.
        }
    }
}
