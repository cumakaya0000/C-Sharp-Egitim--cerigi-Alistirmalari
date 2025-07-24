using System;

namespace Ödev_3_Aritmatiksel_İşlemler_Önceki_Konuları_Pekiştirme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcıdan adı ve doğum yılı alın. Sonra ismini ve yaşını şu şekilde yaz:

            //Merhaba Ali, 21 yaşındasın. ÇIKTI
            //(Şu an yıl 2025 olduğunu varsay.)


            Console.WriteLine("Lutfen Adinizi Giriniz:");
            string ad = Console.ReadLine();


            Console.WriteLine("Lutfen dogum tarihinizi giriniz");

            int sayi;
            int dogumyili = 2025;

            sayi = Convert.ToInt32(Console.ReadLine());

            int sonuc = sayi - dogumyili;

            Console.WriteLine("Merhaba" + ad + sonuc + " yasindasin");




            //------------------------------------------------------------------------------------
            //3 tane sınav notu al. Ortalamayı hesapla.
            //Ardından şu şekilde yazdır:
            //Ortalaman: 75.3 - Durum: Geçtin
            //Eğer ortalama 50’nin altındaysa "Kaldın" yazsın.

            Console.WriteLine("NOT HESAPLAMA PROGRAMINI HOŞGELDİNİZ BAŞLAMAK İÇİN ENTER TUŞUNA BASINIZ");

            Console.WriteLine("Lutfen Birinci Vize Notunuzu Giriniz:");

            double vize1;
            
            vize1 =Convert.ToDouble(Console.ReadLine());

            //Vize iki isteniyor 
            Console.WriteLine("Lutfen İkinci Vize notunu giriniz:");

            double vize2; 
            
            vize2=Convert.ToDouble(Console.ReadLine());

            //Final notu isteniyor 

            Console.WriteLine("Final notunu giriniz:");
            Double final;

            final=Convert.ToDouble(Console.ReadLine());


            double hesaplayici = (vize1 + vize2 + final)/3;


            if (hesaplayici >= 50)
            {
                Console.WriteLine("Ortalaman:"+hesaplayici+ " Sınıfı Geçtin");
            }
            if (hesaplayici >70)
            {
                Console.WriteLine("Ortalaman:" +hesaplayici+" İyi bir puan ile geçtin");
            }
            if(hesaplayici <50)
            {
                Console.WriteLine("Ortalaman"+hesaplayici+" Maalesef Basarısız oldun");
            }

        


        }
    }
}
