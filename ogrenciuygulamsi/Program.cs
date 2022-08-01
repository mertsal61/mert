using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ogrenciuygulamsi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int secim;
            
            Console.WriteLine("Uygulamaya hoşgeldin.İşlemi Seç");
            islemlerigoster();
            secim = Convert.ToInt32(Console.ReadLine());    
            ogrenci ogrenci1 = new ogrenci(1, "ENES", 50, 40, 73, "DoğuşÜni");
            while (secim!=4)
            {
                if (secim == 1)
                    ogrenci1.ogrencibilgilerigöster();

                else if (secim == 2)
                    Console.WriteLine("Öğrenci ortalaması:" + ogrenci1.ortalama());
                else if (secim == 3)
                    ogrenci1.okulugoster();
                else
                    Console.WriteLine("geçerli sayı gir");
                
                islemlerigoster();
                secim = Convert.ToInt32(Console.ReadLine());
            }
            
            Console.ReadLine();
        }

        private static void islemlerigoster()
        {
            Console.WriteLine("1-Öğrenci Bilgileri göster");
            Console.WriteLine("2-öğrenci ortalam göster");
            Console.WriteLine("3-öğrenci okulunu göster");
            Console.WriteLine("4-Çık");
        }
    }
}
