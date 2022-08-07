using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sınıfricindedegerdonduremetot
{
    internal class kimlikv2
    {
        public kimlikv2()
        {
            AD = "";
            SOYAD = "";
            YAS = 18;
            MEMLEKET = "ankara".ToUpper();
            CINSIYET = 'k';

        }

        public string AD { get; set; }
        public string SOYAD { get; set; }
        public string MEMLEKET { get; set; }
        public int YAS { get; set; }
        public char CINSIYET { get; set; }
        

    }
}
