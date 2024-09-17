using System;

namespace _02_Record_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass m = new()
            {
                MyProperty1 = 5,
                MyProperty2 = 10
            };
            m.MyProperty2 = 15;//diyemezsin hata alır artık init cünkü
            MyClass m2 = new()
            {
                MyProperty1 = m.MyProperty1,
                MyProperty2 = 15// bu sayede yapabilirsin ancak bir classta iki tane property olmayabilir her zman ve bu gereksiz iş yükü demektir.
            };
            MyClass m3 = m.With(15);//bu şekilde kısa bir yol ile de yapabiliriz ama bu seferde yazmış olduğumuz with methoduda bize gereksiz iş yükü sağlar.

            MyRecord r = new()
            {
                MyProperty1 = 5,
                MyProperty2 = 10
            };
            MyRecord r2 = r with { MyProperty2 = 15 };//Aşağıdaki record classında da göreceğiniz üzere bir with kodu yazılmadı MyClasstaki gibi içinde olan bir günelleme record sayesinde yapabiliriz bunu
        }
    }
    record MyRecord
    {
        public int MyProperty1 { get; init; }
        public int MyProperty2 { get; init; }
    }
    class MyClass
    {
        public int MyProperty1 { get; init; }
        public int MyProperty2 { get; init; }
        public MyClass With(int myProperty2)
        {
            return new MyClass
            {
                MyProperty1 = this.MyProperty1,
                MyProperty2 = myProperty2
            };
        }
    }
}
