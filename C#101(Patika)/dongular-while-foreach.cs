using System;

namespace dongular_while_foreach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // //While
            // //1'den Başlayarak Console'dan Girilen Sayıya Kadar (sayı dahil) Ortalama Hesaplayıp Console'a Yazdıran Program.
            // Console.Write("Lütfen Bir Sayi Giriniz: ");
            // int sayi = int.Parse(Console.ReadLine());
            // int sayac = 1;
            // int toplam = 0;
            // while (sayac <= sayi)
            // {
            //     toplam += sayac;
            //     sayac ++;
            // }
            // Console.WriteLine(toplam/sayi);

            // // A'dan Z'ye Kadar Tüm Harfleri Console'a Yazdır.
            // char character = 'a';
            // while (character < 'z')
            // {
            //     Console.Write(character);
            //     character ++;
            // }

            Console.Write("***** Foreach *****");
            string[] arabalar = {"BMW","Ford","Toyota","Nissan"};

            foreach (var araba in arabalar)
            {
                Console.WriteLine(araba);
            }
        }
    }
}