using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders_4_Girdi_Alma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ekrana Çıktı Verme
            //Console.Writeline("Adinizi Giriniz:");


            //Ekrandan deger alma
            //name =Console.Readline(); Burdan ben degeri alacagımı belirtiyorum
            //Console.Writeline ("Adinizi Giriniz:"+ name );


            Console.Write("Adinizi Giriniz:");

            string ad;
            ad = Console.ReadLine();

            Console.Write("adiniz  :" + ad);


            Console.Write("Lutfen yasinizi Giriniz");

            int yas;

            yas = Convert.ToInt32(Console.ReadLine()); //Burada yapılan şu string de normal bir şekilde deger alınır ancak başka bir deger alımı için "conver. yapısından seçerek kullanmamız gerekiyor"

            Console.WriteLine("Yasiniz : "+yas);

        }
    }
}
