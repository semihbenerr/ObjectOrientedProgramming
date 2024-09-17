using System;
using System.Threading.Channels;

namespace _06_StaticConstructor_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //new Database();//Hata alır çünkü newlenemez dışarıya kapalıdır.
            Database db1 = Database.GetDatabase;//Burda nesne üretilir ve artık kontrollü bir şekilde sadece bir nesne oluşturduk.
            Database db2 = Database.GetDatabase;//db1 ve db2 farklı nesneler değil aynı nesne olduğu için db2.ConnStringte aynı değeri alacaktır.
            db1.ConnString = "connString=SemihBener";

            Console.WriteLine();
        }
    }

    class Database
    {
        //Singleton Design Pattern 
        //Bir sınıftan uygulama bazında sade ve sadece ttek bir nesne oluşturulmasını istiyorsan kullanabileceğin design patterdir.
        Database() //bu artık bir private constructordır.
        {

        }
        //static yapılanma uygulamada tekil nesne tutar.
        public string ConnString { get; set; }//Bir tane connString ekledim bunun amacı tamamiyle tekil nesne olduğunu görmek için yukarda uygulamayı calıştırdığımızda db2.ConnString te aynı şekilde "connString=SemihBener" i aldığını görebiliriz.
        static Database database; //bir field oluşturduk ve bu field static bir yapılanma olduğu için haliyle static constructor da işlemlerimizi gerçekleştiriyoruz.
        static public Database GetDatabase //ve bir property oluşturup kapsülleme yapıyorum.
        {
            get
            {
                return database;
            }
        }
        static Database()//static constructor
        {
            database = new Database();//burda newleyebilmemizin sebebi zaten aynı class içinde olduğu için private de olsa aynı class içinden çıkmadığımız için kullanabiliriz.
        }

    }
}
