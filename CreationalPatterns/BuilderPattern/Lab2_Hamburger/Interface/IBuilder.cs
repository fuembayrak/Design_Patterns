using CreationalPatterns.BuilderPattern.Lab2_Hamburger.Delegate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.BuilderPattern.Lab2_Hamburger.Interface
{
    public interface IBuilder
    {
        void Hamburger();
        void TavukBurger();

        Product UrunuGetir();
    }
}
