using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritancegiris
{
    public class hayvan
    {
        public string hayvan_isim;
        public string hayvan_cinsiyet;
        public string hayvan_rengi;

        private int hayvanin_yasi;

        public void set1(int yas)
        {
            hayvanin_yasi = yas;
        }
        public int get2()       //get set
        {
            Console.WriteLine(hayvanin_yasi);
            return hayvanin_yasi;
        }

        /* public int _hayvanınyasi            //property
         {
             set
             {
                 hayvanin_yasi = value;
             }
             get
             {
                 return hayvanin_yasi;
             }
         }*/
        public void hayvanbilgisigoster()
        {
            Console.WriteLine("hayvanın ismi" + hayvan_isim);
            Console.WriteLine("hayvanın cinsiyei" + hayvan_cinsiyet);
            Console.WriteLine("hayvaın rengi" + hayvan_rengi);
        }
    }
}
