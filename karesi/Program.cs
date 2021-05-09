using System;

namespace karesi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("bu program girilen sayının karesini hesaplar");
            Console.Write("Sayı: ");
            string cevap = Console.ReadLine();
            int sayi = Convert.ToInt32(cevap);
            int sonuc = sayi * sayi;
            Console.WriteLine("Girdiğiniz sayının karesi :" + sonuc);



            Console.ReadKey();
        }
    }
}
