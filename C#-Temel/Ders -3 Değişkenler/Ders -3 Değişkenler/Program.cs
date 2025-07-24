using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders__3_Değişkenler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Değişkenler ,Veri Tipleri


            //Degişken Belirleme

            //- Veri Tipi Degişken ismi = 23;
            //- string      ad =        "Cuma";

            string ad = "cuma";
            Console.WriteLine(ad);




            //Degişken Tipleri


            //----------------String Metin tipi---------------

            string isim = "kaya";
            Console.WriteLine(isim);


            // ----------------Tam sayi tipi-----------------------

            int num = 100;
            Console.WriteLine(num);


            //------------------Kesirli sayi tipi------------------

            float kesirli = 1234.7f; //Noktadan sonra f harfini unutma
            Console.WriteLine("Kesirli sayi:"+kesirli);



            //--------------------Decimal tipi ----------------------- ,sadece finansal hesaplama islemleri için kullanılır

            decimal amount = 100.50M; //Noktadan sonra M harfi koy unutma
            Console.WriteLine(amount);
        }
    }
}
