using CreationalPatterns.BuilderPattern.Lab1_BuilderPattern.Delegate;


namespace CreationalPatterns.BuilderPattern.Lab1_BuilderPattern.Abstract
{
    public abstract class ProductBuilder
    {
        public abstract void UrunVerileri();
        public abstract void UygulanmisIndirim();
        public abstract ProductModel ModelAl();
    }
}
