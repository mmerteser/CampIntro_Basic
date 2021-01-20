using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP1
{
    public class ProductManager
    {
        public ProductManager()
        {

        }

        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + " eklendi.");
        }

        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " güncellendi.");
        }

        public int Topla(int number1,int number2)
        {
            return number1 + number2;
        }
    }
}
