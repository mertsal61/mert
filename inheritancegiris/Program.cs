using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritancegiris
{
    internal class Program
    {
        static void Main(string[] args)
        {

            kedi kedi = new kedi();
            kedi.hayvan_isim = "a";
            kedi.hayvan_cinsiyet = "disi";
            kedi.hayvan_rengi = "kırmızı";

            //kedi._hayvanınyasi = 20;



            
            kedi.set1(20);
            kedi.get2();
            
            kedi.hayvanbilgisigoster();
            //Console.WriteLine("hayvanyasi" + kedi._hayvanınyasi);


            Console.ReadLine();
        }
    }
}
