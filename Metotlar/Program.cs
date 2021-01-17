using System;
using System.Collections.Generic;

namespace Metotlar
{
    public class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();

            product.ProductName = "Elma";
            product.SalePrice = 5;
            product.Description = "Amasya elması";

            Product product2 = new Product();

            product2.ProductName = "Karpuz";
            product2.SalePrice = 25;
            product2.Description = "Diyarbakır karpuzu";

            Product[] products = new Product[]{product2,product};

            foreach (var prd in products)
            {
                Console.WriteLine($"{prd.ProductName} - {prd.SalePrice} - {prd.Description}");
            }

            SepetManager sepetManager = new SepetManager();

            sepetManager.Ekle(new Product(){Description = "Amasya kırmızı",ProductName = "Kırmızı Elma",SalePrice = 10});

            sepetManager.Ekle2("Armut",12,"Yeşil armut");


            List<Product> products1 = new List<Product>();


            Console.ReadKey();
        }


    }
}


//Do not repeat yourself - DRY - Clean Code - Best Practice
