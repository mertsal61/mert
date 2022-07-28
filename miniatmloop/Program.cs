using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miniatmloop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int bakiye = 700;

            Console.WriteLine("ATM");

            Console.WriteLine("İşlem seç");
            Console.WriteLine("1-Bakiye görüntüle");
            Console.WriteLine("2-para çek");
            Console.WriteLine("3-para yatır");
            Console.WriteLine("4-çıkış yap");

            string secim = Console.ReadLine();

            while (!secim.Equals("4"))
            {

                switch (secim)
                {
                    case "1":
                        Console.WriteLine("Bakiyeniz:" + bakiye);
                        break;

                    case "2":
                        Console.WriteLine("çekmek istediğin tutar");
                        int cekilecek_tutar = int.Parse(Console.ReadLine());
                        if (cekilecek_tutar > bakiye)
                        {
                            Console.WriteLine("Bakiyenizden fazla para çekemezsniz");
                        }
                        else
                        {
                            Console.WriteLine("kalan bakiyeniz" + (bakiye - cekilecek_tutar));
                            bakiye=bakiye- cekilecek_tutar;
                        }
                        break;
                    case "3":
                        Console.WriteLine("yatırmak istediğin tutarı gir");
                        int yatırılacak_tutar = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("yeni bakiyeniz" + (yatırılacak_tutar + bakiye));
                        bakiye = bakiye + yatırılacak_tutar;
                        break;
                    default:
                        Console.WriteLine("lütfen işlem seç");
                        break;


                }
                Console.WriteLine("İşlem seç");
                Console.WriteLine("1-Bakiye görüntüle");
                Console.WriteLine("2-para çek");
                Console.WriteLine("3-para yatır");
                Console.WriteLine("4-çıkış yap");
                secim = Console.ReadLine();
            }










        }
    }
}
