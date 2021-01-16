using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    public class SepetManager
    {
        //naming convention - Yazım kuralı
        // syntax - yazım değişimleri
        public void Ekle(Product product)
        {

            Console.WriteLine("Sepete eklendi : " + product.ProductName);
        }

        public void Ekle2(string urunAdi,double fiyat,string aciklama)
        {
            Console.WriteLine("Sepete eklendi : " + urunAdi);
        }
    }
}