using System;
using CampIntro;

namespace CampIntro
{
    public class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 5; i++)
            {
                Console.WriteLine("Hello World!");
                if (i == 3)
                {
                    break;
                }
            }

            string[] strings = new[] { "1. Kurs", "2. Kurs", "3. Kurs" };

            foreach (var VARIABLE in strings)
            {
                Console.WriteLine(VARIABLE);
            }

            int sayi = 6;

            string sonuc = (sayi == 1) ? "Sayı 1" : "Sayı 1 değil";

            Console.WriteLine(sonuc);


            switch (sayi)
            {
                case 1:
                    Console.WriteLine("Pazartesi");
                    break;
                case 2:
                    Console.WriteLine("Salı");
                    break;
                case 3:
                    Console.WriteLine("Çarşamba");
                    break;
                case 4:
                    Console.WriteLine("Perşembe");
                    break;
                default:
                    Console.WriteLine("Hiç biri");
                    break;
            }

            while (sayi == 15)
            {
                Console.WriteLine(sayi);
                sayi++;
            }

            Console.ReadKey();
        }

    }
}

