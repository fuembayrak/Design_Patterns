using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.BuilderPattern.Lab1_BuilderPattern.Delegate
{
    public class ProductModel
    {
        public int Id { get; set; }
        public string UrunAdi { get; set; }
        public decimal BirimFiyat { get; set; }
        public decimal IndirimliFiyat { get; set; }
        public bool IndirimUygulmasi { get; set; }
    }
}
