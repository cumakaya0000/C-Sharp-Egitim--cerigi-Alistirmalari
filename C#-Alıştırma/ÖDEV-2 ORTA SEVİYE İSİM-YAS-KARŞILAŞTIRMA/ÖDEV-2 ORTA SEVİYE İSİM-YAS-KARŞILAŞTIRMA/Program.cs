

using System;


namespace ÖDEV_2_ORTA_SEVİYE_İSİM_YAS_KARŞILAŞTIRMA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //SORU 2- Kullanıcıdan adı, doğum yılı ve yerleştirme puanı alın.
            //Yaşını otomatik olarak 2025 - doğum yılı ile hesapla.
            //Ardından şu şekilde yazdır:

            //ÇIKTI: Merhaba Ali, 2004 doğumlusun ve şu an 21 yaşındasın.
            //Üniversiteye giriş puanın: 423.5
            //Durum: Reşitsin.Üniversiteye girebilirsin.

            string ad;
            Console.WriteLine("adinizi giriniz");
            ad = Console.ReadLine();

            int dogumYili;
            Console.WriteLine("Dogum yilini gir:");
            dogumYili =Convert.ToInt32(Console.ReadLine());

            int yasHesapla = 2025 - dogumYili;
            


            if(yasHesapla>=18)
            {
                Console.WriteLine("Reşitsin Girebilirsin");
            }
            else
            {
                Console.WriteLine("Resit Degilsin Giremezsin");
            }

                double puan;
            Console.WriteLine("Yerleştirme puanini giriniz:"); 
            puan = Convert.ToDouble(Console.ReadLine());

            if(puan>=423.5)
            {
                Console.WriteLine("universiteye girmeye hak kazandin");
            }
            else
            {
                Console.WriteLine("Puaniniz Yeterli degil");
            }

            Console.WriteLine("Merhaba " + ad + dogumYili+" doğumlusun ve şu an " + yasHesapla+ "yaşındasın.");
        }
    }
}





