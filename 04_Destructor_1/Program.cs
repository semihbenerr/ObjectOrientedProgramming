using System;

namespace _04_Destructor_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            while (a >= 1)
            {
                new MyClass(a--);
            }
            Console.WriteLine("*******************");
            GC.Collect();

            Console.ReadLine();
        }
    }
    class MyClass
    {
        int no;
        public MyClass(int no)
        {
            this.no = no;
            Console.WriteLine($"{no}. nesne oluşturuldu");
        }
        ~MyClass()
        {
            Console.WriteLine($"{no}. imha edilecek");
        }
    }
}
