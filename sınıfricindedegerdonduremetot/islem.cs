using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sınıfricindedegerdonduremetot
{
    internal class islem
    {
       
        public int toplam(int s1,int s2)
        {
            int s3 = s1 + s2;
            Console.WriteLine("Sonuc" +s3);
            return s3;
        }
        public int kare(int deger)
        {
            int sonuc = deger * deger;
            Console.WriteLine("Sonuc" + sonuc);
            return sonuc;
        }
        
    }
}
