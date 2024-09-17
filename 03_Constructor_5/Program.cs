using System;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;

namespace _03_Constructor_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            new MyClass(5, 7);//Burda biz overload methodu ile iki değer alan constructor ı alıyoruz ama 3. consturctorta this keywordü var ve bu keyword sayesinde verilen overload a göre consturctor çağırır       
        }
    }
    class MyClass
    {
        public MyClass()
        {
            Console.WriteLine("1. Constructor.");
        }
        public MyClass(int a)
        {
            Console.WriteLine("2. Constructor. "+a);
        }
        public MyClass(int a,int b):this()
        {
            Console.WriteLine("3. Constructor. "+a+" "+b);
        }
    }
}
