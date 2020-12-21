

using CreationalPatterns.BuilderPattern.Lab2_Hamburger.Delegate;
using CreationalPatterns.BuilderPattern.Lab2_Hamburger.Interface;

namespace CreationalPatterns.BuilderPattern.Lab2_Hamburger.Concretes
{
    public class Builder_2 : IBuilder
    {
        private Product urun = new Product();

        public void Hamburger()
        {
            urun.Add("Chedar Peyniri");
            urun.Add("Barbekü Sos");
            urun.Add("Mayonez");
            urun.Add("Acı Sos\n");
        }

        public void TavukBurger()
        {
            urun.Add("Çıtır Patates");
            urun.Add("Ranch Sos");
            urun.Add("Ketçap");
            urun.Add("Turşu");
        }

        public Product UrunuGetir()
        {
            return urun;
        }
    }
}
