﻿using System;

namespace csharp_enum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Gunler.Pazar);
            Console.WriteLine((int)Gunler.Cumartesi);

            int sıcaklık = 32;

            if(sıcaklık <= (int)HavaDurumu.Normal)
            {
                Console.WriteLine("Dışarıya Çıkmak İçin Havanın Biraz Daha Isınmasını Bekleyelim.");
            }
            else if (sıcaklık >= (int)HavaDurumu.Sıcak)
            {
                Console.WriteLine("Dışarıya Çıkmak İçin Çok Sıcak Bir Gün");
            }
            else if (sıcaklık >= (int)HavaDurumu.Normal && sıcaklık < (int)HavaDurumu.CokSıcak)
            {
                Console.WriteLine("Hadi Dışarıya Çıkalım!");
            }
        }
    }

    enum Gunler
    {
        Pazartesi = 1, 
        Sali, 
        Carsamba, 
        Persembe, 
        Cuma = 23, 
        Cumartesi, 
        Pazar
    }

    enum HavaDurumu
    {
        Soguk = 5,
        Normal = 20,
        Sıcak =25,
        CokSıcak = 30
    }
}