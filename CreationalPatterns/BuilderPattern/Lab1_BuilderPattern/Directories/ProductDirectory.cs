using CreationalPatterns.BuilderPattern.Lab1_BuilderPattern.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.BuilderPattern.Lab1_BuilderPattern.Directories
{
    public class ProductDirectory
    {
        public void UrunOlustur(ProductBuilder productBuilder)
        {
            productBuilder.UrunVerileri();
            productBuilder.ModelAl();
            productBuilder.UygulanmisIndirim();
        }
    }
}
