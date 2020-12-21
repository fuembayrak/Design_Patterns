

using CreationalPatterns.BuilderPattern.Lab2_Hamburger.Delegate;
using CreationalPatterns.BuilderPattern.Lab2_Hamburger.Interface;

namespace CreationalPatterns.BuilderPattern.Lab2_Hamburger.Concretes
{
    public class Builder_1 : IBuilder
    {
        private Product urun = new Product();
        public void Hamburger()
        {
            urun.Add("Köfte\n");
        }

        public void TavukBurger()
        {
            urun.Add("Tavuk");
        }

        public Product UrunuGetir()
        {
            return urun;
        }
    }
}
