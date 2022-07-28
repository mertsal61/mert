using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_kullanımı
{
    internal class Program
    {
        static void Main(string[] args)
        {

            araba araba1 = new araba();

            araba1.kapiSayisii = 4;
            araba1.arabaRengi = "Kırmızı";
            araba1.arabaModel = "Renault";

            araba1.kapilarikilitle();
            araba1.motorlistir();

            Console.WriteLine("Arabanın kapı sayısı:"+araba1.kapiSayisi);
            Console.WriteLine("Araba Rengi"+araba1.arabaRengi);
            Console.WriteLine("Arabanın mdoeli"+araba1.arabaModel);

            Console.ReadLine();


        }
    }
}
