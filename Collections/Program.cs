using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[] { "Mert", "Azra", "Hatice", "Mevlüt" }; //string array

            List<string> myFamily = new List<string>() {
                "Mert","Azra","Hatice","Mevlüt"
            };

            myFamily.Add("Bilge");

            foreach (var item in myFamily)
            {
                Console.WriteLine(item);
            }


        }
    }

    class Product
    {

    }
}
