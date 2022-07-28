using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace publicveprivateerisimbelirleyicileri
{
    public class musteri
    {
        public string isim;
        public string soyisim;
        public int maasdegeri;
        public string cinsiyet;
        public int yas;

        public musteri()
        {
            Console.WriteLine("müşteri sınıfının yapıcı metodu çalıştı");
        }



        public void musteribilgilerigonder()
        {
            Console.WriteLine("isim"+isim);
            Console.WriteLine("soyisin"+soyisim);
            Console.WriteLine("maas değeri"+maasdegeri);
            Console.WriteLine("cinsiyet"+cinsiyet);
            Console.WriteLine("yaş değeri"+yas);
        }
        private void isimsoyisimyazdir(string musteriisim,string musterisoyisim)

        {
            Console.WriteLine("müşterinin isim ve soyismi"+musteriisim+""+musterisoyisim);
        }
    }
}
