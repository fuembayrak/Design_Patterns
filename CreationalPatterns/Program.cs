using CreationalPatterns.BuilderPattern.Lab1_BuilderPattern.Abstract;
using CreationalPatterns.BuilderPattern.Lab1_BuilderPattern.Concretes;
using CreationalPatterns.BuilderPattern.Lab1_BuilderPattern.Directories;
using CreationalPatterns.BuilderPattern.Lab2_Hamburger.Concretes;
using CreationalPatterns.BuilderPattern.Lab2_Hamburger.Delegate;
using CreationalPatterns.BuilderPattern.Lab2_Hamburger.Directories;
using CreationalPatterns.BuilderPattern.Lab2_Hamburger.Interface;
using CreationalPatterns.SingletonPattern;
using System;


namespace CreationalPatterns
{
    class Program
    {
        
        static void Main(string[] args)
        {
            #region SingletonPattern
            //Not: Lab uygulamalarında sınıfı, sınıf dışında new anahtar sözcüğü vasıtasıyla üretemeyiz. Bunun nedeni singleton ile bu nesneleri üreteceğimiz ve zaten bu bağlamda constructor private yaparak dış erişime kapattık ve singleton ile ters düşmedik.

            int toplam_1 = SingletonClass.Sınıf.Toplam(1, 2);

            Console.WriteLine(toplam_1);
            #endregion
            #region Lab_1_BuilderPattern
            ProductDirectory productDirectory = new ProductDirectory();
            ProductBuilder productBuilder = new A_ProductBuilder();

            productDirectory.UrunOlustur(productBuilder);

            var model = productBuilder.ModelAl();
            Console.WriteLine(model.Id);
            Console.WriteLine(model.UrunAdi);
            Console.WriteLine(model.BirimFiyat);
            Console.WriteLine(model.IndirimliFiyat);
            Console.WriteLine(model.IndirimUygulmasi);


            #endregion
            #region Lab2_Hamburger
            Directory directory = new Directory();
            IBuilder builder_1 = new Builder_1();
            IBuilder builder_2 = new Builder_2();

            directory.Yapim(builder_1);
            Product p_1 = builder_1.UrunuGetir();
            p_1.Goruntule();

            directory.Yapim(builder_2);
            Product p_2 = builder_2.UrunuGetir();
            p_2.Goruntule();


            #endregion
            Console.ReadKey();
        }
    }
}
