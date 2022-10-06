using System;

namespace static_sinif_ve_uyeler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Çalışan Sayısı: {0}", Calisan.CalianSayisi);

            Calisan calisan = new Calisan("Ayşe","Yılmaz","IK");
            Console.WriteLine("Çalışan Sayısı: {0}", Calisan.CalianSayisi);
            
            Calisan calisan1 = new Calisan("Deniz","Arda","IK");
            Calisan calisan2 = new Calisan("Ömer","Akyol","IK");
            Console.WriteLine("Çalışan Sayısı: {0}", Calisan.CalianSayisi);

            Console.WriteLine("Toplama İşlemi Sonucu: {0}", Islemler.Topla(100,200));
            Console.WriteLine("Çıkarma İşlemi Sonucu: {0}", Islemler.Çıkar(400,50));

        }
    }

    class Calisan
    {
        private static int calianSayisi;
        public static int CalianSayisi { get => calianSayisi; }
        private string Isim;
        private string Soyisim;
        private string Departman;
        
        static Calisan()
        {
            calianSayisi = 0;
        }

        public Calisan(string isim, string soyisim, string departman)
        {
            this.Isim = isim;
            this.Soyisim = soyisim;
            this.Departman = departman;
            calianSayisi ++;
        }
    }

    static class Islemler
    {
        public static long Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }
        public static long Çıkar(int sayi1, int sayi2)
        {
            return sayi1 - sayi2;
        }
    }
}