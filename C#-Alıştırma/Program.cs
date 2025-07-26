using System;

namespace Ödev_7_Taksi_Ucret_Hesaplama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Taksi Ücret Hesaplamaya Hoşgeldiniz 🚖");
            Console.WriteLine("Kurallar:");
            Console.WriteLine("- Açılış Ücreti: 20 TL");
            Console.WriteLine("- KM başı: 12 TL");
            Console.WriteLine("- Gece tarifesi (22:00 - 06:00): %20 zamlı");
            Console.WriteLine("- 5 KM'den kısa mesafelerde sabit ücret: 50 TL");

            Console.WriteLine("\nLütfen saati giriniz (0-23):");
            int saat = Convert.ToInt32(Console.ReadLine());

            if (saat < 0 || saat > 23)
            {
                Console.WriteLine("Geçersiz saat girdiniz.");
                return;
            }

            Console.WriteLine("Kaç KM yol gidildi?");
            int yol = Convert.ToInt32(Console.ReadLine());

            if (yol < 5)
            {
                Console.WriteLine("Ücretiniz: 50 TL (Kısa Mesafe Sabit Ücret)");
            }
            else if (saat >= 22 || saat < 6) // Gece tarifesi
            {
                double ucret = ((yol * 12) + 20) * 1.2;
                Console.WriteLine("Gece Tarifesiyle Ücretiniz: " + ucret + " TL");
            }
            else // Gündüz tarifesi
            {
                double ucret = (yol * 12) + 20;
                Console.WriteLine("Gündüz Tarifesiyle Ücretiniz: " + ucret + " TL");
            }

            Console.WriteLine("İyi yolculuklar, yine bekleriz!");
        }
    }
}
