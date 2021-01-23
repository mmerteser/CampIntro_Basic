using System;
using System.Collections.Generic;
namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> names = new MyList<string>();

            names.Add("Mert");

            Console.WriteLine(names.Length);

            names.Add("Bilge");

            Console.WriteLine(names.Length);

            foreach (var item in names.Items)
            {
                Console.WriteLine(item);
            }

            Dictionary<int, string> dict = new Dictionary<int, string>();

            dict.Add(1, "a");
            dict.Add(2, "b");

            foreach (var item in dict.Values)
            {
                Console.WriteLine(item);
            }
            
        }
    }
}
