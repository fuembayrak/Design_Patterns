

using System;
using System.Collections.Generic;

namespace CreationalPatterns.BuilderPattern.Lab2_Hamburger.Delegate
{
    public class Product
    {
        List<string> malzemeler = new List<string>();

        public void Add(string malzeme)
        {
            malzemeler.Add(malzeme);
        }

        public void Goruntule()
        {
            Console.WriteLine("\nÜrün Malzemeleri:");

            foreach (var item in malzemeler)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
        }
    }
}
