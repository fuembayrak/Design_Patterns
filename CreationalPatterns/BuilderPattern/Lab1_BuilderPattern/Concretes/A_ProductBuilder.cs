using CreationalPatterns.BuilderPattern.Lab1_BuilderPattern.Abstract;
using CreationalPatterns.BuilderPattern.Lab1_BuilderPattern.Delegate;


namespace CreationalPatterns.BuilderPattern.Lab1_BuilderPattern.Concretes
{
    public class A_ProductBuilder : ProductBuilder
    {
        ProductModel model = new ProductModel();

        public override ProductModel ModelAl()
        {
            return model;
        }

        public override void UrunVerileri()
        {
            model.Id = 1;
            model.BirimFiyat = 10;
            model.UrunAdi = "Levrek";
        }

        public override void UygulanmisIndirim()
        {
            model.IndirimliFiyat = model.BirimFiyat * (decimal)0.90;
            model.IndirimUygulmasi = true;
        }
    }
}
