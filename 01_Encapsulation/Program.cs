using System;

namespace _01_Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Eski
            MyClass myClass = new MyClass();
            myClass.ASet(15);
            Console.WriteLine(myClass.AGet());
            #endregion

            #region Yeni
            myClass.MyVar = 15;
            Console.WriteLine(myClass.MyVar);
            #endregion

        }
    }
    class MyClass
    {
        #region Eski
        int a;//default private
        public int AGet()
        {
            //bundan sonra kontrol bizde artık a değerini a nın 10 katını vs vs gönderebiliriz
            //Dışardan a değerini okumak istiyorsam Get
            return this.a;
        }
        public void ASet(int value)
        {
            //Neden void cünkü dışardan değer gelicek ama dışarıya bi değer göndermiyecek
            //Dışardan a ya değer vermek istiosam Set 
            this.a = value;
        }
        #endregion

        #region Yeni
        private int myVar;
        public int MyVar
        {
            get { return myVar; }
            set { myVar = value; }
        }

        #endregion
    }
}
