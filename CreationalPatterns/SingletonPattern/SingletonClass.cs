using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.SingletonPattern
{
    public class SingletonClass
    {
        //Constructor private yaparak bu sınıfın dışarıdan instance alınmasını engelledik.

        private SingletonClass() { }

        private static SingletonClass _singleObje = new SingletonClass();

        // Oluşturduğumuz static nesnenin (_singleObje) dışarıdan erişimi sağlamak için property tanımladık.

        public static SingletonClass Sınıf
        {
            get { return _singleObje; }
        }

        public int Toplam(int sayi_1, int sayi_2)
        {
            return sayi_1 + sayi_2;
        }
    }
}
