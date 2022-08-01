using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ogrenciuygulamsi
{
    public class ogrenci
    {
        int ogrencino;
        string ogrenciismi;
        double vize1;
        double vize2;
        double final;
        string okul_ismi;

        public ogrenci(int ogrencino, string ogrenciismi, int vize1, int vize2, int final, string okul_ismi)
        {
            this.ogrencino = ogrencino;
            this.ogrenciismi = ogrenciismi;
            this.vize1 = vize1;
            this.vize2 = vize2;
            this.final = final;
            this.okul_ismi = okul_ismi;
        }

        public void ogrencibilgilerigöster()
        {
            Console.WriteLine("Öğrenci No:" + ogrencino);
            Console.WriteLine("Öğrenci İsmi: " + ogrenciismi);
            Console.WriteLine("Öğrenci vize1: " + vize1);
            Console.WriteLine("Öğrenci vize2: " + vize2);
            Console.WriteLine("Öğrenci final: " + final);
            Console.WriteLine("öğrenci okulu: " + okul_ismi);
        }

        public double ortalama()
        {
            double ortalama;
            ortalama = (vize1 + vize2 + final) / 3;
            return ortalama;


            public ogrenci ()
            {

            }
        }

        public void okulugoster()
        {
            Console.WriteLine("öğrenci okulu"+okul_ismi);
        }


    }
}
