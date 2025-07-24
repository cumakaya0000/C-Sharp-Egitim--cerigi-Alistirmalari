using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÖDEV_1_EKRANDAN_İSİM_YAS_ALMA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //SORU  KULLANICIDAN AD , SOYAD, OKUDUGU OKUL , KAÇ YAŞINDA OLDUGU , ÜNİDE KAÇ PUAN ALDIGI GİRSİN BİZDE BUNLARI EKRANA YAZDIRALIM 


            string ad;
            Console.Write("Lutfen adinizi giriniz:");
            ad = Console.ReadLine();
            Console.WriteLine("Adiniz :" + ad);

            string soyAd;
            Console.Write("Soy adinizi giriniz :");
            soyAd = Console.ReadLine();
            Console.WriteLine("Soy adiniz: "+ soyAd);


            string okul;
            Console.WriteLine("Okul isminizi giriniz:");
            okul = Console.ReadLine();
            Console.WriteLine("Okul isminiz:" + okul);


            int yas;
            Console.WriteLine("Yasinizi giriniz :");
            yas = Convert.ToByte(Console.ReadLine());
            
            if (yas > 18)
            {
                Console.WriteLine("uniye girebilirsin");
                
            }
            else 
            {
                Console.WriteLine("uniye giremezsin");
            }



            double puan;
            Console.WriteLine("Yerleştirme Puani Giriniz:");
            puan = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Yerlestirme puani : " + puan);

           
            

        }
    }
}
