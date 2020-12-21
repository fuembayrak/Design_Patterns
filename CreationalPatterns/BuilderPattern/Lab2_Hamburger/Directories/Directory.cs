

using CreationalPatterns.BuilderPattern.Lab2_Hamburger.Interface;

namespace CreationalPatterns.BuilderPattern.Lab2_Hamburger.Directories
{
    public class Directory
    {
        public void Yapim(IBuilder builder)
        {
            builder.Hamburger();

            builder.TavukBurger();
        }
    }
}
