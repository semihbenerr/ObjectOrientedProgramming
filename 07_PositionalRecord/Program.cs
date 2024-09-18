using System;
using System.Globalization;

namespace _07_PositionalRecord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyRecord2 m = new("Semih", "Bener");
            var (n, s) = m;
        }
    }
    record MyRecord1
    {
        public MyRecord1()//recordlar class gibi calışırlar burda bir constructor işlem yapabiliyoruz.
        {
            
        }
        public void Deconstruct()//Aynı şekilde Deconstruct işlemi yaparkende bir sorun ile karşılaşmıyoruz "05_Deconstruct" projesinde kullanımını görebilirsiniz.
        {

        }
    }

    record MyRecord2(string name, string surname)//burda recordın yeni gelmiş özelliği PositionalRecordlar sayesinde class içinde değilde bu şekilde de Deconstruct ve construct method oluşturabiliriz.
    {
        //Positional Record kullanırken parametrelerin karşılıkları olan propertyleri manuel oluşturmak zorunda değiliz.
        //Bu propertylerin karşılığı olarak complier seviyesinde propertyler otomatik oluşturulacaktır.
        //Bu propertyler oluşturulurken init olacak şekilde oluştururlur.
        public MyRecord2()//bu constructor hata verir ama bunun sebebi positional yaptık diye değil alması gereken parametreler olduğu için positional record tanımlanmışsa eğer nesne üretiminde tetiklenmesi zorunludur bu yüzden hata verir 
        {
            
        }

    }

    //örnek gösterim 
    record MyRecord3(string test)
    {
        public MyRecord3():this("Semih")//ama sonuna this keyword ü eklersek sorun ortadan kalkacaktır
        {
            
        }
    }
}
