using System;

namespace _02_Record
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass m = new()//burdaki işlemin adı ObjectInitilaizer yani nesne oluşturulurken değer atama 
            {
                Sayi1 = 5,//Sayi1 ve Sayi2 hata vermekte sebebi sadece get işlemi olmasından dolayı değer atanamazlar 
                Sayi2 = 5,
                Sayi3 = 5,
                Sayi4 = 10,
                Sayi5 = 10,
                B = 5// değeri bir kere alabilir cünkü aşağıdada söylendiği gibi B inittir 
            };
            m.Sayi4 = 123;
            m.Sayi5 = 123;
            m.Sayi6 = 123;
        }
    }
    class MyClass
    {
        //Getting-Only Properties
        public int Sayi1 { get; } = 3;
        public int Sayi2 { get; }
        //Normal Property
        public int Sayi3 { get; set; }
        //Init-Only Properties
        public int Sayi4 { get; init; } = 5;  //Burda görüldüğü üzere classdaki propertye varsayılan değer atılırken ve yukarda object initilaize edilirken değer verilebilir
        public int Sayi5 { get; init; }       //Burda propertye değer vermeden yukardaki propertye değer atılabilir
        public int Sayi6 { get; init; }       //Burda Object initilaize olurken verildiğini göstermek için sadece yani dışarda m.Sayi6 denilmiyor


        //küçük bi kullanım
        readonly int a;
        public int A
        {
            get
            {
                return a;
            }
            set
            {
                a = value;// a burda hata alır cünkü set edilmez readOnly olduğu için
            }
        }
        readonly int b;
        public int B
        {
            get
            {
                return b;
            }
            init
            {
                b = value;// b burda değer alır çünkü init bir kereye mahsus set eder 
            }
        }
    }

}
