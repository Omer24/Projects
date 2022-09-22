using System;

namespace dongular_for_loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            // // Ekrandan Girilen Sayıya Kadar Olan Tek Sayılarını Ekrana Yazdır.
            // Console.Write("Lütfen Bir Sayı Giriniz:");
            // int sayac = int.Parse(Console.ReadLine());
            // for (int i = 1; i <= sayac; i++)
            // {
            //     if (i%2 == 1)
            //     {
            //         Console.WriteLine(i);
            //     }
            // }

            // // 1 ile 1000 Arasındaki Tek ve Çift Sayıların Kendi İçlerinde Toplamlarını Ekrana Yazdır.
            // int tekToplam = 0;
            // int ciftToplam = 0;
            // for (int i = 1; i <= 1000; i++)
            // {
            //     if(i%2 == 1)
            //     {
            //         tekToplam += i; // tekToplam = tekToplam + i;
            //     }
            //     else
            //     {
            //         ciftToplam += i; // ciftToplam = ciftToplam +i;
            //     }
            // }
            // Console.WriteLine("Tek Toplam: " + tekToplam);
            // Console.WriteLine("Çift Toplam: " + ciftToplam);

            // break, continue
            for (int i = 1; i < 10; i++)
            {
                if (i == 4)
                {
                    break;  
                }
                Console.WriteLine(i);
            }

            for (int i = 1; i < 10; i++)
            {
                if (i == 4)
                {
                    continue;  
                }
                Console.WriteLine(i);
            }
        }
    }
}