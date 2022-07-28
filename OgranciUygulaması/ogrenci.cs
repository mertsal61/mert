using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgranciUygulaması
{
    public class ogrenci
    {

        private int ogrencino;
        private string isim;
        private string soyisim;
        private int vize1;
        private int vize2;
        private int final;
        private string okulismi;


        public void ograncibilgilerigoster()
        {
            Console.WriteLine("Öğrenci numarası" + ogrencino);
            Console.WriteLine("Çğrenci isim" + isim);
            Console.WriteLine("Ogrenci Soyisid" + soyisim);
            Console.WriteLine("Öğrenci vizesi1" + vize1);
            Console.WriteLine("Öğrenci vizesi2" + vize2);
            Console.WriteLine("Öğrenci final" + final);
            Console.WriteLine("Öğrenci Okul İsmi" + okulismi);
        }

        public double ogrencinotubul()
        {
            double ortalama = vize1 * 0.2 + vize2 * 0.2 + final * 0.6;
            return ortalama;
        }

        public void okulugetir()
        {
            Console.WriteLine("öğrencinin okulu"+okulismi);
            
        }
    }
}
