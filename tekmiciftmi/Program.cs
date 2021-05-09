using System;

namespace tekmiciftmi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Sayı: ");

            int sayi = Convert.ToInt32(Console.ReadLine());

            bool ciftMi = sayi % 2 == 0;

            string sonuc = ciftMi ? "çift" : "tek";

            Console.WriteLine("Girdiğiniz sayı bir " + sonuc + " sayıdır.");

            Console.ReadKey();
        }
    }
}
