using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lutfen Urun Fiyatlarini Giriniz :");

            double sayi;
           sayi= Convert.ToDouble(Console.ReadLine());

            double sayi1;
            sayi1= Convert.ToDouble(Console.ReadLine());

            double sayi2;
            sayi2= Convert.ToDouble(Console.ReadLine());

            double sonuc = sayi + sayi1 + sayi2;

            if (sonuc >=500)
            {
                double indirim = sonuc / 10;
                Console.WriteLine("Kazandıgınız İndirim"+indirim);
                Console.WriteLine("Odemeniz gereken tutar:"+sonuc );
                
            }
            else
            {
                Console.WriteLine ("İndirimm kazanamadız odemeniz gereken tutar"+sonuc);
            }


        }
    }
}
