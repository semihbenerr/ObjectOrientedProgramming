using System;
using System.Xml;

namespace _05_Deconstruct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person("Semih", "Bener", 22);
            var (x, y, z) = p;
            Console.WriteLine($"Adı : {x} ");
            Console.WriteLine($"Soyadı : {y} ");
            Console.WriteLine($"Yaş : {z} ");


            //overload yapılabilir bir yapıdır aynı consturctor gibi bambaşka bir serviste ihtiyac haline göre şekillenebilir.
            Person p1 = new Person("Semih", "Bener");
            var (a, b) = p1;
            Console.WriteLine($"Adı : {a} ");
            Console.WriteLine($"Soyadı : {b} ");
        }
    }
    class Person
    {
        public Person(string ad, string soyad)
        {
            Name = ad;
            Surname = soyad;
        }

        //overload yapılabilir bir yapıdır aynı consturctor gibi bambaşka bir serviste ihtiyac haline göre şekillenebilir.
        public Person(string ad, string soyad, int yas)
        {
            Name = ad;
            Surname = soyad;
            Age = yas;
        }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }
        public void Deconstruct(out string name, out string surname)//Deconstruct yöntemi class içindeki propları ayrıştırmaya yarar ihtiyac halindeki propertyleri alırız
        {
            name = Name;
            surname = Surname;
        }

        //overload yapılabilir bir yapıdır aynı consturctor gibi bambaşka bir serviste ihtiyac haline göre şekillenebilir.
        public void Deconstruct(out string name, out string surname, out int age)
        {
            name = Name;
            age = Age;
            surname = Surname;
        }
    }
}
